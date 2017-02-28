using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PV.BL
{
    class ClsReportes:ClsDb
    {
        public DataTable rptRecibos() {
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

    }
}
