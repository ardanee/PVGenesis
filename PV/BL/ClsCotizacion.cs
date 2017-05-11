using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsCotizacion:ClsDb
    {

        

        public DataTable seleccionarAuto(string idVehiculo)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSvehiculoCtn", null, Parametro("@idVehiculo", idVehiculo));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable vehiculosCotizacion(string criterio)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsVehiculosCotizacion", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public DataTable agregar(string idvehiculo,
            string nombrecliente,string enganche,string cuotas,
            string cuotaMensual, string precioNegociado,
            string sucursal,string telefono,string formapago,
            string totalfinanciado,string validez)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpIuCotizacion", null, 
                    Parametro("@Pusuario", ClsGlobals.usuario),
                    Parametro("@PidVehiculo", idvehiculo),
                    Parametro("@Pcliente",nombrecliente),
                    Parametro("@Penganche",enganche),
                    Parametro("@Pcuotas", cuotas),
                    Parametro("@Pcuotamensual", cuotaMensual),
                    Parametro("@PprecioNegociado", precioNegociado),
                    Parametro("@Psucursal", sucursal),
                    Parametro("@Ptelefono", telefono),
                    Parametro("@PformaPago", formapago),
                    Parametro("@PtotalFinanciado", totalfinanciado),
                    Parametro("@Pvalidez",validez)
                    );
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public DataTable seleccionar(string criterio)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsCotizacion", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
