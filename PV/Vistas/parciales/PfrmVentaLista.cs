using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas.parciales
{
    public partial class PfrmVentaLista : Form
    {
        private BL.ClsVenta clsVenta = new BL.ClsVenta();
        private PV.FrmVenta _p = new FrmVenta();
        public PfrmVentaLista(FrmVenta p)
        {
            InitializeComponent();
            this._p = p;
        }

        public void PfrmListaVentas_Load(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = this.clsVenta.seleccionar(this.txtCriterio.Text);
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
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                this._p.cargarFormNuevaVenta();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        string idVenta = grdExistentes.SelectedRows[0].Cells["idVentaCol"].Value.ToString();
                        this._p.cargarFormNuevaVenta(idVenta);
                        //this.idVehiculo = grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString();
                        //this.padre.cargarFormIngreso(this.idVehiculo);
                        //txtNombre.Text = grdExistentes.SelectedRows[0].Cells["lineaCol"].Value.ToString();
                        //cmbMarca.SelectedValue = grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value;
                        //txtNombre.Enabled = true;
                        //txtNombre.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            //this.clsVehiculo.eliminar(grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            //limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                //this.idVehiculo = "0";
                ClsHelper.erroLog(ex);
            }
        }

        
    }
}
