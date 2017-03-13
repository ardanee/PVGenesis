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
    public partial class _FrmSeleccionAuto : Form
    {
        private BL.ClsVehiculo clsVehiculo = new BL.ClsVehiculo();
        private PfrmVentaNueva _p;
        public _FrmSeleccionAuto(PfrmVentaNueva _p)
        {
            InitializeComponent();
            this._p = _p;
        }

        public void _FrmSeleccionAuto_Load(object sender, EventArgs e)
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


        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = this.clsVehiculo.seleccionarVehiculosVenta(txtNombre.Text);
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
                this.txtNombre.Clear();
                this.buscar();
                this.txtNombre.Focus();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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


        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this._p.setVehiculo(
                            grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString(),
                            grdExistentes.SelectedRows[0].Cells["descripcionCol"].Value.ToString(),
                            grdExistentes.SelectedRows[0].Cells["placaCol"].Value.ToString(),
                            grdExistentes.SelectedRows[0].Cells["precioCol"].Value.ToString()
                    );
                        this.Dispose();
                        //MessageBox.Show("Seleccionado: " + grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString());
                        //idMarca = grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value.ToString();
                        //txtNombre.Text = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }
    }
}
