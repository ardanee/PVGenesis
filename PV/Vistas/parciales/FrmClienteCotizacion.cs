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
                            string ct = "Contado";
                            if (tipoCotizacion == "0")
                                ct = "Contado";
                            else if(tipoCotizacion == "1")
                                ct = "Financiamiento";
                            //ClsHelper.MensajeSistema("cuotas: " +cuotas);
                            BL.ClsReportes clsReporte = new BL.ClsReportes();
                            DataTable dt = clsReporte.rptCotizacionVehiculo(
                                idVehiculo, 
                                txtCliente.Text, 
                                enganche,
                                cuotas, 
                                cuotaMensual, 
                                txtSucursal.Text, 
                                txtTelefono.Text,
                                ct,
                                total,
                                precioNegociado);
                            FrmReporte rpt = new FrmReporte();

                            rpt.cargarReporte("RptCotizacion", dt);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
