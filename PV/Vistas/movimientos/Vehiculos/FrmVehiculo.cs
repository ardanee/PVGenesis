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
    public partial class FrmVehiculo : Form
    {

       // public Vistas.parciales.PfrmVehiculoNuevo frmIngreso;
        //private Vistas.parciales.PfrmVehiculoLista frmVehiculos;
        //private Form partial = null;
        
        private BL.ClsVehiculo clsVehiculo = new BL.ClsVehiculo();
        private string idVehiculo = "0";
        public FrmVehiculo()
        {
            InitializeComponent();
            
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
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
                grdExistentes.DataSource = this.clsVehiculo.seleccionar(txtNombre.Text);
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
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

        private void limpiarControles()
        {
            try
            {
                this.txtNombre.Clear();
                this.idVehiculo = "0";
                this.buscar();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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


        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.idVehiculo = grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString();
                        FrmNuevoVehiculo frmNuevoVehiculo = new FrmNuevoVehiculo(this.idVehiculo);
                        frmNuevoVehiculo.ShowDialog(this);
                        buscar();
                        //this.padre.cargarFormIngreso(this.idVehiculo);
                        //txtNombre.Text = grdExistentes.SelectedRows[0].Cells["lineaCol"].Value.ToString();
                        //cmbMarca.SelectedValue = grdExistentes.SelectedRows[0].Cells["idMarcaCol"].Value;
                        //txtNombre.Enabled = true;
                        //txtNombre.Focus();
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            this.clsVehiculo.eliminar(grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.idVehiculo = "0";
                ClsHelper.erroLog(ex);
            }
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNuevoVehiculo frmNuevoVehiculo = new FrmNuevoVehiculo();
                frmNuevoVehiculo.ShowDialog(this);
                buscar();
            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }




        /*
private void frIngresarVehiculo_Load(object sender, EventArgs e)
{
this.cargarFormListaVehiculos();

}


public void cargarFormIngreso(string idVehiculo = "0")
{
this.frmIngreso = new PV.Vistas.parciales.PfrmVehiculoNuevo(this,idVehiculo);
this.cargarForm(this.frmIngreso);
//MessageBox.Show("clicl");
}

public void liberarFormIngreso()
{
if (this.frmIngreso != null)
{
this.frmIngreso.Dispose();
this.frmIngreso = null;
}
}

public void cargarFormListaVehiculos()
{

this.frmVehiculos = new PV.Vistas.parciales.PfrmVehiculoLista(this);
//this.frmIngreso.Dispose();
this.cargarForm(this.frmVehiculos);
}
public void liberarFormListaVehiculos()
{
if (this.frmVehiculos != null)
{
this.frmVehiculos.Dispose();
this.frmVehiculos = null;
}
}

//Carga formulario a el un panel
private void cargarForm(object frmpartial)
{
if (this.panContenedor.Controls.Count > 0)
{
this.panContenedor.Controls.RemoveAt(0);
}
partial = frmpartial as Form;
partial.TopLevel = false;
partial.FormBorderStyle = FormBorderStyle.None;
partial.Dock = DockStyle.Fill;
this.panContenedor.Controls.Add(partial);
this.panContenedor.Tag = partial;
partial.Show();
}*/
    }
}
