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
                cmbEstado.Items.Add("Activo");
                cmbEstado.Items.Add("Inactivo");
                cargar();
                buscar();
            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            
        }

        private void cargar()
        {
            try
            {
                if (checkBuscar.Checked)
                {
                    limpiarControles();
                    txtContrasena.Enabled = false;
                    txtCorreoDestino.Enabled = true;
                    txtCorreoOrigen.Enabled = false;
                    btnBuscar.Enabled = true;
                    txtCorreoDestino.Focus();
                    btnVerificar.Enabled = false;
                    btnGrabar.Enabled = false;
                    cmbEstado.Enabled = false;
                }
                else
                {
                    limpiarControles();
                    txtContrasena.Enabled = true;
                    txtCorreoDestino.Enabled = true;
                    txtCorreoOrigen.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnVerificar.Enabled = true;
                    btnGrabar.Enabled = true;
                    cmbEstado.Enabled = true;

                }
            }
            catch (Exception)
            {
                throw;
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
                grdExistentes.DataSource = clsMail.seleccionar(this.txtCorreoDestino.Text.Trim());
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
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
                cmbEstado.SelectedIndex = 0;
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

        private void checkBuscar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        //limpiarControles();
                        idCorreo = grdExistentes.SelectedRows[0].Cells["idCorreoCol"].Value.ToString();
                        txtContrasena.Text = grdExistentes.SelectedRows[0].Cells["contrasenaCol"].Value.ToString();
                        txtCorreoOrigen.Text = grdExistentes.SelectedRows[0].Cells["correoOrigenCol"].Value.ToString();
                        txtCorreoDestino.Text = grdExistentes.SelectedRows[0].Cells["correoDestinoCol"].Value.ToString();
                        //cmbMarca.SelectedValue = grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value;
                        //txtNombre.Enabled = true;
                        checkBuscar.Checked = false;
                        txtCorreoOrigen.Focus();
                        //txtCorreo .Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            clsMail.eliminar(grdExistentes.SelectedRows[0].Cells["idCorreoCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                idCorreo = "0";
                ClsHelper.erroLog(ex);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar())
                {
                    clsMail.grabarModificar(idCorreo, txtCorreoOrigen.Text.Trim(), txtCorreoDestino.Text.Trim(), txtContrasena.Text.Trim(), cmbEstado.SelectedIndex.ToString());
                    limpiarControles();
                    ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                }
            }
            catch (Exception ex)
            {
                idCorreo = "0";
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

        
    }
}
