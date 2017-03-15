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
    public partial class FrmCotizacion : Form
    {
        //private Vistas.parciales.PfrmCotizacionBusqueda parcialBusqueda;
        //private Vistas.parciales.PfrmCotizacionResultado parcialResultado;

        private BL.ClsCotizacion clsCotizacion = new BL.ClsCotizacion();
        private String idVehiculoo;

        public FrmCotizacion()
        {
            InitializeComponent();
            /*try
            {
                this.parcialBusqueda = new PV.Vistas.parciales.PfrmCotizacionBusqueda(this);
                cargarParcialBusqueda();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }*/

                      
        }

        /*
        public void cargarParcialBusqueda(){
            try
            {
                cargarForm(parcialBusqueda);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void cargarParcialCotizacion(String idVehiculo)
        {
            try
            {
                this.parcialResultado = new Vistas.parciales.PfrmCotizacionResultado(idVehiculo, this);
                this.cargarForm(this.parcialResultado);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        //Carga formulario a el un panel
        private void cargarForm(object frmpartial){
            try
            {
                if (this.panelContenedor.Controls.Count > 0)
                {
                    this.panelContenedor.Controls.RemoveAt(0);
                }
                Form partial = frmpartial as Form;
                partial.TopLevel = false;
                partial.FormBorderStyle = FormBorderStyle.None;
                partial.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(partial);
                this.panelContenedor.Tag = partial;
                partial.Show();
            }
            catch (Exception)
            {
                throw;
            }


        }
        */



        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = clsCotizacion.seleccionar(txtBusqueda.Text);
                lblExistentes.Text = grdExistentes.Rows.Count.ToString() + " Registro(s)";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void limpiarControles()
        {
            this.txtBusqueda.Clear();
            this.idVehiculoo = "0";
            this.buscar();
            this.txtBusqueda.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
                        this.idVehiculoo = grdExistentes.SelectedRows[0].Cells["idVehiculoCol"].Value.ToString();
                        this.txtBusqueda.Focus();
                        MessageBox.Show("vehiculo: " + idVehiculoo);
                        //this.padre.cargarParcialCotizacion(this.idVehiculoo);
                        break;
                }
            }
            catch (Exception ex)
            {
                idVehiculoo = "0";
                ClsHelper.erroLog(ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void FrmCotizacion_Load(object sender, EventArgs e)
        {
            try
            {
                this.buscar();

            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCotizacionBusqueda frmCotizacionBusqueda = new FrmCotizacionBusqueda();
            frmCotizacionBusqueda.ShowDialog(this);
        }
    }
}
