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
using WIA;
using System.Windows.Media.Imaging;


namespace PV
{
    public partial class FrmNuevoPago : Form
    {
        private BL.ClsPago ClsPago = new BL.ClsPago();
        private BL.ClsMetodoPago ClsMetodoPago = new BL.ClsMetodoPago();
        public Int32 idVenta;
        private String adjunto = string.Empty;

        public FrmNuevoPago()
        {
            InitializeComponent();
        }

        private void FrmNuevoPago_Load(object sender, EventArgs e)
        {
            try
            {
                //BORRAR
                //ClsGlobals.usuario = "aramirez";
                //BORRAR 

                cboMetodoPago.DataSource = ClsMetodoPago.SeleccionarMetodoPago();
                cboMetodoPago.ValueMember = "idMetodoPago";
                cboMetodoPago.DisplayMember = "nombre";
                cargarDatosNuevoPago();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        void cargarDatosNuevoPago()
        {
            DataSet dts = new DataSet();
            try
            {
                dts = ClsPago.obtenerInformacionPago(idVenta.ToString());
                if (dts.Tables[0].Rows.Count < 1)
                {
                    ClsHelper.MensajeSistema("No hay datos para mostrar");
                    this.Close();
                }

                lblTitulo.Text = dts.Tables[0].Rows[0]["cliente"].ToString() + " Tel:" + dts.Tables[0].Rows[0]["telefonos"].ToString() + " " +
                                    dts.Tables[0].Rows[0]["vehiculo"].ToString() + " Fecha venta: " + dts.Tables[0].Rows[0]["fecha"].ToString();
                lblCuotas.Text = dts.Tables[0].Rows[0]["cantidadCuotas"].ToString().PadLeft(2, '0');
                lblDiaPago.Text = dts.Tables[0].Rows[0]["diaPago"].ToString().PadLeft(2, '0');

                colocarCantidad(dts.Tables[0].Rows[0]["valorVenta"].ToString(), lblPrecioVentaE, lblPrecioVentaD);
                colocarCantidad(dts.Tables[0].Rows[0]["enganche"].ToString(), lblEngancheE, lblEngancheD);
                colocarCantidad(dts.Tables[0].Rows[0]["montoInicial"].ToString(), lblSaldoInicialE, lblSaldoInicialD);
                colocarCantidad(dts.Tables[0].Rows[0]["saldoActual"].ToString(), lblSaldoActualE, lblSaldoActualD);
                colocarCantidad(dts.Tables[0].Rows[0]["cuota"].ToString(), lblCuotaE, lblCuotaD);
                colocarCantidad(dts.Tables[2].Rows.Count > 0 ? dts.Tables[2].Rows[0]["PendienteUltimaCuota"].ToString() : "0.00", lblParcialPendienteE, lblParcialPendienteD);
                lblCuotasAtrasadas.Text = dts.Tables[3].Rows.Count.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void colocarCantidad(String cantidad, Label lblEntero, Label lblDecimal)
        {

            try
            {
                lblEntero.Text = cantidad.Split('.')[0];
                lblDecimal.Text = cantidad.Split('.')[1];
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClsHelper.IsNumeric(txtMonto.Text))
                {
                    ClsHelper.MensajeSistema("Debe Ingresar un número Válido");
                    txtMonto.Focus();
                    return;
                }
                //Avisa si no ha adjuntado
                if (MessageBox.Show("No ha adjuntado ningún archivo, ¿Desea continuar sin comprobante?", "Continuar sin adjunto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
                ClsPago.grabarPago(this.idVenta.ToString(), txtMonto.Text, cboMetodoPago.SelectedValue.ToString(), txtObservaciones.Text, adjunto);
                ClsHelper.MensajeSistema("Pago registrado con éxito");
                limpiarControles();
                btnImprimir.Enabled = true;
            }
            catch (Exception ex)
            {

                ClsHelper.MensajeSistema(ex.Message);
            }
            finally
            {
                limpiarControles();
            }
        }

        void limpiarControles()
        {
            try
            {
                cargarDatosNuevoPago();
                txtMonto.Clear();
                txtObservaciones.Clear();
                cboMetodoPago.SelectedValue = 1;
                adjunto = string.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                BL.ClsReportes ClsReportes = new BL.ClsReportes();
                DataTable dt = new DataTable();
                FrmReporte frm = new FrmReporte();
                dt = ClsReportes.rptRecibos();
                frm.cargarReporte("RptRecibo", dt);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files (*.jpg)|*.jpg";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!String.IsNullOrEmpty(sfd.FileName))
                    {
                        FrmScanner frm = new FrmScanner();
                        frm.ruta = sfd.FileName;
                        if (frm.cargarForm())
                        {
                            adjunto = sfd.FileName; 
                            ClsHelper.MensajeSistema("Adjuntado correctamente");
                        }
                        else
                        {
                            ClsHelper.MensajeSistema("No se pudo realizar la operación");
                        }

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
