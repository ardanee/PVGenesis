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
    public partial class FrmCorreo : Form
    {

        private string idCorreo = "0";
        private PV.BL.ClsMail clsMail = new BL.ClsMail();
        public FrmCorreo()
        {
            InitializeComponent();
        }

        private void FrmCorreo_Load(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void buscar()
        {
            try
            {
                DataTable dt= clsMail.seleccionar("");
                if (dt.Rows.Count > 0)
                {
                    idCorreo = dt.Rows[0]["idCorreo"].ToString();
                    txtCorreoOrigen.Text = dt.Rows[0]["correoOrigen"].ToString();
                    txtCorreoDestino.Text = dt.Rows[0]["correoDestino"].ToString();
                    txtContrasena.Text = dt.Rows[0]["contrasena"].ToString();
                    txtCorreoOrigen.Focus();
                }
                //lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void limpiarControles()
        {
            try
            {
                
                txtContrasena.Clear();
                txtCorreoDestino.Clear();
                txtCorreoOrigen.Clear();
                buscar();
                txtCorreoOrigen.Focus();
                //checkBuscar.Checked = false;
            }
            catch (Exception)
            {
                throw;
            }

        }

                

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar())
                {
                    clsMail.grabarModificar(idCorreo, txtCorreoOrigen.Text.Trim(), txtCorreoDestino.Text.Trim(), txtContrasena.Text.Trim());
                    //limpiarControles();
                    ClsHelper.MensajeSistema("Proceso ejecutado exitosamente...");
                    btnGrabar.Enabled = false;
                    btnVerificar.Enabled = false;
                    buscar();
                }
            }
            catch (Exception ex)
            {
                //idCorreo = "0";
                ClsHelper.erroLog(ex);
            }
        }

        private Boolean verificar()
        {
            try{
                if (txtCorreoOrigen.Text.Trim() == "")
                {
                    ClsHelper.MensajeSistema("Ingresar un correo de Origen...");
                    txtCorreoOrigen.Focus();
                    return false;
                }
                else if (txtContrasena.Text.Trim() == "")
                {
                    ClsHelper.MensajeSistema("Ingresar una contraseña...");
                    txtContrasena.Focus();
                    return false;
                }
                else if (txtCorreoDestino.Text.Trim() == "")
                {
                    ClsHelper.MensajeSistema("Ingresar Correo de destino...");
                        txtCorreoDestino.Focus();
                        return false;
                }
            }catch(Exception){

                throw;
            }
                return true;
        }

       

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar())
                {
                    ClsCorreo correo = new ClsCorreo(txtCorreoDestino.Text.Trim(), "Importadora", "Genesis", txtCorreoOrigen.Text.Trim());
                    correo.autenticar(txtCorreoOrigen.Text.Trim(), txtContrasena.Text.Trim());

                    if (correo.correoPrueba())
                    {

                        MessageBox.Show("Correo Verificado correctamente...");
                        btnGrabar.Enabled = true;
                        btnVerificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Correo no verificado, verificar valores o verificar conexion a la red...");
                        txtCorreoOrigen.Focus();
                        btnGrabar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            
        }

        private void txtCorreoOrigen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnGrabar.Enabled = false;
                btnVerificar.Enabled = true;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        
    }
}
