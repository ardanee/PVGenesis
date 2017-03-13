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

        private PV.Vistas.parciales.PfrmVentaLista frmListaVentas;
        public PV.Vistas.parciales.PfrmVentaNueva frmNuevaVenta;
        private Form partial = null;

        public FrmVenta()
        {
            InitializeComponent();
        }

        public void FrmVenta_Load(object sender, EventArgs e)
        {
            this.cargarFormLista();
        }
        

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
        }
        
    }
}
