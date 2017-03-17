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
    public partial class FrmClienteCotizacion : Form
    {

        private string idVehiculo;
        private string cuotas;
        private string enganche;    
        private string cuotaMensual;
        private string precioNegociado;
        private string tipoCotizacion;
        private string total;
        
       public FrmClienteCotizacion(
           string total,
           string idVehiculo,
           string cuotas,
           string enganche,
           string cuotaMensual,
           string precioNegociado, 
           string tipoCotizacion)
        {
            
            InitializeComponent();
            this.idVehiculo = idVehiculo;
            this.cuotas = cuotas;
            this.enganche = enganche;
            this.cuotaMensual = cuotaMensual;
            this.precioNegociado = precioNegociado;
            this.tipoCotizacion = tipoCotizacion;
            this.total = total;
        }

        private void btnGenerarCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text != "")
                {
                    if (txtSucursal.Text != "")
                    {
                        if (txtTelefono.Text != "")
                        {

                            if (txtVelidez.Text != "")
                            {
                                int i = 0;
                                if (int.TryParse(txtVelidez.Text, out i))
                                {

                                    string ct = "Contado";
                                    if (tipoCotizacion == "0")
                                        ct = "Contado";
                                    else if (tipoCotizacion == "1")
                                        ct = "Financiamiento";
                                    //ClsHelper.MensajeSistema("cuotas: " +cuotas);
                                    BL.ClsCotizacion clsCotizacion = new BL.ClsCotizacion();

                                    DataTable dt = clsCotizacion.agregar(idVehiculo, txtCliente.Text, enganche, cuotas, cuotaMensual, precioNegociado, txtSucursal.Text,
                                        txtTelefono.Text, ct, total,txtVelidez.Text.Trim());


                                    BL.ClsReportes clsReporte = new BL.ClsReportes();

                                    if (dt.Rows.Count == 1)
                                    {
                                        DataTable dtt = clsReporte.reporteCotizacion(dt.Rows[0]["numeroCotizacion"].ToString());
                                        FrmReporte rpt = new FrmReporte();
                                        rpt.cargarReporte("RptCotizacion", dtt);
                                    }
                                    else
                                    {
                                        ClsHelper.MensajeSistema("no hgay cotizacion");
                                    }
                                    deshabilitarControles(false);
                                    /*DataTable dt = clsReporte.rptCotizacionVehiculo(
                                        idVehiculo, 
                                        txtCliente.Text, 
                                        enganche,
                                        cuotas, 
                                        cuotaMensual, 
                                        txtSucursal.Text, 
                                        txtTelefono.Text,
                                        ct,
                                        total,
                                        precioNegociado);*/
                                }
                                else
                                    ClsHelper.MensajeSistema("Validez debe ser un numero...");
                            }
                            else
                                ClsHelper.MensajeSistema("Debe ingresar dias de validez...");
                        }
                        else
                            ClsHelper.MensajeSistema("Debe ingresar telefono de contacto...");
                    }
                    else
                        ClsHelper.MensajeSistema("Debe ingresar direccion de la sucursal...");
                }
                else
                    ClsHelper.MensajeSistema("Debe ingresar nombre de cliente...");
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }


        public void deshabilitarControles(bool st)
        {
            txtCliente.Enabled = st;
            txtSucursal.Enabled = st;
            txtTelefono.Enabled = st;
            txtVelidez.Enabled = st;
            btnGenerarCotizacion.Enabled = st;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }


    }
}
