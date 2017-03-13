using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas.parciales
{
    public partial class PfrmCotizacionResultado : Form
    {
        private String idVehiculo;
        private FrmCotizacion padre;
        private BL.ClsCotizacion Clscotizacion = new BL.ClsCotizacion();
        private double totalpagar;

        public PfrmCotizacionResultado(String idVehiculo, FrmCotizacion padre)
        {
            InitializeComponent();
            this.idVehiculo = idVehiculo;
            this.padre = padre;
            //this.Dispose();
            this.totalpagar = 0.00;
        }

        private void limpiarControles()
        {

            txtPrecioNegociado.Text = lblPrecio.Text;
            txtPrecioNegociado.Focus();

        }

        private void habilitarFinanciamiento(bool estado)
        {
            try
            {
                txtEnganche.Enabled = estado;
                txtCuotas.Enabled = estado;
                btnCalcular.Enabled = estado;
                btnReestablecer.Enabled = estado;

                panelEnganche.Visible = estado;
                panelCuota.Visible = estado;
                panelTotal.Visible = estado;
                panelNoCuotas.Visible = estado;
                btnCalcular.Visible = estado;
                btnReestablecer.Visible = estado;

                if (estado)
                    txtCuotas.Text = "12";
                else
                    txtCuotas.Text = "0";
                txtEnganche.Text = "0.00";
                txtCuotaMensual.Text = "0.00";
                txtTotal.Text = "0.00";
                totalpagar = 0.00;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void PfrmCotizacionResultado_Load(object sender, EventArgs e)
        {
            try
            {
                habilitarFinanciamiento(false);
                cmbForma.Items.Add("Contado");
                cmbForma.Items.Add("Financiamiento");
                cmbForma.SelectedIndex = 0;

                DataTable tb = this.Clscotizacion.seleccionarAuto(this.idVehiculo);
                if (tb.Rows.Count == 1)
                {
                    DataRow dt = tb.Rows[0];
                    this.lblPlaca.Text = dt["placa"].ToString();
                    this.lblTipoAuto.Text = dt["tipoVehiculo"].ToString();
                    this.lblLinea.Text = dt["linea"].ToString();
                    this.lblMarca.Text = dt["marca"].ToString();
                    this.lblModelo.Text = dt["modelo"].ToString();
                    if (dt["transmision"].ToString() == "0")
                        this.lblTransmision.Text = "Automatico";
                    else
                        this.lblTransmision.Text = "Manual";
                    this.lblCc.Text = dt["cc"].ToString();
                    this.lblCilindros.Text = dt["cilindros"].ToString();
                    this.lblTon.Text = dt["ton"].ToString();
                    this.lblColor.Text = dt["color"].ToString();
                    this.lblPuertas.Text = dt["puertas"].ToString();
                    this.lblAsientos.Text = dt["asientos"].ToString();

                    if (dt["ac"].ToString() == "0")
                        this.lblAC.Text = "SI";
                    else
                        this.lblAC.Text = "NO";
                    this.lblPrecio.Text = dt["precioVenta"].ToString();
                    if (dt["origen"].ToString() == "")
                        lblOrigen.Text = "";
                    else if (dt["origen"].ToString() == "0")
                        lblOrigen.Text = "Importado";
                    else if (dt["origen"].ToString() == "1")
                        lblOrigen.Text = "Agencia";
                    if (dt["combustible"].ToString() == "0")
                        lblCombustible.Text = "Gasolina";
                    else
                        lblCombustible.Text = "Diesel";

                }
                else
                {

                }
                limpiarControles();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        private void calcular()
        {
            try
            {
                if (comprobarControlesFinanciamiento())
                {
                    double cuotaM = Math.Round((double.Parse(txtPrecioNegociado.Text.Trim()) - double.Parse(txtEnganche.Text.Trim())) / double.Parse(txtCuotas.Text.Trim()), 2);
                    //txtCuotaMensual.Text = Math.Round(((precioVenta - enganche) / cantidadCuotas), 2).ToString();
                    txtCuotaMensual.Text = cuotaM.ToString();
                    totalpagar = Math.Round(cuotaM * double.Parse(txtCuotas.Text.Trim()),2);
                    txtTotal.Text = totalpagar.ToString().Trim();
                }
                            

                //MessageBox.Show("PVenta: " + precioVenta.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }




        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro Desea Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.padre.cargarParcialBusqueda();
                //this.Dispose();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarControles();
                habilitarFinanciamiento(false);
                cmbForma.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

            try
            {
                if (comprobarControlesFinanciamiento())
                {
                    //MessageBox.Show(": " + cmbForma.SelectedIndex.ToString());
                    double t = 0.00;
                    if (cmbForma.SelectedIndex == 1)
                        t = (Math.Round((Double.Parse(txtPrecioNegociado.Text.Trim()) - double.Parse(txtEnganche.Text.Trim())) / Double.Parse(txtCuotas.Text.Trim()), 2)) * int.Parse(txtCuotas.Text.Trim());

                    double cmp = Math.Round(t - totalpagar, 2);

                    if (cmp == 0)
                    {

                        FrmVenta frmVenta = new FrmVenta();

                        frmVenta.Show();
                        frmVenta.cargarFormNuevaVenta();
                        frmVenta.frmNuevaVenta.setVehiculo(idVehiculo, lblTipoAuto.Text + "," + lblMarca.Text + ", " + lblLinea.Text +

                            lblModelo.Text + ", cc: " + lblCilindros.Text + ", cc:" + lblCc.Text, lblPlaca.Text, lblPrecio.Text);
                        frmVenta.frmNuevaVenta.agregarFinanciamiento(cmbForma.SelectedIndex.ToString(), txtEnganche.Text.Trim(), txtCuotas.Text.Trim());
                        frmVenta.frmNuevaVenta.ventaDesdeCotizacion();
                    }
                    else
                        ClsHelper.MensajeSistema("Valores inconcistentes, recalcular...");
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }



        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (comprobarControlesFinanciamiento())
            {
                //MessageBox.Show(": " + cmbForma.SelectedIndex.ToString());
                double t = 0.00;
                if (cmbForma.SelectedIndex == 1)
                    t = (Math.Round((Double.Parse(txtPrecioNegociado.Text.Trim()) - double.Parse(txtEnganche.Text.Trim())) / Double.Parse(txtCuotas.Text.Trim()), 2)) * int.Parse(txtCuotas.Text.Trim());

                double cmp = Math.Round(t - totalpagar,2);

                if (cmp == 0)
                {
                    FrmClienteCotizacion frmCliente = new FrmClienteCotizacion(
                        txtTotal.Text.ToString(),
                        idVehiculo,
                        txtCuotas.Text.Trim(),
                        txtEnganche.Text.Trim(),
                        txtCuotaMensual.Text.Trim(),
                        txtPrecioNegociado.Text.Trim(),
                        cmbForma.SelectedIndex.ToString());
                    frmCliente.ShowDialog(this);
                }
                else
                    ClsHelper.MensajeSistema("Valores inconcistentes, recalcular...");
            }
            
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                if (cmbForma.SelectedIndex == 0)
                {

                    habilitarFinanciamiento(false);
                    txtPrecioNegociado.Focus();
                }
                else if (cmbForma.SelectedIndex == 1)
                {

                    habilitarFinanciamiento(true);
                    txtCuotaMensual.Focus();
                }
            }catch(Exception ex){
                    ClsHelper.erroLog(ex);
            }
        }


        private bool comprobarControlesFinanciamiento()
        {
            double enganche = 0.00;
            int cuotas = 0;
            double precioNegociado = 0.00;
            if (txtEnganche.Text == "" || !double.TryParse(txtEnganche.Text,out enganche)){
                ClsHelper.MensajeSistema("Valor enganche es invalido, ingrese y recalcule...");
                return false;
            }
            if(txtCuotas.Text =="" || !int.TryParse(txtCuotas.Text,out cuotas)){
                ClsHelper.MensajeSistema("Valor de cuota es invalido, ingrese y recalcule...");
                return false;
            }
            if (txtPrecioNegociado.Text == "" || !double.TryParse(txtPrecioNegociado.Text.Trim(), out precioNegociado))
            {
                 ClsHelper.MensajeSistema("Valor en precio negociado es invalido...");
                return false;
            }            
            return true;
        }

    }
       
}
