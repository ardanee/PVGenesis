using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsLinea:ClsDb
    {
        public void grabarModificar(string idLinea, string nombre, string idMarca)
        {
            try
            {
                ejecutarSP("SpIuLinea", null, Parametro("@PidLinea", idLinea), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario),Parametro("@pidMarca",idMarca));

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
                res = consultarTabla("SpsLinea", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable seleccionarLineaMarca(string idMarca)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsLineaMarca", null, Parametro("@idMarca", idMarca));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminar(string idLinea)
        {
            try
            {
                ejecutarSP("SpdLinea", null, Parametro("@PidLinea", idLinea));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
