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
    public partial class FrmClientes : Form
    {

        //private 
        private BL.ClsCliente clsCliente = new BL.ClsCliente();
        private string dpiCliente = "0";
        public FrmClientes()
        {
            InitializeComponent();
        }


        private void FrmCliente_Load(object obj, EventArgs e)
        {
            try
            {
                this.buscar();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        public void limpiarControles()
        {
            try
            {
                this.txtNit.Clear();
                this.txtDireccion.Clear();
                this.txtDpi.Clear();
                this.txtTelefonos.Clear();
                this.txtDireccion.Clear();
                this.txtCorreoElectronico.Clear();
                this.txtNombre.Clear();
                this.dpiCliente = "0";
                this.buscar();
                this.txtNit.Focus();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCAncelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiarControles();
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
                string strQuery = "";
                if (this.txtDpi.Text.Trim() != "")
                    strQuery = this.txtDpi.Text.Trim();
                else if (this.txtNit.Text.Trim() != "")
                    strQuery = this.txtNit.Text.Trim();
                else if (this.txtNombre.Text.Trim() != "")
                    strQuery = this.txtNombre.Text.Trim();
                //MessageBox.Show("queri: " + strQuery);
                grdExistentes.DataSource = this.clsCliente.seleccionar("");
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
                //this.limpiarControles();
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
                if (this.validarControlesCosto())
                {
                    this.clsCliente.grabarModificar(this.dpiCliente, this.txtDpi.Text.Trim(), this.txtNit.Text.Trim(), txtNombre.Text.Trim(),
                                                    this.txtDireccion.Text.Trim(), this.txtTelefonos.Text.Trim(), this.txtCorreoElectronico.Text.Trim());
                    limpiarControles();
                    ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                }
            }
            catch (Exception ex)
            {
                dpiCliente = "0";
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
                        this.txtDpi.Text = grdExistentes.SelectedRows[0].Cells["dpiCol"].Value.ToString().Trim();
                        this.txtNombre.Text = grdExistentes.SelectedRows[0].Cells["nombresCol"].Value.ToString();
                        this.txtNit.Text = grdExistentes.SelectedRows[0].Cells["nitCol"].Value.ToString();
                        this.txtDireccion.Text = grdExistentes.SelectedRows[0].Cells["direccionCol"].Value.ToString();
                        this.txtCorreoElectronico.Text = grdExistentes.SelectedRows[0].Cells["correoElectronicoCol"].Value.ToString();
                        this.txtTelefonos.Text = grdExistentes.SelectedRows[0].Cells["telefonosCol"].Value.ToString();
                        this.dpiCliente = grdExistentes.SelectedRows[0].Cells["dpiCol"].Value.ToString();
                        this.txtNit.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsCliente.eliminar(grdExistentes.SelectedRows[0].Cells["dpiCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.dpiCliente = "0";
                ClsHelper.erroLog(ex);
            }
        }


        private bool validarControlesCosto()
        {
            try
            {
                if (this.txtNit.Text == "")
                {
                    MessageBox.Show("Ingresar numero de NIT");
                    return false;
                }
                else if (this.txtNombre.Text == "")
                {
                    MessageBox.Show("Ingresar nombre de Cliente");
                    return false;
                }

                else if (this.txtDpi.Text == "")
                {
                    MessageBox.Show("Ingresar DPI Cliente");
                    return false;
                }

                else
                    return true;
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
                this.buscar();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }
    }
}
