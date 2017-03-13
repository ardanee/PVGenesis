using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsReportes:ClsDb
    {
        public DataTable rptRecibos()
        {
            try
            {
                return consultarTabla("SPSReporteRecibo", null, Parametro("@Pusuario", ClsGlobals.usuario));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet rptEstadoCuenta(String idVenta)
        {
            try
            {
                return consultarDataSetSP("SpEstadoCuenta", null, Parametro("@PidVenta", idVenta));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable clientesMorosos()
        {
            try
            {
                return consultarTabla("SPClientesMorosos", null);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable ventasPorFecha(string fechaInicio, string fechaFin)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsReporteVenta", null, Parametro("@PfechaIncio", fechaInicio), Parametro("@PfechaFin", fechaFin));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataTable rptVenta(string idVenta)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsUnaVenta", null, Parametro("@PidVenta", idVenta));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable rptCotizacionVehiculo(
            string idVehiculo = "",
            string cliente = "",
            string enganche = "",
            string cuotas = "",
            string cuotaMensual = "",
            string sucursal = "",
            string telefono = "",
            string formaPago = "",
            string total = "",
            string precioNegociado = "")
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsCotizacionVehiculo", null,
                    Parametro("@PidVehiculo", idVehiculo),
                     Parametro("@Pcliente", cliente),
                     Parametro("@Penganche", enganche),
                     Parametro("@Pcuotas", cuotas),
                     Parametro("@Pcuotamensual", cuotaMensual),
                     Parametro("@PprecioNegociado", precioNegociado),
                     Parametro("@Psucursal", sucursal),
                     Parametro("@Ptelefono", telefono),
                     Parametro("@PformaPago", formaPago),
                     Parametro("@PtotalFinanciado", total),
                     Parametro("@Pusuario", ClsGlobals.usuario));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable RptDiarioVehiculos()
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSVehiculoReporte", null);
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
