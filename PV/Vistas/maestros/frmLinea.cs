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
    public partial class FrmLinea : Form
    {
        private BL.ClsLinea clsLinea = new BL.ClsLinea();
        private string idLinea = "0";

        public FrmLinea()
        {
            InitializeComponent();
            txtNombre.Enabled = false;
        }


        private void frmLinea_Load(object sender, EventArgs e)
        {
            
            cargarComboMarca();
            //cmbMarca.Items.Insert(0, "Por favor seleccione un valor...");
            //cmbMarca.SelectedIndex = 0;
            buscar();
        }

        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = clsLinea.seleccionar(txtNombre.Text);
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarComboMarca()
        {
            BL.ClsMarcaV clsMarca = new BL.ClsMarcaV();
            //DataTable dt = clsMarca.seleccionar("");
            cargarCombos(clsMarca.seleccionar(""), cmbMarca);

        }

        private void cargarCombos(DataTable dataTable, ComboBox combo)
        {
            Dictionary<int, String> dicTipoVehiculo = new Dictionary<int, string>();
            dicTipoVehiculo.Add(0,"Seleccione una Marca...");
            foreach (DataRow row in dataTable.Rows)
            {
                dicTipoVehiculo.Add(Int32.Parse(row[0].ToString()), row[1].ToString());
            }
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.DataSource = dicTipoVehiculo.ToArray();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        public void cmbMarca_selected_item(object sender, EventArgs e)
        {
            if (Int32.Parse(cmbMarca.SelectedValue.ToString()) > 0)
            {
                this.txtNombre.Enabled = true;
                this.txtNombre.Focus();
            }
            else
            {
                limpiarControles();
            }

        }

        private void limpiarControles()
        {
            this.cmbMarca.SelectedValue = 0;
            this.txtNombre.Enabled = false;
            this.txtNombre.Clear();
            idLinea = "";
            buscar();
            txtNombre.Focus();
            
        }

        private void btnCAncelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiarControles();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                this.clsLinea.grabarModificar(idLinea, txtNombre.Text.Trim(),cmbMarca.SelectedValue.ToString());
                limpiarControles();
                ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
            }
            catch (Exception ex)
            {
                idLinea = "0";
                ClsHelper.erroLog(ex);
            }
        }


        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        idLinea = grdExistentes.SelectedRows[0].Cells["idLineaCol"].Value.ToString();
                        txtNombre.Text = grdExistentes.SelectedRows[0].Cells["lineaCol"].Value.ToString();
                        cmbMarca.SelectedValue = grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value;
                        txtNombre.Enabled = true;
                        txtNombre.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            clsLinea.eliminar(grdExistentes.SelectedRows[0].Cells["idLineaCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                idLinea = "0";
                ClsHelper.erroLog(ex);
            }
        }

    }
}
