using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas.maestros
{
    public partial class FrmMarcaV : Form
    {
        public FrmMarcaV()
        {
            InitializeComponent();
        }


        private BL.ClsMarcaV ClsMarca = new BL.ClsMarcaV();
        private String idMarca = "0";

        
        private void frmMarca_Load(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = ClsMarca.seleccionar(txtNombre.Text);
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void limpiarControles()
        {
            try
            {
                idMarca = "0";
                txtNombre.Clear();
                buscar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        idMarca = grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value.ToString();
                        txtNombre.Text = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            ClsMarca.eliminar(grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                idMarca = "0";
                ClsHelper.erroLog(ex);
            }
        }


        

        private void btnCAncelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                limpiarControles();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }

        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.ClsMarca.grabarModificar(idMarca, txtNombre.Text.Trim());
                limpiarControles();
                ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
            }
            catch (Exception ex)
            {
                idMarca = "0";
                ClsHelper.erroLog(ex);
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

    }
}
