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
        public DataTable ventasPorFecha(string fechaInicio, string fechaFin, string forma)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsReporteVentaPorFecha", null, Parametro("@PfechaIncio", fechaInicio), Parametro("@PfechaFin", fechaFin), Parametro("@PformaVenta",forma));
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

        public DataTable reporteCotizacion(string numeroCotizacion)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpRptCotizacion", null, Parametro("@PnumeroCotizacion", numeroCotizacion));
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
