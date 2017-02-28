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
    public partial class FrmTipoVehiculo : Form
    {
        BL.ClsTipoVehiculo ClsTipoVehiculo = new BL.ClsTipoVehiculo();
        string idTipoVehiculo = "0";
        public FrmTipoVehiculo()
        {
            InitializeComponent();
        }

        private void frmTipoVehiculo_Load(object sender, EventArgs e)
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
                grdExistentes.DataSource = ClsTipoVehiculo.seleccionar(txtNombre.Text);
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCAncelar_Click(object sender, EventArgs e)
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsTipoVehiculo.grabarModificar(idTipoVehiculo, txtNombre.Text.Trim());
                limpiarControles();
                ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
            }
            catch (Exception ex)
            {
                idTipoVehiculo = "0";
                ClsHelper.erroLog(ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void limpiarControles()
        {
            try
            {
                idTipoVehiculo = "0";
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
                        idTipoVehiculo = grdExistentes.SelectedRows[0].Cells["idTipoVehiculoCol"].Value.ToString();
                        txtNombre.Text = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            ClsTipoVehiculo.eliminar(grdExistentes.SelectedRows[0].Cells["idTipoVehiculoCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                idTipoVehiculo = "0";
                ClsHelper.erroLog(ex);
            }
        }
    }
}
