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
    public partial class FrmLogin : Form
    {
        private int count = 5;
        private Boolean success = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        public Boolean autenticar()
        {
            Boolean res = false;
            try
            {
                this.ShowDialog();
                if (ClsGlobals.idUSuario > 0 && !String.IsNullOrEmpty(ClsGlobals.usuario)) {
                    res = true;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DataTable tblInformacionLogin = new DataTable();
            try
            {
                BL.ClsSeguridad seg = new BL.ClsSeguridad();
                tblInformacionLogin = seg.login(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());
                if (tblInformacionLogin.Rows.Count > 0)
                {
                    ClsGlobals.idUSuario = Convert.ToInt32(tblInformacionLogin.Rows[0]["idUsuario"].ToString());
                    ClsGlobals.usuario = tblInformacionLogin.Rows[0]["usuario"].ToString();
                    success = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("[CC]"))
                {
                                        ClsHelper.MensajeSistema(ex.Message);
                    FrmCambiarContrasena frm = new FrmCambiarContrasena();
                    frm.usuario  = txtUsuario.Text;
                    frm.ShowDialog();
                }
                else
                {
                    count -= 1;
                    ClsHelper.MensajeSistema(ex.Message + " " + count.ToString() + " intentos restantes");
                    if (count == 0) { Application.Exit(); }
                }


            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!success)
                {
                    Application.Exit();
                }
               
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
