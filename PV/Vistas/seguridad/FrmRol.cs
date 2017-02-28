using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
    public partial class FrmRol : Form
    {
        private BL.ClsSeguridad ClsSeguridad = new BL.ClsSeguridad();
        public FrmRol()
        {
            InitializeComponent();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            cargarComboRol();
        }

        void cargarComboRol()
        {
            try
            {
                cboRol.DataSource = ClsSeguridad.seleccionarRol();
                cboRol.ValueMember = "idRol";
                cboRol.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void grdDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboRol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }

            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }


        private void cargarGrid()
        {
            try
            {
                //llena grid
                grdDetalle.DataSource = ClsSeguridad.selecFormulariosRol(Convert.ToInt32(cboRol.SelectedValue));
                //columna combobox
                DataTable dtModo = new DataTable();
                dtModo.Columns.Add("codigo");
                dtModo.Columns.Add("descripcion");
                dtModo.Rows.Add("0X", "0X-Sistemas");
                dtModo.Rows.Add("0X", "0A-Administrador");
                dtModo.Rows.Add("0X", "0T-Usuario estándar");
                foreach (DataGridViewRow row in grdDetalle.Rows)
                {
                    ComboBox cbo = new ComboBox();
                    cbo.DataSource = dtModo;
                    cbo.DisplayMember = "descripcion";
                    cbo.ValueMember = "codigo";
                    cbo.SelectedValue = row.Cells["modoCol"].Value;

                    //DataGridViewComboBoxCell comboModo = new DataGridViewComboBoxCell();
                    //comboModo = (DataGridViewComboBoxCell)(row.Cells["modoCol"]);

                    //comboModo.DataSource = dtModo;
                    //comboModo.DisplayMember = "descripcion";
                    //comboModo.ValueMember = "codigo";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int idRol = Convert.ToInt32(cboRol.SelectedValue);
            int idFormulario;
            string modo;
            int acceso;
           
            try
            {
                foreach (DataGridViewRow r in grdDetalle.Rows)
                {
                    idFormulario = Convert.ToInt32(r.Cells["idFormularioCol"].Value.ToString());
                    modo = r.Cells["modoCol"].Value.ToString();
                    acceso = Convert.ToInt32(string.IsNullOrEmpty(r.Cells["accesoCol"].Value.ToString())?"0":r.Cells["accesoCol"].Value.ToString());
                    ClsSeguridad.brindarDenegarAcceso(idFormulario, idRol, modo, acceso);
                }

                cargarGrid();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vistas.FrmNuevoRol frm = new Vistas.FrmNuevoRol();
            frm.ShowDialog();
            cargarComboRol();
            cargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
