using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsVenta:ClsDb
    {
       public DataTable grabarModificar(
           string idVenta, 
           string idvehiculo, string valorVenta, 
           string enganche, 
           string cantidadCuotas, string cuota,
           string diaPago,
           string r1Nombre,string r1Telefono,string r1Direccion,
           string r2Nombre, string r2Telefono, string r2Direccion,
           string r3Nombre, string r3Telefono, string r3Direccion,
           string rutaDocumento1, string rutaDocumento2,
           string clNombre,string clNit,string clDPI, string clDireccion,
           string clTelefono, string clCorreo, string clDPIUp,string fecha
           )
        {
            DataTable res = new DataTable();

            try
            {
                res =  consultarTabla("SpIuVenta", null, 
                    Parametro("@PidVenta", idVenta), 
                    Parametro("@PidVehiculo", idvehiculo), 
                    Parametro("@PvalorVenta", valorVenta), 
                    Parametro("@Penganche", enganche), 
                    Parametro("@PcantidadCuotas", cantidadCuotas), 
                    Parametro("@PCuota", cuota), 
                    Parametro("@PdiaPago", diaPago),
                    Parametro("@Pr1Nombre", r1Nombre), Parametro("@Pr1Telefono", r1Telefono), Parametro("@Pr1Direccion", r1Direccion),
                    Parametro("@Pr2Nombre", r2Nombre), Parametro("@Pr2Telefono", r2Telefono), Parametro("@Pr2Direccion", r2Direccion),
                    Parametro("@Pr3Nombre", r3Nombre), Parametro("@Pr3Telefono", r3Telefono), Parametro("@Pr3Direccion", r3Direccion),
                    Parametro("@PrutaDocumento1", rutaDocumento1),
                    Parametro("@PrutaDocumento2", rutaDocumento2),
                    Parametro("@Pusuario", ClsGlobals.usuario), 
                    Parametro("@PclNombre", clNombre),
                    Parametro("@PclNit", clNit), 
                    Parametro("@PclDpi", clDPI), 
                    Parametro("@PclDireccion", clDireccion), 
                    Parametro("@PclTelefono", clTelefono), 
                    Parametro("@PclCorreo", clCorreo),
                    Parametro("@PcldpiU", clDPIUp),
                    Parametro("@Pfecha",fecha)
                    );

                //ejecutarSP("SpIuTipoVehiculo", null, Parametro("@PidTipoVehiculo", idTipoVehiculo), Parametro("@Pnombre", nombre), Parametro("@Pusuario", ClsGlobals.usuario));
            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }


        public DataTable seleccionar(string criterio)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSVenta", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataTable seleccionarVentaEdicion(string idVenta)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpSUnaVentaEdicion", null, Parametro("@PidVenta", idVenta));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
