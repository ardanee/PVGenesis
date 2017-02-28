using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsTipoVehiculo : ClsDb
    {
        public void grabarModificar(string idTipoVehiculo, string nombre)
        {
            try
            {
                ejecutarSP("SpIuTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
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
                res = consultarTabla("SpStipoVehiculo",null,Parametro("@Pcriterio",criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminar(string idTipoVehiculo)
        {
            try
            {
                ejecutarSP("SpdTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
