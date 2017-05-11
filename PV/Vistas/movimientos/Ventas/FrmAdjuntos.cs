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

namespace PV
{
    public partial class FrmAdjuntos : Form
    {
        private List<string> adjuntos;
        public FrmAdjuntos( List<string> adjuntos)
        {
            InitializeComponent();
            this.adjuntos = adjuntos;
            picAdjunto1.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdjunto2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void FrmAdjuntos_Load(object sender, EventArgs e)
        {
            try
            {
                int cant = adjuntos.Count();
                if (cant > 0)
                {
                    //MessageBox.Show("cant: " + cant + "ruta: " + adjuntos[0]);
                    if (cant == 1)
                    {
                        picAdjunto1.Image = Image.FromFile(adjuntos[0].Replace(@"\",@"\\"));
                        picAdjunto1.Visible = true;
                    }
                    else
                    {
                        picAdjunto1.Image = Image.FromFile(adjuntos[0].Replace(@"\", @"\\"));
                        picAdjunto2.Image = Image.FromFile(adjuntos[1].Replace(@"\", @"\\"));
                        picAdjunto1.Visible = true;
                        picAdjunto2.Visible = true;

                    }
                    lblAdjuntos.Text = "(" + adjuntos.Count().ToString() + ")";
                }
                else
                {
                    lblAdjuntos.Text = "(" + adjuntos.Count().ToString() + ")";
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void picAdjunto1_Click(object sender, EventArgs e)
        {
            try
            {
                String rutaAdjunto = adjuntos[0];
                if (String.IsNullOrEmpty(rutaAdjunto))
                {
                    ClsHelper.MensajeSistema("No hay archivo adjunto para mostrar");
                    return;
                }
                if (!File.Exists(rutaAdjunto))
                {
                    ClsHelper.MensajeSistema("No existe el archivo o no tiene acceso a él");
                    return;
                }
                System.Diagnostics.Process.Start(rutaAdjunto);
            }
            catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void picAdjunto2_Click(object sender, EventArgs e)
        {
            try
            {
                String rutaAdjunto = adjuntos[1];
                if (String.IsNullOrEmpty(rutaAdjunto))
                {
                    ClsHelper.MensajeSistema("No hay archivo adjunto para mostrar");
                    return;
                }
                if (!File.Exists(rutaAdjunto))
                {
                    ClsHelper.MensajeSistema("No existe el archivo o no tiene acceso a él");
                    return;
                }
                System.Diagnostics.Process.Start(rutaAdjunto);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }
    }
}
