using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PV.BL
{
    class ClsMetodoPago : ClsDb
    {
        public DataTable SeleccionarMetodoPago()
        {
            try
            {
                return consultarTabla("SpSMetodoPago", null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
