using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
    public partial class FrmPago : Form
    {
        BL.ClsPago ClsPago = new BL.ClsPago();
        public FrmPago()
        {
            InitializeComponent();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                grdVenta.DataSource = ClsPago.buscarVentaEncabezado(txtBusqueda.Text.Trim());
                cargarListaPagos();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        private void grdVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        {
                            cargarListaPagos();
                            break;
                        }
                    case 1:
                        {
                            mostrarEstadoCuenta();
                            break;
                        }
                    case 2:
                        {
                            FrmNuevoPago frm = new FrmNuevoPago();
                            frm.idVenta = Convert.ToInt32(grdVenta.SelectedRows[0].Cells["idVentaCol"].Value.ToString());
                            frm.ShowDialog();
                            cargarListaPagos();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        void cargarListaPagos()
        {
            try
            {
                if (grdVenta.SelectedRows.Count > 0)
                {
                    lblTituloVenta.Text = "Lista de pagos de " +
                        grdVenta.SelectedRows[0].Cells["nombreCol"].Value.ToString() + " " +
                        grdVenta.SelectedRows[0].Cells["vehiculoCol"].Value.ToString();
                    grdPago.DataSource = ClsPago.seleccionarPagos(grdVenta.SelectedRows[0].Cells["idVentaCol"].Value.ToString());
                }
                else
                {
                    lblTituloVenta.Text = "Lista de Pagos Recibidos";
                    grdPago.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        void mostrarEstadoCuenta()
        {
            try
            {
                BL.ClsReportes ClsReportes = new BL.ClsReportes();
                DataSet dts = new DataSet();
                FrmReporte FrmReporte = new FrmReporte();
                dts = ClsReportes.rptEstadoCuenta(grdVenta.SelectedRows[0].Cells["idVentaCol"].Value.ToString());
                FrmReporte.cargarReporte("RptEstadoCuenta", dts);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grdPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        {//Muestra el archivo adjunto
                            String rutaAdjunto = grdPago.SelectedRows[0].Cells["rutaAdjuntoCol"].Value.ToString();
                            if (String.IsNullOrEmpty(rutaAdjunto))
                            {
                                ClsHelper.MensajeSistema("No hay archivo adjunto para mostrar");
                                return;
                            }
                            if (!File.Exists(rutaAdjunto))
                            {
                                ClsHelper.MensajeSistema("No existe el archivo o no tiene acceso a él");
                                return;
                            }
                            System.Diagnostics.Process.Start(rutaAdjunto);
                            break;
                        }
                    case 1:
                        {//anula pago
                            BL.ClsPago ClsPago = new BL.ClsPago();
                            if (MessageBox.Show("¿Confirma que desea anular este pago?" + Environment.NewLine + "Quedará registro de esta accion", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                            {
                                return;
                            }
                            try
                            {
                                ClsPago.anularPago(grdPago.SelectedRows[0].Cells["idPagoCol"].Value.ToString());
                            }
                            catch (Exception ms)
                            {//Excepción propia porque la consulta devuelve raiserror
                                ClsHelper.MensajeSistema(ms.Message);
                            }
                            cargarListaPagos();
                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


    }
}
