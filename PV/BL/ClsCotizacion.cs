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
    }
}
