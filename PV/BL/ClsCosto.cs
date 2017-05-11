using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsCosto:ClsDb
    {

        public DataTable seleccionarCostosVehiculo(string idVehiculo)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpsCostoVehiculo", null, Parametro("@PidVehiculo", idVehiculo));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
