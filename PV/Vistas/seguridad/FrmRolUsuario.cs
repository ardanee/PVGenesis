using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas
{
    public partial class FrmRolUsuario : Form
    {
        public string idUsuario, usuario;
        private BL.ClsSeguridad ClsSeguridad = new BL.ClsSeguridad();
        public FrmRolUsuario()
        {
            InitializeComponent();
        }

        private void FrmRolUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                lblTitulo.Text = "Roles para usuario " + usuario;
                grdRoles.DataSource = ClsSeguridad.cargarRolUsuario(idUsuario);
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                for (Int16 i = 0; i < grdRoles.Rows.Count; i++)
                {
                    string idRol = grdRoles.Rows[i].Cells["idRolCol"].Value.ToString();
                    string acceso = string.IsNullOrEmpty(grdRoles.Rows[i].Cells["accesoCol"].Value.ToString()) ? "0" : grdRoles.Rows[i].Cells["accesoCol"].Value.ToString();
                    ClsSeguridad.asignarDesasignarRol(idUsuario, idRol, acceso);
                }
                ClsHelper.MensajeSistema("Proceso realizado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }



    }
}
