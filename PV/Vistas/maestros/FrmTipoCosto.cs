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
    public partial class FrmTipoCosto : Form
    {
        private BL.ClsTipoCosto ClsTipoCosto = new BL.ClsTipoCosto();
        private string idTipoCosto = "";
        public FrmTipoCosto()
        {
            InitializeComponent();
        }

        private void frmTipoCosto_Load(object sender, EventArgs e)
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



        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = ClsTipoCosto.seleccionar(txtNombre.Text);
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
                this.idTipoCosto = "";
                this.txtNombre.Clear();
                this.buscar();

            }
            catch(Exception)
            {
                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsTipoCosto.grabarModificar(idTipoCosto, txtNombre.Text.Trim());
                limpiarControles();
                ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
            }
            catch (Exception ex)
            {
                idTipoCosto = "0";
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



        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        idTipoCosto = grdExistentes.SelectedRows[0].Cells["idTipoCostoCol"].Value.ToString();
                        txtNombre.Text = grdExistentes.SelectedRows[0].Cells["nombreCol"].Value.ToString();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            ClsTipoCosto.eliminar(grdExistentes.SelectedRows[0].Cells["idTipoCostoCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                idTipoCosto = "0";
                ClsHelper.erroLog(ex);
            }
        }

    }
}
