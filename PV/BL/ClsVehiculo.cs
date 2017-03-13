using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsVehiculo: ClsDb
    {
        public void grabarModificar(string idVehiculo="", string idTipoVehiculo="",
            string idMarca="",string idLinea="",string modelo="", string placa="",
            string chasis ="",string color="", string asientos = "", string puertas="",
            string transmision = "", string motor="", string cc="", string cilindros ="",
            string vin="",string ton="", string observaciones="",string ac="",string propietario="",
            string nitPropietario ="",string direccionPropietario="", string poliza ="", string fechaIngreso ="",
            string precioVenta="",string origen="", DataTable tvpTable = null,string combustible ="")
        {
            try
            {
                ejecutarSPTPV("SpIuVehiculo", null,tvpTable,"@Ptcostos",
                    Parametro("@Pcombustible", combustible),
                    Parametro("@PidVehiculo", idVehiculo),
                    Parametro("@PidTipoVehiculo",idTipoVehiculo),
                    Parametro("@PidMarca",idMarca),
                    Parametro("@PidLinea",idLinea),
                    Parametro("@Pmodelo",modelo),
                    Parametro("@Pplaca",placa),
                    Parametro("@Pchasis",chasis),
                    Parametro("@Pcolor",color),
                    Parametro("@Pasientos",asientos),
                    Parametro("@Ppuertas",puertas),
                    Parametro("@Ptransmision",transmision),
                    Parametro("@Pmotor",motor),
                    Parametro("@Pcc",cc),
                    Parametro("@Pcilindros",cilindros),
                    Parametro("@Pvin",vin),
                    Parametro("@Pton",ton),
                    Parametro("@Pobservaciones",observaciones),
                    Parametro("@pac",ac),
                    Parametro("@Ppropietario",propietario),
                    Parametro("@PnitPropietario",nitPropietario),
                    Parametro("@PdireccionPropietario",direccionPropietario),
                    Parametro("@Ppoliza",poliza),
                    Parametro("@PfechaIngreso",fechaIngreso),
                    Parametro("@PprecioVenta",precioVenta),
                    Parametro("@Porigen",origen),
                    Parametro("@Pusuario",ClsGlobals.usuario)
                    );
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
                res = consultarTabla("SpSVehiculo", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        

        public DataTable seleccionarUnVehiculo(string idVehiculo, string placa = "")
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSUnVehiculo", null, Parametro("@PidVehiculo", idVehiculo),Parametro("@Pplaca",placa));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Procedimiento para cargar vehiculos que podra seleccionar para venta
        public DataTable seleccionarVehiculosVenta(string criterio)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSVehiculosVenta", null, Parametro("@PCriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataTable seleccionarVehiculoInfo(string placa)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSVehiculoInfo", null, Parametro("@Pplaca", placa));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public void eliminar(string idVehiculo)
        {
            try
            {
                ejecutarSP("SpdVehiculo", null, Parametro("@PidVehiculo", idVehiculo));
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
