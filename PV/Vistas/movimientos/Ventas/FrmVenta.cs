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
    public partial class FrmVenta : Form
    {
        
    private BL.ClsVenta clsVenta = new BL.ClsVenta();
    //private PV.FrmVenta _p = new FrmVenta();
        //private PV.Vistas.parciales.PfrmVentaLista frmListaVentas;
        //public PV.Vistas.parciales.PfrmVentaNueva frmNuevaVenta;
        //private Form partial = null;

        public FrmVenta()
        {
            InitializeComponent();
        }

        public void FrmVenta_Load(object sender, EventArgs e)
        {
            //this.cargarFormLista();
            try
            {
                buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = this.clsVenta.seleccionar(this.txtCriterio.Text);
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
                buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            try
            {
               // this._p.cargarFormNuevaVenta();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void grdExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        string idVenta = grdExistentes.SelectedRows[0].Cells["idVentaCol"].Value.ToString();
                        PV.FrmNuevaVenta frmNuevaVenta = new FrmNuevaVenta(idVenta);
                        frmNuevaVenta.ShowDialog(this);
                        //this._p.cargarFormNuevaVenta(idVenta);
                        //this.idVehiculo = grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString();
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
                            //this.clsVehiculo.eliminar(grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString());
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            //limpiarControles();
                        }
                        break;
                    case 2:
                        string r1 = grdExistentes.SelectedRows[0].Cells["adjunto1Col"].Value.ToString();
                        string r2 = grdExistentes.SelectedRows[0].Cells["adjunto2Col"].Value.ToString();
                        List<String> adjuntos = new List<string>();
                        if (r1 != "")
                            adjuntos.Add(r1);
                        if (r2 != "")
                            adjuntos.Add(r2);

                        FrmAdjuntos frmAdjuntos = new FrmAdjuntos(adjuntos);
                        frmAdjuntos.ShowDialog(this);
                        //MessageBox.Show("adjunto");
                        break;
                }
            }
            catch (Exception ex)
            {
                //this.idVehiculo = "0";
                ClsHelper.erroLog(ex);
            }
        }

        private void btnNuevaVenta_Click_1(object sender, EventArgs e)
        {
            FrmNuevaVenta frmVenta = new FrmNuevaVenta();
            frmVenta.ShowDialog(this);

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }





















        /*
        //Carga formulario a el un panel
        private void cargarForm(object frmpartial)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            partial = frmpartial as Form;
            partial.TopLevel = false;
            partial.FormBorderStyle = FormBorderStyle.None;
            partial.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(partial);
            this.panelContenedor.Tag = partial;
            partial.Show();
        }

        public void cargarFormLista()
        {
            this.frmListaVentas = new PV.Vistas.parciales.PfrmVentaLista(this);
            this.cargarForm(this.frmListaVentas);
            //MessageBox.Show("clicl");
        }

        public void liberarFormLista()
        {
            if (this.frmListaVentas != null)
            {
                this.frmListaVentas.Dispose();
                this.frmListaVentas = null;
            }
        }

        public void cargarFormNuevaVenta(string idVenta = "0")
        {
            this.frmNuevaVenta = new Vistas.parciales.PfrmVentaNueva(this,idVenta);
            this.cargarForm(this.frmNuevaVenta);
        }

        public void liberarFormNuevaVenta()
        {
            if (this.frmNuevaVenta != null)
            {
                this.frmNuevaVenta.Dispose();
                this.frmNuevaVenta = null;
            }
        }*/

    }
}
