using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WIA;

namespace PV
{
    public partial class FrmScanner : Form
    {
        public String ruta;
        public Boolean success = false;
        public FrmScanner()
        {
            InitializeComponent();
        }

        public Boolean cargarForm()
        {
            success = false;
            try
            {
                this.ShowDialog();
                return success;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            try
            {
                var dispositivo = lstDispositivos.SelectedItem as ClsScanner;
                if (dispositivo == null)
                {
                    ClsHelper.MensajeSistema("Por favor seleccione un dispositivo");
                    return;
                }
                var image = dispositivo.Scan();
                var path = ruta;
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                try
                {
                    image.SaveFile(path);
                    success = true;
                    BitmapImage bImage = new BitmapImage(new Uri(path, UriKind.Absolute));
                   // img.Source = BImage;
                    imgScanner.ImageLocation  = path;
                    
                }
                catch (Exception ef)
                {
                    success = false;
                    ClsHelper.erroLog(ef);
                }
            }
            catch (Exception ex)
            {
                success = false;
                ClsHelper.erroLog(ex);
            }
        }

        private void FrmScanner_Load(object sender, EventArgs e)
        {
            try
            {
                //Carga lista de dispositivos en listBox
                lstDispositivos.Items.Clear();
                var deviceManager = new DeviceManager();
                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        return;
                    }
                    lstDispositivos.Items.Add(new ClsScanner(deviceManager.DeviceInfos[i]));
                }
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }
    }
}
