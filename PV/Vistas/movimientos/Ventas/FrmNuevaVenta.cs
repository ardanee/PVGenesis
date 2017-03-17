using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace PV
{
    public partial class FrmNuevaVenta : Form
    {
        
        private string idVehiculo;
        private DataTable dtDetalle;
        private DataTable dtReferencias;
        private string idReferencia;
        private string dpiU;
        private string idVenta;
        private BL.ClsVenta clsVenta = new BL.ClsVenta();
        private List<string[]> referenciaStr = new List<string[]>();
        private string[] adjuntos = { "", "" };


        public FrmNuevaVenta(string idVenta = "0")
        {
            InitializeComponent();
            try
            {
                dtDetalle = new DataTable();
                //Fuente de datos para grid detalle venta
                dtDetalle.TableName = "Detalle";
                dtDetalle.Columns.Add("placa", typeof(string));
                dtDetalle.Columns.Add("descripcion", typeof(string));
                dtDetalle.Columns.Add("precioVenta", typeof(double));
                dtDetalle.Columns.Add("precioOtorgado", typeof(double));
                dtDetalle.Columns.Add("idVehiculo", typeof(string));
                grdDetalle.DataSource = dtDetalle;
                //Estructura de la fuente de datos para el grid referencias
                dtReferencias = new DataTable();
                dtReferencias.Columns.Add("id");
                dtReferencias.Columns.Add("nombreRef");
                dtReferencias.Columns.Add("telefonosRef");
                dtReferencias.Columns.Add("direccionRef");
                grdReferencias.DataSource = dtReferencias;

                this.idVenta = idVenta;


                //_p.liberarFormLista();
                iniciarValores();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

        private void PfrmNuevaVenta_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


        private void deshabilitarControlesCliente(bool estado)
        {
            txtNombres.Enabled = estado;
            txtDpi.Enabled = estado;
            txtNit.Enabled = estado;
            txtDireccion.Enabled = estado;
            txtTelefono.Enabled = estado;
            txtEmail.Enabled = estado;
            txtNombreRef.Enabled = estado;
            txtTelefonosRef.Enabled = estado;
            txtDireccionRef.Enabled = estado;
            btnAdjuntar.Enabled = estado;
            btnCancelarReferencia.Enabled = estado;
            btnAgregarReferencia.Enabled = estado;
            grdReferencias.Enabled = estado;
            btnAdjuntar.Enabled = estado;
        }

        private void deshabilitarControlesDetalle(bool estado)
        {
            txtPlaca.Enabled = estado;
            //txtDescripcion.Enabled = estado;
            btnBuscarVehiculo.Enabled = estado;
            grdDetalle.Enabled = estado;
            btngrabar.Enabled = estado;
        }


        private void deshabilitarControlesFinanciamiento(bool estado)
        {
            cmbFormapago.Enabled = estado;
            txtEnganche.Enabled = estado;
            txtPlazo.Enabled = estado;
            btnCalcular.Enabled = estado;
            cmbDiaPago.Enabled = estado;
        }


        private void cargarCombosFinanciamiento(){
            try
            {
                cmbFormapago.Items.Clear();
                cmbFormapago.Items.Add("Contado");
                cmbFormapago.Items.Add("Financiado");
                cmbDiaPago.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    cmbDiaPago.Items.Add(i);
                }
                int dia = DateTime.Now.Day;
                if (dia > 30)
                    dia = 30;
                //MessageBox.Show("dia: " + dia);
                cmbDiaPago.SelectedIndex = dia-1;

                cmbFormapago.SelectedIndex = 0;
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void iniciarValores()
        {
            try
            {

                cargarCombosFinanciamiento();
                //cargarCombosFinanciamiento();
                if (idVenta == "0")
                {
                   // MessageBox.Show("venta : " + idVenta);
                    idVehiculo = "0";
                    dpiU = "0";
                    //idVenta = "0";
                    idReferencia = "0";
                    //listado de referencias 
                    referenciaStr.Clear();
                    referenciaStr.Add(new String[] { "", "", "" });
                    referenciaStr.Add(new String[] { "", "", "" });
                    referenciaStr.Add(new String[] { "", "", "" });
                    // combo dia de pago
                    dtDetalle.Clear();
                    dtReferencias.Clear();

                    txtFechaHora.Text = DateTime.Now.ToString();
                    //this.txtFechaVencimiento.Text = DateTime.Now.ToString();
                    //this.txtFechaVencimiento.Text = DateTime.Now.ToString();
                    

                    deshabilitarControlesCliente(true);
                    deshabilitarControlesDetalle(true);
                    deshabilitarControlesFinanciamiento(false);
                    //Cargar Valores

                    limpiarControlesFinanciamiento();
                    txtNit.Focus();
                }
                else
                {
                    deshabilitarControlesCliente(false);
                    deshabilitarControlesDetalle(false);
                    deshabilitarControlesFinanciamiento(false);
                    BL.ClsVenta clsVenta = new BL.ClsVenta();
                    DataTable dtVenta = clsVenta.seleccionarVentaEdicion(idVenta);

                    txtNit.Text = dtVenta.Rows[0]["nombre"].ToString();
                    txtDpi.Text = dtVenta.Rows[0]["dpi"].ToString();
                    txtNombres.Text = dtVenta.Rows[0]["nombre"].ToString();
                    txtDireccion.Text = dtVenta.Rows[0]["direccion"].ToString();
                    txtTelefono.Text = dtVenta.Rows[0]["telefonos"].ToString();
                    txtEmail.Text = dtVenta.Rows[0]["correoElectronico"].ToString();


                    txtPlazo.Text = dtVenta.Rows[0]["cantidadCuotas"].ToString();
                    txtEnganche.Text = dtVenta.Rows[0]["enganche"].ToString();
                    txtCuotaMensual.Text = dtVenta.Rows[0]["cuota"].ToString();

                    /*if (txtPlazo.Text == "0")
                        cmbFormapago.SelectedIndex = 0;
                    else
                        cmbFormapago.SelectedIndex = 2;*/
                    cmbDiaPago.SelectedIndex = Int32.Parse(dtVenta.Rows[0]["diaPago"].ToString()) -1;
                    txtTotalVenta.Text = dtVenta.Rows[0]["valorventa"].ToString();

                    DataRow dr = dtDetalle.NewRow();
                    dr["idVehiculo"] = dtVenta.Rows[0]["idVehiculo"].ToString();
                    dr["descripcion"] = dtVenta.Rows[0]["descripcion"].ToString();
                    dr["placa"] = dtVenta.Rows[0]["placa"].ToString();
                    dr["precioOtorgado"] = dtVenta.Rows[0]["valorVenta"].ToString();
                    dr["precioVenta"] = dtVenta.Rows[0]["precioVenta"].ToString();

                    dtDetalle.Rows.Add(dr);

                    DataRow drRef = dtReferencias.NewRow();

                    drRef = dtReferencias.NewRow();
                    if (dtVenta.Rows[0]["r1Nombre"].ToString() != "")
                    {
                        drRef["id"] = "1";
                        drRef["nombreRef"] = dtVenta.Rows[0]["r1Nombre"].ToString();
                        drRef["telefonosRef"] = dtVenta.Rows[0]["r1Telefono"].ToString();
                        drRef["direccionRef"] = dtVenta.Rows[0]["r1Direccion"].ToString();
                        dtReferencias.Rows.Add(drRef);
                    }

                    drRef = dtReferencias.NewRow();
                    if (dtVenta.Rows[0]["r2Nombre"].ToString() != "")
                    {
                        drRef["id"] = "2";
                        drRef["nombreRef"] = dtVenta.Rows[0]["r2Nombre"].ToString();
                        drRef["telefonosRef"] = dtVenta.Rows[0]["r2Telefono"].ToString();
                        drRef["direccionRef"] = dtVenta.Rows[0]["r2Direccion"].ToString();
                        dtReferencias.Rows.Add(drRef);
                    }
                    drRef = dtReferencias.NewRow();
                    if (dtVenta.Rows[0]["r3Nombre"].ToString() != "")
                    {
                        drRef["id"] = "3";
                        drRef["nombreRef"] = dtVenta.Rows[0]["r3Nombre"].ToString();
                        drRef["telefonosRef"] = dtVenta.Rows[0]["r3Telefono"].ToString();
                        drRef["direccionRef"] = dtVenta.Rows[0]["r3Direccion"].ToString();
                        dtReferencias.Rows.Add(drRef);
                    }

                    txtFechaHora.Text = dtVenta.Rows[0]["fechaCreacion"].ToString();
                    txtSaldo.Text = dtVenta.Rows[0]["saldo"].ToString();

                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

       

        public void setVehiculo(string idVehiculo, string descripcion = "", string placa = "", string valor = "")
        {
            try
            {
                this.idVehiculo = idVehiculo;
                txtDescripcion.Text = descripcion;
                txtPlaca.Text = placa;
                txtPrecioVenta.Text = valor;
                txtPrecioOtorgado.Text = valor;
                txtPrecioOtorgado.Enabled = true;
                btnAgregarAuto.Enabled = true;
                btnLimpiarAuto.Enabled = true;
                btnBuscarVehiculo.Enabled = false;
                txtPlaca.Enabled = false;
                txtPrecioOtorgado.Focus();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

              
        // Manejo Controles Agregar Vehiculo a la venta
       
        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                _FrmSeleccionAutoVenta frmSAuto = new _FrmSeleccionAutoVenta(this);
                frmSAuto.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
            
        }

        private void limpiarControlesDetalleVenta()
        {
            try
            {
                txtPlaca.Clear();
                txtDescripcion.Clear();
                txtPrecioOtorgado.Clear();
                txtPrecioVenta.Clear();
                btnLimpiarAuto.Enabled = false;
                btnAgregarAuto.Enabled = false;
                btnBuscarVehiculo.Enabled = true;
                txtPlaca.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    
        private void limpiarGridDetalle()
        {
            try
            {
                dtDetalle.Clear();
            }
            catch(Exception )
            {
                throw;
            }
        }

        private void btnAgregarAuto_Click_1(object sender, EventArgs e)
        {
            try
            {
                agregarVehiculo();
            }catch(Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


        public void agregarFinanciamiento(string formaPago = "0", string enganche = "0.00", string plazo = "12")
        {
            try
            {
                cmbFormapago.SelectedIndex = int.Parse(formaPago);
               // agregarVehiculo();
                txtEnganche.Text = enganche;
                txtPlazo.Text = plazo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ventaDesdeCotizacion()
        {
            try
            {
                
                agregarVehiculo();
                //agregarFinanciamiento();
                if (dtDetalle.Rows.Count > 0)
                    calcularCredito();
                else
                    ClsHelper.MensajeSistema("No se a agregado ningun vehiculo...");
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


        private void agregarVehiculo()
        {
            try
            {
                this.cmbFormapago.Enabled = true;
                DataRow dr = this.dtDetalle.NewRow();
                dr["placa"] = txtPlaca.Text;
                dr["descripcion"] = txtDescripcion.Text;
                dr["precioVenta"] = Double.Parse(txtPrecioVenta.Text);
                dr["precioOtorgado"] = Double.Parse(txtPrecioOtorgado.Text);
                dr["idVehiculo"] = this.idVehiculo;
                dtDetalle.Rows.Add(dr);
                limpiarControlesDetalleVenta();

                txtPrecioOtorgado.Enabled = false;
                btnAgregarAuto.Enabled = false;
                btnBuscarVehiculo.Enabled = false;
                txtPlaca.Enabled = false;
                btnLimpiarAuto.Enabled = true;

                //calcularCredito();
                if (dtDetalle.Rows.Count > 0)
                    txtTotalVenta.Text = ((double)dtDetalle.Compute("sum(precioOtorgado)", "")).ToString();
                if (cmbFormapago.SelectedIndex == 1)
                    calcularCredito();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void btnLimpiarAuto_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmbFormapago.Enabled = false;
                idVehiculo = "0";
                limpiarControlesDetalleVenta();
                limpiarGridDetalle();
                //cargarValoresFinanciamiento();
                txtTotalVenta.Text = "0.00";
                txtSaldo.Text = "0.00";
                habilitarControlesFinanciamiento(false);
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


        //controles de refencias
        private void actualizarReferencias()
        {
            int i = 0;
            foreach (DataRow row in dtReferencias.Rows)
            {
                referenciaStr[i] = new string[] { row["nombreRef"].ToString(), row["telefonosRef"].ToString(), row["direccionRef"].ToString() };
                i++;
            }
        }

        private void limpiarControlesReferencias()
        {
            try
            {
                idReferencia = "0";
                txtNombreRef.Clear();
                txtTelefonosRef.Clear();
                txtDireccionRef.Clear();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void limpiarGridReferencia(){
            try{
                dtReferencias.Clear();
            }catch(Exception){
                throw;
            }
        }
        private void btnAgregarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreRef.Text != "")
                {
                    if (idReferencia == "0")
                    {
                        DataRow dr = this.dtReferencias.NewRow();
                        dr["id"] = dtReferencias.Rows.Count + 1;
                        dr["nombreRef"] = txtNombreRef.Text;
                        dr["telefonosRef"] = txtTelefonosRef.Text;
                        dr["direccionRef"] = txtDireccionRef.Text;
                        dtReferencias.Rows.Add(dr);
                    }
                    else
                    {
                        DataRow[] srow = this.dtReferencias.Select("id = '" + this.idReferencia + "'");
                        if (srow[0] != null)
                        {
                            srow[0]["nombreRef"] = this.txtNombreRef.Text.ToString();
                            srow[0]["telefonosRef"] = this.txtTelefonosRef.Text;
                            srow[0]["direccionRef"] = this.txtDireccionRef.Text;
                            this.dtReferencias.AcceptChanges();
                        }

                    }
                }
                else
                    MessageBox.Show("Ingresar un Nombre de Referencias");
                validarReferencias();
                this.txtNombreRef.Focus();

            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

        private void validarReferencias()
        {
            try
            {
                limpiarControlesReferencias();
                if (this.dtReferencias.Rows.Count >= 3)
                {
                    this.txtNombreRef.Enabled = false;
                    this.txtDireccionRef.Enabled = false;
                    this.txtTelefonosRef.Enabled = false;
                    this.btnAgregarReferencia.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancelarReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarControlesReferencias();
            }catch(Exception ex)
            { 
                ClsHelper.erroLog(ex);
            }
        }


        private void grdReferencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            try
            {
                BL.ClsVehiculo clsVehiculo = new BL.ClsVehiculo();
                DataTable dtVehiculo = clsVehiculo.seleccionarVehiculoInfo(txtPlaca.Text.Trim());
                if (dtVehiculo.Rows.Count == 1)
                {
                    DataRow dr = dtVehiculo.Rows[0];
                    setVehiculo(
                        dr["idVehiculo"].ToString(),
                        dr["descripcion"].ToString(),
                        dr["placa"].ToString(),
                        dr["monto"].ToString());
                }
                else
                {
                    //ClsHelper.MensajeSistema("Se encontro mas de un vehiculo");
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }


        //Manejo Controles Cliente

        private void limpiarControlesCliente()
        {
            try
            {
                this.txtNit.Clear();
                this.txtDpi.Clear();
                this.txtDireccion.Clear();
                this.txtTelefono.Clear();
                this.txtEmail.Clear();
                this.txtNombres.Clear();
                this.txtDpi.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void txtNit_Leave(object sender, EventArgs e)
        {
            try
            {
                BL.ClsCliente clsCliente = new BL.ClsCliente();
                DataTable dtCliente = clsCliente.seleccionarUnCliente(txtNit.Text.Trim());
                if (dtCliente.Rows.Count == 1)
                {
                    DataRow dr = dtCliente.Rows[0];
                    dpiU = dr["dpi"].ToString().Trim(); ;
                    txtDpi.Text = dr["dpi"].ToString().Trim(); ;
                    txtNombres.Text = dr["nombre"].ToString();
                    txtDireccion.Text = dr["direccion"].ToString();
                    txtTelefono.Text = dr["telefonos"].ToString();
                    txtEmail.Text = dr["correoElectronico"].ToString();
                    txtDpi.Enabled = false;
                }
               /* else
                {
                    string nit = txtNit.Text;
                    limpiarControlesCliente();
                    txtNit.Text = nit;
                }*/
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

     



         //Manejo controles financiamiento

        public void limpiarControlesFinanciamiento()
        {
            try
            {
                //cmbFormapago.SelectedIndex = 0;
                //cmbDiaPago.SelectedIndex = 15;
                int dia = DateTime.Now.Day;
                if (dia > 30)
                    dia = 30;
                cmbDiaPago.SelectedIndex = dia-1;
                txtEnganche.Text = "0.00";
                txtCuotaMensual.Text = "0.00";
                txtPlazo.Text = "1";
                txtSaldo.Text = "0.00";
                if (dtDetalle.Rows.Count > 0)
                    txtTotalVenta.Text = ((double)dtDetalle.Compute("sum(precioOtorgado)", "")).ToString();
                else
                    txtTotalVenta.Text = "0.00";
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }
        private void habilitarControlesFinanciamiento(bool estado)
        {
            try
            {
                txtEnganche.Enabled = estado;
                txtPlazo.Enabled = estado;
                btnCalcular.Enabled = estado;
                cmbDiaPago.Enabled = estado;
                limpiarControlesFinanciamiento();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void cmbFormapago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbFormapago.SelectedIndex == 1)
                {
                    habilitarControlesFinanciamiento(true);
                    txtPlazo.Text = "12";
                    //calcularCredito();
                }
                else
                {
                    habilitarControlesFinanciamiento(false);
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }

        }

        private bool validarControlesFinanciamiento()
        {
            int entero = 0;
            double flotante = 0.00;
            if (! int.TryParse(txtPlazo.Text, out entero))
            {
                ClsHelper.MensajeSistema("Valor de plazo es invalido, agrege valor correcto y recalcule...");
                return false;
                
            }
            if (! double.TryParse(txtEnganche.Text, out flotante))
            {
                ClsHelper.MensajeSistema("Valor de enganche es invalido, agrege valor correcto y recalcule...");
                return false;
            }
            return true;
        }

        private void calcularCredito()
        {
            try
            {
                if (cmbFormapago.SelectedIndex == 0)
                {
                    if (dtDetalle.Rows.Count > 0)
                        txtTotalVenta.Text = Math.Round(((double)dtDetalle.Compute("sum(precioOtorgado)", ""))).ToString();
                }
                else
                {
                    if (validarControlesFinanciamiento())
                    {


                        double total = 0.00;
                        if (grdDetalle.Rows.Count == 1)
                        {
                            total = Math.Round(((double)dtDetalle.Compute("sum(precioOtorgado)", "")));
                        }
                        int cuotas = int.Parse(txtPlazo.Text);
                        double enganche = Math.Round(double.Parse(txtEnganche.Text));


                        //double total = Math.Round(double.Parse(txtTotalVenta.Text),2);
                        //double cuotas = double.Parse(txtPlazo.Text);
                        //double enganche = Math.Round(double.Parse(txtEnganche.Text), 2);
                        if (cuotas >= 2)
                        {
                            if (enganche < total)
                            {
                                double saldo = Math.Round((total - enganche));
                                double cuota = Math.Round((saldo / cuotas));

                                double nuevoTotal = Math.Round(((cuota * cuotas) + enganche));
                                double nuevoSaldo = Math.Round((nuevoTotal - enganche));

                                txtCuotaMensual.Text = cuota.ToString();
                                txtSaldo.Text = nuevoSaldo.ToString();
                                txtTotalVenta.Text = nuevoTotal.ToString();
                            }
                            else
                            {
                                ClsHelper.MensajeSistema("Monto de enganche sobrepasa valor venta, realizar venta al contado...");
                            }
                        }
                        else
                        {
                            ClsHelper.MensajeSistema("Cuota minima de financiamiento es 2");
                        }
                            
                    }
                }
                txtPlazo.Focus();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtDetalle.Rows.Count > 0)
                    calcularCredito();
                else
                    ClsHelper.MensajeSistema("No se a agregado ningun vehiculo...");
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
                
        }

        
   

        // Controles de adjuntar documento
        private int contadorAdjuntos = 0;
        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsScanner scan = new ClsScanner();
                string img = scan.scanv2();
                if (img != "")
                {
                    int r = contadorAdjuntos % 2;
                    if (r == 0)
                    {
                        adjuntos[0] = img;
                        //listaAdjuntos.Items.Add("-" + img);
                    }
                    else
                    {
                        adjuntos[1] = img;
                        //listaAdjuntos.Items.Add("-" + img);
                    }
                    contadorAdjuntos++;
                    listaAdjuntos.Items.Clear();
                    foreach(string adjunto in adjuntos){
                        if(adjunto != "")
                            listaAdjuntos.Items.Add(adjunto);
                    }
                }
                //btnAdjuntar.Text = "Adjuntar Documentos (" + adjuntos.Count() +"/2)";

            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

       




        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Confirma que desea salir de generar venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //this._p.cargarFormLista();
                this.Dispose();
            }
        }


        

        public bool verificarDatosVenta()
        {

            /*
             - comprobar si se selecciono un vehiculo
             - comprobar si tiene referencias 
             - comprobar si tiene nit ingresado
             - comprobar si tiene nombre de cliente asignado
             - comprobar si tiene adjunto documentos 
             */
            try
            {
                
                if (txtNit.Text == "")
                {
                    ClsHelper.MensajeSistema("No se ha identificado ningun NIT de cliente");
                    tabControl1.SelectedIndex = 0;
                    txtNit.Focus();
                    return false;
                }
                if (txtNombres.Text == "")
                {
                    ClsHelper.MensajeSistema("No se tiene un nombre de cliente");
                    tabControl1.SelectedIndex = 0;
                    txtNombres.Focus();
                    return false;
                }
                
                if (dtReferencias.Rows.Count < 1)
                {
                    ClsHelper.MensajeSistema("Debe ingresar minimo una referencia para procesar...");
                    tabControl1.SelectedIndex = 1;
                    txtNombreRef.Focus();
                    return false;
                }

                if (this.idVehiculo == "0" || this.grdDetalle.Rows.Count < 1)
                {
                    ClsHelper.MensajeSistema("Seleccionar un vehiculo para procesar...");
                    txtPlaca.Focus();
                    return false;
                }
                else if(this.grdDetalle.Rows.Count > 1)
                {
                    ClsHelper.MensajeSistema("Incoherencias con vehiculos agregados...");
                    return false;
                }
                     
                int i = 0;
                if(!(Int32.TryParse(txtPlazo.Text, out i))){
                    ClsHelper.MensajeSistema("Valor en Plazo es invalido...");
                    txtPlazo.Focus();
                    return false;
                }
                    
            }
            catch (Exception)
            {
                throw;
            }
            
            return true;
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarDatosVenta() && validarControlesFinanciamiento())
                {
                    // comprobar si se hicieron cambios en los valores de financiamiento
                    double saldoc = 0.00;
                    double total = Math.Round(double.Parse(txtTotalVenta.Text), 2);
                    if(cmbFormapago.SelectedIndex == 1)
                    {
                        saldoc = Math.Round((Math.Round(double.Parse(txtCuotaMensual.Text), 2)) * (Math.Round(double.Parse(txtPlazo.Text), 2)), 2);
                        total = Math.Round(saldoc + (Math.Round(double.Parse(txtEnganche.Text), 2)), 2);
                    }
                    //MessageBox.Show("val: " + total +"total: " + txtTotalVenta.Text.Trim());
                    double cmp = Math.Round(total -Math.Round(double.Parse(txtTotalVenta.Text.Trim()),2));
                    if (cmp == 0)
                    {
                        actualizarReferencias();
                        if (adjuntos[0] == "")
                        {
                            DialogResult r = MessageBox.Show("¿No se a adjuntado documentos, confirma que desea Grabar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (r == DialogResult.Yes)
                            {
                                guardar();
                            }
                        }
                        else
                        {
                            guardar();
                        }

                    }else
                        ClsHelper.MensajeSistema("Valores financiamiento inconcistentes, recalcular...");                  
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void guardar()
        {
            try
            {
                //string diaPago = "0";
                string cuotas = "1";
                if (cmbFormapago.SelectedIndex == 1)
                {
                    //diaPago = cmbDiaPago.SelectedItem.ToString();
                    cuotas = txtPlazo.Text.ToString().Trim();
                }
                //MessageBox.Show("idv: " + idVehiculo + "venta: " + idVenta );
                DataTable dt = this.clsVenta.grabarModificar(
                    idVenta, this.idVehiculo,
                    txtTotalVenta.Text.Trim(),
                    txtEnganche.Text,
                    cuotas,
                    txtCuotaMensual.Text,
                    cmbDiaPago.SelectedItem.ToString(),
                    referenciaStr[0][0].ToString(), referenciaStr[0][1].ToString(), referenciaStr[0][2].ToString(),
                    referenciaStr[1][0].ToString(), referenciaStr[1][1].ToString(), referenciaStr[1][2].ToString(),
                    referenciaStr[2][0].ToString(), referenciaStr[2][1].ToString(), referenciaStr[2][2].ToString(),
                    adjuntos[0], adjuntos[1],
                    txtNombres.Text, txtNit.Text, txtDpi.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text,
                    this.dpiU,
                    this.txtFechaHora.Text
                );
                if (dt.Rows.Count >= 1)
                {
                    //ClsHelper.MensajeSistema("data column: " + dt.Rows[0][0]);
                    idVenta = dt.Rows[0]["idVenta"].ToString();
                    //ClsHelper.MensajeSistema("Proceso Realizado con exito" + idVenta);
                    this.btnImprimir.Enabled = true;
                    deshabilitarControles();
                    //habilitarControlesFinanciamiento(false);
                    ClsHelper.MensajeSistema("Proceso completado correctamente...");
                }
                else
                {
                    ClsHelper.MensajeSistema("Proceso no se completo correctamente, contactar con soporte...");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void frmChange_Index(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {
                case 0:
                    this.txtNit.Focus();
                    break;

                case 1:
                    this.txtNombreRef.Focus();                    
                    break;
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                BL.ClsReportes clsReporte = new BL.ClsReportes();
                DataTable dt = new DataTable();
                FrmReporte frmrep = new FrmReporte();
                dt = clsReporte.rptVenta(idVenta);
                frmrep.cargarReporte("RptVenta",dt);
                DialogResult r = MessageBox.Show("¿Proceso finalizado, desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    this.Dispose();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void deshabilitarControles()
        {
            deshabilitarControlesCliente(false);
            deshabilitarControlesDetalle(false);
            deshabilitarControlesFinanciamiento(false);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                idVenta = "0";
                iniciarValores();
                limpiarControlesDetalleVenta();
                limpiarGridDetalle();
                limpiarControlesReferencias();
                limpiarGridReferencia();
                limpiarControlesCliente();
                limpiarControlesFinanciamiento();
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                tabControl1.SelectedIndex = 0;
                tabControl1.Enabled = true;
                btngrabar.Enabled = true;
                btnImprimir.Enabled = false;
                txtNit.Focus();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }
    }
}
