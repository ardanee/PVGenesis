using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsParametros: ClsDb
    {
        public void grabarModificarPCorreo(string dia)
        {
            try
            {
                ejecutarSP("SpIUCorreo", null, Parametro("@PdiaCorreo", dia));

                //ejecutarSP("SpIuTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable seleccionarValorCorreo()
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSParametroCorreo", null);
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
