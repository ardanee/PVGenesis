using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsTipoCosto:ClsDb
    {
        public void grabarModificar(string idTipoCosto, string nombre)
        {
            try
            {
                ejecutarSP("SpIuTipoCosto", null, Parametro("@PidTipoCosto", idTipoCosto), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
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
                res = consultarTabla("SpStipoTipoCosto", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminar(string idTipoCosto)
        {
            try
            {
                ejecutarSP("SpdTipoCosto", null, Parametro("@PidTipoCosto", idTipoCosto));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
