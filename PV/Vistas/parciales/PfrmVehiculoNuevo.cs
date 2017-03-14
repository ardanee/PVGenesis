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
    public partial class PfrmVehiculoNuevo : Form
    {
        private PV.FrmVehiculo _p;
        private string idVeh;
        public PfrmVehiculoNuevo( PV.FrmVehiculo _p, string idVeh = "0")
        {
            InitializeComponent();
            try
            {
                this._p = _p;
                this.tbCosto.TableName = "tvpCostos";
                this.tbCosto.Columns.Add("id", typeof(string));
                this.tbCosto.Columns.Add("tag", typeof(string));
                this.tbCosto.Columns.Add("tipoCosto", typeof(string));
                this.tbCosto.Columns.Add("monto", typeof(double));
                this.tbCosto.Columns.Add("observaciones", typeof(string));
                this.tbCosto.Columns.Add("idTipoCosto", typeof(int));
                //this.cmbMarca.Enabled = false;
                this.cmbLinea.Enabled = false;
                this.idVeh = idVeh;


                //this.cmbModelo.Enabled = false;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


        //Metodo para cuando se realizara una edicion de un vehiculo
        private void cargarEdicion()
        {
            try
            {
                BL.ClsVehiculo clsVehiculo = new BL.ClsVehiculo();
                DataRow drVehiculo = clsVehiculo.seleccionarUnVehiculo(this.idVeh).Rows[0];
                this.txtPlaca.Text = drVehiculo["placa"].ToString();
                cmbOrigen.SelectedIndex = Int32.Parse(drVehiculo["origen"].ToString());
                cmbTipoVehiculo.SelectedValue = Int32.Parse(drVehiculo["idTipoVehiculo"].ToString());
                cmbMarca.SelectedValue = Int32.Parse(drVehiculo["idMarca"].ToString());
                cmbLinea.SelectedValue = Int32.Parse(drVehiculo["idLinea"].ToString());
                cmbModelo.SelectedItem = Int32.Parse(drVehiculo["modelo"].ToString());
                cmbTransmision.SelectedIndex = Int32.Parse(drVehiculo["transmision"].ToString());
                cmbCilindros.SelectedItem = Int32.Parse(drVehiculo["cilindros"].ToString());
                cmbAsientos.SelectedItem = Int32.Parse(drVehiculo["asientos"].ToString());
                cmbPuertas.SelectedItem = Int32.Parse(drVehiculo["puertas"].ToString());
                cmbAC.SelectedIndex = Int32.Parse(drVehiculo["ac"].ToString());
                cmbGasolina.SelectedIndex = Int32.Parse(drVehiculo["combustible"].ToString());
                txtCc.Text = drVehiculo["cc"].ToString();
                txtColores.Text = drVehiculo["color"].ToString();
                txtTon.Text = drVehiculo["ton"].ToString();
                txtNoChasis.Text = drVehiculo["chasis"].ToString();
                txtNoMotor.Text = drVehiculo["motor"].ToString();
                txtVin.Text = drVehiculo["vin"].ToString();
                txtObservaciones.Text = drVehiculo["observaciones"].ToString();
                txtPoliza.Text = drVehiculo["poliza"].ToString();
                txtNombrePropietario.Text = drVehiculo["propietario"].ToString();
                txtNit.Text = drVehiculo["nitPropietario"].ToString();
                txtDireccionPropietario.Text = drVehiculo["direccionPropietario"].ToString();
                txtPrecioComercial.Text = drVehiculo["precioVenta"].ToString();
                txtFecha.Text = drVehiculo["fechaIngreso"].ToString();
                BL.ClsCosto clsCosto = new BL.ClsCosto();
                this.tbCosto = clsCosto.seleccionarCostosVehiculo(this.idVeh);
                this.grdCostos.DataSource = tbCosto;
                totalCosto();
                
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void frmPPIngresoVehiculo_load(object sender, EventArgs e)
        {
            try
            {
                this.cargarComboTipoVehiculo();
                this.cargarCombosExtra();
                this.cargarComboMarca();
                this.txtFecha.Text = DateTime.Now.ToString();
                this.txtPlaca.Focus();

                if (this.idVeh != "0")
                    this.cargarEdicion();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }



        //metodos paraControles ---------------------------------------------------------------------------------

        //Metodo para consultar que tab esta seleccionada y bloquear
        public void frmChange_Index(object sender, EventArgs e)
        {
            try
            {
                switch (this.tabIngresoVehiculo.SelectedIndex)
                {

                    case 0:

                        this.txtPlaca.Focus();
                        break;

                    case 1:
                        this.txtNombrePropietario.Focus();
                        break;

                    case 2:
                        this.carcarComboTipoCosto();
                        this.cmbTipoCosto.Focus();
                        break;

                    case 3:
                        this.cargarResumen();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


        private void cargarResumen()
        {
            try
            {
                this.lblPlaca.Text = this.txtPlaca.Text;
                this.lblTipo.Text = this.cmbTipoVehiculo.Text.ToString();
                this.lblMarca.Text = this.cmbMarca.Text.ToString();
                this.lblLinea.Text = this.cmbLinea.Text.ToString();
                this.lblModelo.Text = this.cmbModelo.Text.ToString();
                this.lblTransmision.Text = this.cmbTransmision.Text.ToString();
                this.lblTon.Text = this.txtTon.Text;
                this.lblCC.Text = this.txtCc.Text;
                this.lblCilindros.Text = this.cmbCilindros.Text.ToString();
                this.lblAsientos.Text = this.cmbAsientos.Text.ToString();
                this.lblPuertas.Text = this.cmbPuertas.Text.ToString();
                this.lblColor.Text = this.txtColores.Text;
                this.lblChasis.Text = this.txtNoChasis.Text;
                this.lblMotor.Text = this.txtNoMotor.Text;
                this.lblVin.Text = this.txtVin.Text;
                this.lblObservaciones.Text = this.txtObservaciones.Text;
                this.lblAC.Text = this.cmbAC.Text;
                this.lblNombrePropietario.Text = this.txtNombrePropietario.Text;
                this.lblNitPropietario.Text = this.txtNit.Text;
                this.lblPoliza.Text = this.txtPoliza.Text;
                this.lblInversion.Text = this.lblTotal.Text;
                this.txtPrecioComercial.Focus();
                this.lblCombustible.Text = this.cmbGasolina.Text.ToString();
                
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

        // Metodo para bloquear Tabs
        private void tabControler_Selecting(object sender, TabControlCancelEventArgs e)
        {
            /*if (e.TabPage == this.tabPropiedad || e.TabPage == this.tabCostos || e.TabPage == this.tabValorComercial)
            {
                e.Cancel = true;
                //this.txtNombrePropietario.Focus();
                //MessageBox.Show("Hello");
            }*/

            if (e.TabPage == this.tabPropiedad)
                if (!this.validarControlesCaracteristica())
                {
                    e.Cancel = true;
                    //MessageBox.Show("indice: " + tabIngresoVehiculo.);
                }
            if (e.TabPage == this.tabCostos)
                if (!this.validarControlesPropietario())
                    e.Cancel = true;
            if (e.TabPage == this.tabValorComercial)
                if (!this.validarControlesGenerales())
                    e.Cancel = true;
        }


        //Metodo generico para cargar combos
        private void cargarCombos(DataTable dataTable, ComboBox combo, string extra)
        {
            try
            {
                Dictionary<int, String> diccionario = new Dictionary<int, string>();
                diccionario.Add(0, "Seleccione " + extra + "...");
                foreach (DataRow row in dataTable.Rows)
                {
                    diccionario.Add(Int32.Parse(row[0].ToString()), row[1].ToString());
                }
                combo.DisplayMember = "Value";
                combo.ValueMember = "Key";
                combo.DataSource = diccionario.ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo para cargar combo marca
        private void cargarComboMarca()
        {
            try
            {
                BL.ClsMarca clsMarca = new BL.ClsMarca();
                //DataTable dt = clsMarca.seleccionar("");
                cargarCombos(clsMarca.seleccionar(""), cmbMarca, "una marca");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //metodo para cargar combo linea
        private void cargarComboLinea()
        {
            try
            {
                BL.ClsLinea clsLinea = new BL.ClsLinea();
                cargarCombos(clsLinea.seleccionarLineaMarca(cmbMarca.SelectedValue.ToString()), this.cmbLinea, "una Linea");
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void cargarComboTipoVehiculo()
        {
            try
            {
                BL.ClsTipoVehiculo clsTipoVehiculo = new BL.ClsTipoVehiculo();
                //DataTable dt = clsTipoVehiculo.seleccionar("");
                cargarCombos(clsTipoVehiculo.seleccionar(""), this.cmbTipoVehiculo, "tipo de vehiculo");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cargarCombosExtra()
        {
            try
            {
                for (int i = 1990; i <= DateTime.Now.Year + 1; i++)
                    this.cmbModelo.Items.Add(i);
                this.cmbTransmision.Items.Add("Automatico");
                this.cmbTransmision.Items.Add("Manual");
                this.cmbCilindros.Items.Add(3);
                this.cmbCilindros.Items.Add(4);
                this.cmbCilindros.Items.Add(6);
                this.cmbCilindros.Items.Add(8);
                this.cmbAsientos.Items.Add(2);
                this.cmbAsientos.Items.Add(3);
                this.cmbAsientos.Items.Add(4);
                this.cmbAsientos.Items.Add(5);
                this.cmbAsientos.Items.Add(6);
                this.cmbPuertas.Items.Add(2);
                this.cmbPuertas.Items.Add(3);
                this.cmbPuertas.Items.Add(4);
                this.cmbPuertas.Items.Add(5);
                this.cmbModelo.SelectedItem = 2010;
                this.cmbPuertas.SelectedItem = 4;
                this.cmbTransmision.SelectedItem = "Automatico";
                this.cmbCilindros.SelectedItem = 4;
                this.cmbPuertas.SelectedItem = 2;
                this.cmbAsientos.SelectedItem = 5;
                this.cmbOrigen.Items.Add("Importado");
                this.cmbOrigen.Items.Add("Agencia");
                this.cmbOrigen.SelectedIndex = 0;
                this.cmbAC.Items.Add("SI");
                this.cmbAC.Items.Add("NO");
                this.cmbAC.SelectedIndex = 0;
                this.cmbGasolina.Items.Add("Gasolina");
                this.cmbGasolina.Items.Add("Diesel");
                this.cmbGasolina.SelectedItem = "Gasolina";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cambiarPlacaMayuscula(object sender,EventArgs e)
        {
            try
            {
                cambiarMayuscula(this.txtPlaca);
            }
            catch (Exception)
            {
                throw;
            }
            //this.txtPlaca.Text = this.txtPlaca.Text.ToUpper();
            //this.txtPlaca.Select(this.txtPlaca.Text.Length,0);
        }


       

        private void cambiarMayuscula(TextBox txt){
            try
            {
                txt.Text = txt.Text.ToUpper();
                txt.Select(txt.Text.Length, 0);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            
        }

        private void cambiarChasisMayuscula(object sender, EventArgs e)
        {
            try
            {
                this.txtNoChasis.Text = this.txtNoChasis.Text.ToUpper();
                this.txtNoChasis.Select(this.txtNoChasis.Text.Length, 0);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void cambiarNoMotorMayuscula(object sender, EventArgs e)
        {
            try
            {
                this.txtNoMotor.Text = this.txtNoMotor.Text.ToUpper();
                this.txtNoMotor.Select(this.txtNoMotor.Text.Length, 0);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void cambiarVinMayuscula(object sender, EventArgs e)
        {
            try
            {
                this.txtVin.Text = this.txtVin.Text.ToUpper();
                this.txtVin.Select(this.txtVin.Text.Length, 0);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            
        }

        //Metodos para tab Costos----------------------------------------------------------------------------------

        private String idCosto = "0";
        private string indexCosto = "-1";
        private DataTable tbCosto = new DataTable();
        private int countCosto = 1;

        //Carga el combo de tipo costo
        private void carcarComboTipoCosto()
        {
            try
            {
                BL.ClsTipoCosto clsTipoCosto = new BL.ClsTipoCosto();
                cargarCombos(clsTipoCosto.seleccionar(""), cmbTipoCosto, "tipo de costo");
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo click en la celda - este controlara seleccionar la celda eliminar o actualizar
        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //ClsHelper.MensajeSistema("fila: " + e.RowIndex.ToString());
                switch (e.ColumnIndex)
                {

                    case 0:
                        this.indexCosto = e.RowIndex.ToString();
                         
                        //this.idCosto = this.grdCostos.SelectedRows[0].Cells["idCol"].Value.ToString(); //update
                        this.idCosto = this.grdCostos.Rows[e.RowIndex].Cells["idCol"].Value.ToString();
                        //this.txtEtiqueta.Text = this.grdCostos.SelectedRows[0].Cells["tagCol"].Value.ToString();
                        this.txtEtiqueta.Text = this.grdCostos.Rows[e.RowIndex].Cells["tagCol"].Value.ToString();
                       // DataRow dr = this.tbCosto.Rows[e.RowIndex];

                        //this.txtMonto.Text = dr["monto"].ToString();
                        this.txtMonto.Text = this.grdCostos.Rows[e.RowIndex].Cells["montoCol"].Value.ToString();
                            //this.grdCostos.SelectedRows[0].Cells["MontoCol"].Value.ToString();

                        //this.txtObservacionCosto.Text = this.grdCostos.SelectedRows[0].Cells["observacionesCol"].Value.ToString();
                        this.txtObservacionCosto.Text = this.grdCostos.Rows[e.RowIndex].Cells["observacionesCol"].Value.ToString();

                        //this.cmbTipoCosto.SelectedValue = Int32.Parse(this.grdCostos.SelectedRows[0].Cells["idTipoCostoCol"].Value.ToString());
                        this.cmbTipoCosto.SelectedValue = Int32.Parse(this.grdCostos.Rows[e.RowIndex].Cells["idTipoCostoCol"].Value.ToString());
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            //DataRow[] dt = this.tbCosto.Select("id = '" + this.grdCostos.SelectedRows[0].Cells["idCol"].Value.ToString() +"'");
                            //dt[0].Delete();
                            tbCosto.Rows[e.RowIndex].Delete();
                            tbCosto.AcceptChanges();
                            limpiarControles();
                            this.totalCosto();
                            //ClsTipoCosto.eliminar(grdExistentes.SelectedRows[0].Cells["idTipoCostoCol"].Value.ToString());
                            //ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            //limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.idCosto = "0";
                ClsHelper.erroLog(ex);
            }
        }

        //Limpiar controles tab Costos
        private void limpiarControles()
        {
            try{
                this.txtMonto.Clear();
                this.txtObservacionCosto.Clear();
                this.txtEtiqueta.Clear();
                this.cmbTipoCosto.SelectedValue = 0;
                this.idCosto = "0";
                this.txtEtiqueta.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Calcular costo de costos almacenados en grid
        private void totalCosto()
        {
            try
            {
                double total = 0.00;
                if (this.tbCosto.Rows.Count > 0)
                    total = double.Parse(tbCosto.Compute("sum(monto)", "").ToString());

                this.lblTotal.Text = total.ToString();
                //MessageBox.Show("costo: " + total);
            }
            catch (Exception)
            {
                throw;
            }
        

        }

        public void agregarGridCosto()
        {
            try
            {
                DataRow dt = this.tbCosto.NewRow();

                if (this.indexCosto == "-1")
                {
                    //dt["id"] = "D" + (this.countCosto).ToString()//
                    dt["id"] = 0;
                    if (this.validarControlesCosto(dt))
                    {
                        dt["tipoCosto"] = this.cmbTipoCosto.Text.ToString();
                        dt["observaciones"] = this.txtObservacionCosto.Text;
                        this.tbCosto.Rows.Add(dt);
                        this.limpiarControles();
                        this.countCosto++;
                        //this.tbCosto.Rows.Add(this.idCosto);
                    }

                }
                else
                {
                    //DataRow[] drow = this.tbCosto.Select("id = "+this.idCosto); 
                    /*DataRow drow = null;
                    for (int i = 0; i <= (this.tbCosto.Rows.Count - 1); i++)
                    {
                        DataRow dr = this.tbCosto.Rows[i];
                        if (dr["id"].ToString() == this.idCosto)
                        {
                            drow = dr;
                        }
                    }
                    */
                    //DataRow[] srow = this.tbCosto.Select("id = '" + this.idCosto + "'");
                    DataRow srow = this.tbCosto.Rows[Int32.Parse(this.indexCosto)];

                    if (this.validarControlesCosto(srow) && srow != null)
                    {
                        srow["tipoCosto"] = this.cmbTipoCosto.Text.ToString();
                        srow["observaciones"] = this.txtObservacionCosto.Text;
                        this.tbCosto.AcceptChanges();
                        //this.tbCosto.Rows.Add(drow);
                        this.limpiarControles();
                    }
                    this.indexCosto = "-1";

                }
                this.grdCostos.DataSource = this.tbCosto;
                this.totalCosto();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private bool validarControlesCosto(DataRow dt)
        {
            try
            {
                if (this.txtEtiqueta.Text != "")
                    dt["tag"] = this.txtEtiqueta.Text;
                else
                {
                    MessageBox.Show("Ingrese una etiqueta para el costo...");
                    return false;
                }
                if (this.cmbTipoCosto.SelectedValue.ToString() != "0")
                    dt["idTipoCosto"] = this.cmbTipoCosto.SelectedValue.ToString();
                else
                {
                    MessageBox.Show("Tipo de Costo no seleccionado...");
                    return false;
                }

                if (this.txtMonto.Text != "")
                {
                    double i;
                    if (double.TryParse(this.txtMonto.Text, out i))
                        dt["monto"] = this.txtMonto.Text;
                    else
                    {
                        MessageBox.Show("Monto no es Valido");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("No hay monto a asignar...");
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                PV.FrmTipoCosto frmTCosto = new FrmTipoCosto();
                frmTCosto.ShowDialog(this);
                this.carcarComboTipoCosto();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnCAncelarFrmCosto_Click(object sender, EventArgs e)
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

        private void btnGrabarFrmCosto_Click(object sender, EventArgs e)
        {
            try
            {
                this.agregarGridCosto();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }




        //Metodos para Tab  Descripcion ----------------------------------------------------------------------------------

        // metodo para cuando se selecciona un item de CmbTipoVehiculo
        public void cmbTipoVehiculo_selected_item(object sender, EventArgs e)
        {
            /*if (Int32.Parse(cmbTipoVehiculo.SelectedValue.ToString()) > 0)
            {
                    this.cmbMarca.Enabled = true;
                    this.cargarComboMarca();
                //MessageBox.Show("ID marca: " + cmbMarca.SelectedValue.ToString());
                //this.txtNombre.Enabled = true;
                //this.txtNombre.Focus();
            }
            else
            {
                if (idVeh == "0")
                {
                    this.cmbMarca.Enabled = false;
                    this.cmbMarca.SelectedValue = 0;
                }
                //limpiarControles();
            }*/
        }

        //Metodo para cuando se selecciona un item de cmbMarca
        public void cmbMarca_selected_item(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(cmbMarca.SelectedValue.ToString()) > 0)
                {
                    this.cmbLinea.Enabled = true;
                    this.cargarComboLinea();
                    //MessageBox.Show("ID marca: " + cmbMarca.SelectedValue.ToString());
                    //this.txtNombre.Enabled = true;
                    //this.txtNombre.Focus();
                }
                else
                {
                    this.cmbLinea.Enabled = false;
                    this.cmbLinea.SelectedValue = 0;
                    //limpiarControles();
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnCancelarDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Seguro Desea Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    this._p.cargarFormListaVehiculos();
                    this._p.liberarFormIngreso();
                    //this.Dispose();
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }


        }

        private void btnSiguienteDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Val ac: " + this.cmbAC.Text);
                //MessageBox.Show("valor: " + this.cmbTipoVehiculo.Text.ToString());
                if (this.validarControlesCaracteristica())
                    this.tabIngresoVehiculo.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            
            
            //MessageBox.Show("modelo: " + this.cmbModelo.SelectedValue.ToString());
        }

        private void btnSiguientePropiedad_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validarControlesPropietario())
                    this.tabIngresoVehiculo.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

        private void btnRegresarPropiedad_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabIngresoVehiculo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

        private void btnSiguienteCostos_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabIngresoVehiculo.SelectedIndex = 3;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

      

        

        private void btnCancelarRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabIngresoVehiculo.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabIngresoVehiculo.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        public bool validarPrecioVenta()
        {
            try
            {
                if(txtPrecioComercial.Text != "")
                {
                    double precio = 0.00;
                    if (Double.TryParse(txtPrecioComercial.Text.Trim(), out precio))
                        return true;
                    else
                    {
                        ClsHelper.MensajeSistema("Precio de venta es invalido...");
                        return false;
                    }
                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Precio de venta se encuentra vacio desea continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                        return true;
                    else
                        return false;
                }
            }catch(Exception)
            {
                throw;
            }
        }
        private void tbnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarControlesGenerales())
                {
                    if (validarPrecioVenta())
                    {
                        //DialogResult r = MessageBox.Show("¿Confirma que desea guardar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if (r == DialogResult.Yes)
                        //{
                            DataTable dtNew = this.tbCosto;
                            dtNew.Columns.Remove("TipoCosto");
                            BL.ClsVehiculo clsVehiculo = new BL.ClsVehiculo();
                            clsVehiculo.grabarModificar(this.idVeh.Trim(),
                                this.cmbTipoVehiculo.SelectedValue.ToString().Trim(),
                                this.cmbMarca.SelectedValue.ToString(),
                                this.cmbLinea.SelectedValue.ToString(),
                                this.cmbModelo.Text,
                                this.txtPlaca.Text,
                                this.txtNoChasis.Text,
                                this.txtColores.Text,
                                this.cmbAsientos.Text, this.cmbPuertas.Text, this.cmbTransmision.SelectedIndex.ToString(),
                                this.txtNoMotor.Text, this.txtCc.Text, this.cmbCilindros.Text, this.txtVin.Text,
                                this.txtTon.Text, this.txtObservaciones.Text, this.cmbAC.SelectedIndex.ToString(),
                                this.txtNombrePropietario.Text, this.txtNit.Text, this.txtDireccionPropietario.Text,
                                this.txtPoliza.Text, txtFecha.Text, this.txtPrecioComercial.Text, this.cmbOrigen.SelectedIndex.ToString(), dtNew,
                                this.cmbGasolina.SelectedIndex.ToString()
                                );
                            ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            this._p.cargarFormListaVehiculos();
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


           private bool validarControlesGenerales(){
                try
                {
                    if (!this.validarControlesCaracteristica() || !this.validarControlesPropietario())
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                return true;
            }


        private bool validarControlesPropietario(){
            try
            {
                if (txtNombrePropietario.Text.ToString() == "")
                {
                    ClsHelper.MensajeSistema("Debe ingresar el nombre de propietario...");
                    return false;
                }
                else if (txtNit.Text.ToString() == "")
                {
                    ClsHelper.MensajeSistema("Debe ingresar nit del propietario del vehiculo...");
                    return false;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabIngresoVehiculo.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

        public bool validarControlesCaracteristica()
        {
            try
            {
                if (txtPlaca.Text.ToString().Trim() == "")
                {
                    ClsHelper.MensajeSistema("Debe ingresar placa al vehiculo...");
                    return false;
                }
                if ((Int32.Parse(cmbTipoVehiculo.SelectedValue.ToString())) <= 0)
                {
                    ClsHelper.MensajeSistema("Debe seleccionar un tipo vehiculo");
                    return false;
                }
                else if (Int32.Parse(cmbMarca.SelectedValue.ToString()) <= 0)
                {
                    ClsHelper.MensajeSistema("Debe seleccionar una Linea...");
                    return false;
                }
                else if (Int32.Parse(cmbLinea.SelectedValue.ToString()) <= 0)
                {
                    ClsHelper.MensajeSistema("Debe seleccionar una linea...");
                    return false;
                }

                // ClsHelper.MensajeSistema(cmbTipoVehiculo.SelectedValue.ToString());

            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                PV.FrmMarca fMarca = new FrmMarca();
                fMarca.ShowDialog(this);
                fMarca.Dispose();
                fMarca = null;
                cargarComboMarca();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnAgregarTipoVehiculo_Click(object sender, EventArgs e)
        {
            try { 
                PV.FrmTipoVehiculo fTipoVehiculo = new FrmTipoVehiculo();
                fTipoVehiculo.ShowDialog(this);
                fTipoVehiculo.Dispose();
                fTipoVehiculo = null;
                cargarComboTipoVehiculo();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnAgregarLinea_Click(object sender, EventArgs e)
        {
            try {
                 
                FrmLinea fLinea = new FrmLinea();
                fLinea.ShowDialog(this);
                fLinea.Dispose();
                fLinea = null;
                cargarComboLinea();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }



    }
}
