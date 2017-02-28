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
    public partial class FrmNuevoRol : Form
    {
        private BL.ClsSeguridad ClsSeguridad = new BL.ClsSeguridad();
        public FrmNuevoRol()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try {
                if (!ClsHelper.camposObligatorios(txtNombre)) { return; }
                if (ClsSeguridad.existeNombreRol(txtNombre.Text.Trim())) {
                    ClsHelper.MensajeSistema("Ya existe un rol con este nombre, por favor ingrese uno diferente");
                    return;
                }
                ClsSeguridad.insertarRol(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                if (MessageBox.Show("Regristro grabado existosamente"+Environment.NewLine+"¿Desea ingresar uno nuevo?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtNombre.Focus();
                }
                else { this.Close(); }
            }
            catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


    }//EOC
}//ENS
