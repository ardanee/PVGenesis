using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsMarca : ClsDb
    {
        public void grabarModificar(string idMarca, string nombre)
        {
            try
            {
                ejecutarSP("SpIuMarca", null, Parametro("@PidMarca", idMarca), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));

                //ejecutarSP("SpIuTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
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
                res = consultarTabla("SpSMarca", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminar(string idMarca)
        {
            try
            {
                ejecutarSP("SpdMarca", null, Parametro("@PidMarca", idMarca));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
