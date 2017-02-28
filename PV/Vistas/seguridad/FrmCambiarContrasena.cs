using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
  
    public partial class FrmCambiarContrasena : Form
    {
        public String usuario = String.Empty;
        public FrmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClsHelper.camposObligatorios(txtUsuario, txtContrasenaActual, txtContraseñaNueva, txtConfirmacionNueva))
                {
                    return;
                }

                if(txtContraseñaNueva.Text != txtConfirmacionNueva.Text)
                {
                    ClsHelper.MensajeSistema("Las contraseñas no coinciden, verifique por favor.");
                    return;
                }

                BL.ClsSeguridad ClsSeguridad = new BL.ClsSeguridad();
                ClsSeguridad.cambiarContrasena(txtUsuario.Text.Trim(), txtContrasenaActual.Text.Trim(), txtContraseñaNueva.Text.Trim());
                this.Close();
            }
            catch (Exception ex)
            {

                ClsHelper.MensajeSistema(ex.Message);
            }
        }

        private void FrmCambiarContrasena_Load(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.Text = this.usuario;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }
    }
}
