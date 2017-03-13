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

        public Vistas.parciales.PfrmVehiculoNuevo frmIngreso;
        private Vistas.parciales.PfrmVehiculoLista frmVehiculos;
        private Form partial = null;
        public FrmVehiculo()
        {
            InitializeComponent();
            
        }

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
        }
    }
}
