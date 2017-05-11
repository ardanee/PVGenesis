using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace PV 
{
    public class ClsScanner
    {
        
        private readonly DeviceInfo _deviceInfo;

        private Device device;
        private WIA.CommonDialog dialogo;

        public ClsScanner(DeviceInfo deviceInfo)
        {
            this._deviceInfo = deviceInfo;
        }

        public ImageFile Scan()
        {
            try
            {
                var device = this._deviceInfo.Connect();
                var item = device.Items[1];
                var imageFile = (ImageFile)item.Transfer("{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}");
                return imageFile;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public ClsScanner()
        {
            dialogo = new WIA.CommonDialog();
            dialogo = new WIA.CommonDialog();
        }

        public string scanv2()
        {
            string rutaImagen = "";
            string nombreAdjunto = "";
            System.Drawing.Image i = null;
            try
            {
                device = dialogo.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true, false);
                ImageFile imageFile = dialogo.ShowAcquireImage(device.Type,
                         WiaImageIntent.GrayscaleIntent,
                         WiaImageBias.MinimizeSize,
                         "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}", false, false, false);
                WIA.Vector vector = imageFile.FileData;

                DateTime fecha = DateTime.Now;
                nombreAdjunto = "scan_" + fecha.Day.ToString()
                    + fecha.Month.ToString()
                    + fecha.Year.ToString()
                    + "_" + fecha.Hour.ToString()
                    + fecha.Minute.ToString()
                    + fecha.Second.ToString()
                    + fecha.Millisecond.ToString() 
                    + ".jpeg";
                rutaImagen = ClsGlobals.rutaAdjuntos + nombreAdjunto;
                    

                if (System.IO.File.Exists(rutaImagen))
                {
                    System.IO.File.Delete(rutaImagen);
                }
                try
                {

                    // Se crea el directorio si no existe para almacenar los adjunntos
                    if (Directory.Exists(ClsGlobals.rutaAdjuntos))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(ClsGlobals.rutaAdjuntos);
                    }
                    imageFile.SaveFile(rutaImagen);
                }
                catch (Exception ex)
                {
                    ClsHelper.erroLog(ex);
                }
                i = System.Drawing.Image.FromStream(new
                         System.IO.MemoryStream((byte[])vector.get_BinaryData()));
            }
            catch (COMException ex)
            {
                if (ex.ErrorCode == -2145320939)
                {
                    ClsHelper.MensajeSistema("No se encontro dispositivo conectado...");
                }
                else
                {
                    ClsHelper.erroLog(ex);
                }
            }
            catch (Exception)
            {
                ClsHelper.MensajeSistema("No se completo la operación...");
            }
            return nombreAdjunto;
        }
        public override string ToString()
        {
            return this._deviceInfo.Properties["Name"].get_Value().ToString();
        }
    }
}

