using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsCliente:ClsDb
    {
        public void grabarModificar(string dpiU ,string dpi, string nit, string nombre, string direccion,string telefonos,string correo)
        {
            try
            {
                ejecutarSP("SpIuCliente", null,Parametro("@PdpiU",dpiU), Parametro("@Pdpi", dpi), Parametro("@Pnit", nit), Parametro("@Pusuario", ClsGlobals.usuario), Parametro("@Pnombre", nombre),
                    Parametro("@Pdireccion",direccion),Parametro("@Ptelefonos",telefonos),Parametro("@Pcorreo",correo)
                    );

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

               res = consultarTabla("SpSCliente", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable seleccionarUnCliente(string nitCliente)
        {
            DataTable res = new DataTable();
            try
            {

                res = consultarTabla("SpSunCliente", null, Parametro("@Pnit", nitCliente));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminar(string dpi)
        {
            try
            {
                ejecutarSP("SpdCliente", null, Parametro("@Pdpi", dpi));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
