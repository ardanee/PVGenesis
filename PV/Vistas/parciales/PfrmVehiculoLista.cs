using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas.parciales
{
    public partial class PfrmVehiculoLista : Form
    {

        private PV.FrmVehiculo padre;
        private BL.ClsVehiculo clsVehiculo = new BL.ClsVehiculo();
        private string idVehiculo = "0";
        public PfrmVehiculoLista(PV.FrmVehiculo padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void PfrmListaVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                this.buscar();
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
                this.padre.cargarFormIngreso();
                this.padre.liberarFormListaVehiculos();
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
                grdExistentes.DataSource = this.clsVehiculo.seleccionar(txtNombre.Text);
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.buscar();
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
                this.txtNombre.Clear();
                this.idVehiculo = "0";
                this.buscar();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.idVehiculo = grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString();
                        this.padre.cargarFormIngreso(this.idVehiculo);
                        //txtNombre.Text = grdExistentes.SelectedRows[0].Cells["lineaCol"].Value.ToString();
                        //cmbMarca.SelectedValue = grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value;
                        //txtNombre.Enabled = true;
                        //txtNombre.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsVehiculo.eliminar(grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.idVehiculo = "0";
                ClsHelper.erroLog(ex);
            }
        }

    }
}
