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
    public partial class FrmUsuario : Form
    {
        private PV.BL.ClsSeguridad ClsSeguridad = new PV.BL.ClsSeguridad();
        string idUsuario;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string activo;
            string cambiarContrasena;
            try
            {
                if (!ClsHelper.camposObligatorios(txtNombre, txtUsuario, txtFechaNacimiento))
                {
                    return;
                }
                if (!ClsHelper.isDate(txtFechaNacimiento.Text))
                {
                    ClsHelper.MensajeSistema("Ingrese una fecha válida");
                    txtFechaNacimiento.Focus();
                    return;
                }
                activo = Convert.ToInt16(chkActivo.Checked).ToString();
                cambiarContrasena = Convert.ToInt16(chkReiniciarContrasena.Checked).ToString();
                if (idUsuario == null) { idUsuario = "0"; }
                ClsSeguridad.grabarModificarUsuario(idUsuario, txtNombre.Text, txtUsuario.Text, txtFechaNacimiento.Text, txtDescripcion.Text, activo, cambiarContrasena);
                ClsHelper.MensajeSistema("Proceso completado exitosamente");
                limpiarControles();
                buscarUsuario();
            }
            catch (Exception ex)
            {
                idUsuario = "0";
                ClsHelper.erroLog(ex);
            }
        }

        private void limpiarControles()
        {
            try
            {
                idUsuario = string.Empty;
                txtUsuario.Clear();
                txtNombre.Clear();
                txtFechaNacimiento.Clear();
                txtDescripcion.Clear();
                chkActivo.Checked = true;
                chkReiniciarContrasena.Checked = false;
                txtNombre.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCAncelar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarControles();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void buscarUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ClsSeguridad.buscarUsuario(txtBusqueda.Text);
                grdExistentes.DataSource = dt;
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

                //0 Editar, 1 Rol
                switch (e.ColumnIndex)
                {
                    case 0:
                        idUsuario = grdExistentes.SelectedRows[0].Cells["idUsuarioCol"].Value.ToString();
                        txtNombre.Text = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        txtUsuario.Text = grdExistentes.SelectedRows[0].Cells["UsuarioCol"].Value.ToString();
                        txtDescripcion.Text = grdExistentes.SelectedRows[0].Cells["observacionesCol"].Value.ToString();
                        txtFechaNacimiento.Text = grdExistentes.SelectedRows[0].Cells["fechaNacimientoCol"].Value.ToString();
                        chkActivo.Checked = grdExistentes.SelectedRows[0].Cells["activoCol"].Value.ToString() == "1" ? true : false;
                        chkReiniciarContrasena.Checked = grdExistentes.SelectedRows[0].Cells["cambiarContrasenaCol"].Value.ToString() == "1" ? true : false;
                        break;

                    case 1:
                        PV.Vistas.FrmRolUsuario frm = new PV.Vistas.FrmRolUsuario();
                        frm.idUsuario= grdExistentes.SelectedRows[0].Cells["idUsuarioCol"].Value.ToString();
                        frm.usuario = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        frm.ShowDialog();
                        break;
                }

            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }



    }



}
