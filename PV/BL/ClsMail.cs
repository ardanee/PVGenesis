using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsMail : ClsDb
    {
        public void grabarModificar(string idCorreo, string correoOrigen, string correoDestino, string contrasena, string estado)
        {
            try
            {
                ejecutarSP("SpUICorreo", null, Parametro("@PidCorreo", idCorreo), Parametro("@PcorreoOrigen", correoOrigen), 
                    Parametro("@Pusuario", ClsGlobals.usuario), Parametro("@PcorreoDestino", correoDestino), Parametro("@Pcontrasena",contrasena),
                    Parametro("@Pestado",estado));

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
                res = consultarTabla("SpsCorreo", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public void eliminar(string idCorreo)
        {
            try
            {
                ejecutarSP("SpdCorreo", null, Parametro("@PidCorreo", idCorreo));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
