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
    public partial class FrmCotizacionBusqueda : Form
    {
        private BL.ClsCotizacion clsCotizacion = new BL.ClsCotizacion();
        private String idVehiculoo;

        public FrmCotizacionBusqueda()
        {
            InitializeComponent();
            this.idVehiculoo = "0";
        }
        
        private void frmCotizacionBusqueda_Load(object sender, EventArgs e)
        {
            try
            {
                this.buscar();
            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

       

        private void buscar()
        {
            try
            {
                grdExistentes.DataSource = clsCotizacion.vehiculosCotizacion(txtBusqueda.Text);
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
            }catch(Exception ex)
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
                        FrmCotizacionDetalle frmDetalle = new FrmCotizacionDetalle(this.idVehiculoo);
                        frmDetalle.ShowDialog(this);
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
       
 
        
    }
}
