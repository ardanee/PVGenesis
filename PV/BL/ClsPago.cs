using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PV.BL
{
    class ClsPago : ClsDb
    {
        public DataTable buscarVentaEncabezado(String criterio)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpBuscarVentaEncabezado", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable seleccionarPagos(String idVenta)
        {
            try
            {
                return consultarTabla("SpSPago", null, Parametro("@PidVenta", idVenta));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet obtenerInformacionPago(String idVenta)
        {
            try
            {
                return consultarDataSetSP("SpSInformacionPago", null, Parametro("@PidVenta", idVenta));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void grabarPago(String idVenta, String monto, String idMetodoPago, String observaciones, String rutaAdjunto)
        {
            try
            {
                ejecutarSP("SpGrabarPago", null
                    , Parametro("@PidVenta", idVenta)
                     , Parametro("@Pmonto", monto)
                      , Parametro("@PidMetodoPago", idMetodoPago)
                       , Parametro("@Pobservaciones", observaciones)
                        , Parametro("@PrutaAdjunto", rutaAdjunto)
                         , Parametro("@Pusuario", ClsGlobals.usuario)
                        );
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void anularPago(String idPago)
        {
            try
            {
                ejecutarSP("SpAnularPago", null, Parametro("@PidPago", idPago), Parametro("@Pusuario", ClsGlobals.usuario));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
