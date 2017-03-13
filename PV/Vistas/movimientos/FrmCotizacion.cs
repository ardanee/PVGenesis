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
        private Vistas.parciales.PfrmCotizacionBusqueda parcialBusqueda;
        private Vistas.parciales.PfrmCotizacionResultado parcialResultado;

        public FrmCotizacion()
        {
            InitializeComponent();
            try
            {
                this.parcialBusqueda = new PV.Vistas.parciales.PfrmCotizacionBusqueda(this);
                cargarParcialBusqueda();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

                      
        }


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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            try
            {
                this.cargarParcialBusqueda();
                this.parcialResultado.Dispose();
                this.parcialResultado = null;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }
    }
}
