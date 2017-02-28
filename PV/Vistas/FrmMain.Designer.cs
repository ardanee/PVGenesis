namespace PV
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Alerter.AlertButton alertButton2 = new DevExpress.XtraBars.Alerter.AlertButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.txtUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.txtComputadora = new DevExpress.XtraBars.BarStaticItem();
            this.mnuTipoVehiculo = new DevExpress.XtraBars.BarButtonItem();
            this.mnuMarca = new DevExpress.XtraBars.BarButtonItem();
            this.mnuLinea = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCliente = new DevExpress.XtraBars.BarButtonItem();
            this.mnuTipoCosto = new DevExpress.XtraBars.BarButtonItem();
            this.mnuIngresoVehiculo = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCotizacion = new DevExpress.XtraBars.BarButtonItem();
            this.mnuVenta = new DevExpress.XtraBars.BarButtonItem();
            this.mnuPago = new DevExpress.XtraBars.BarButtonItem();
            this.mnuReporteVenta = new DevExpress.XtraBars.BarButtonItem();
            this.mnuReporteClientesAtrasados = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCerrarSesion = new DevExpress.XtraBars.BarButtonItem();
            this.mnuUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.mnuRol = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBackup = new DevExpress.XtraBars.BarButtonItem();
            this.mnuRestaurar = new DevExpress.XtraBars.BarButtonItem();
            this.rbpMaestros = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpMovimientos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpSeguridad = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.txtUsuario,
            this.txtComputadora,
            this.mnuTipoVehiculo,
            this.mnuMarca,
            this.mnuLinea,
            this.mnuCliente,
            this.mnuTipoCosto,
            this.mnuIngresoVehiculo,
            this.mnuCotizacion,
            this.mnuVenta,
            this.mnuPago,
            this.mnuReporteVenta,
            this.mnuReporteClientesAtrasados,
            this.mnuCerrarSesion,
            this.mnuUsuario,
            this.mnuRol,
            this.mnuBackup,
            this.mnuRestaurar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpMaestros,
            this.rbpMovimientos,
            this.rbpReportes,
            this.rbpSeguridad});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(730, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Id = 2;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtComputadora
            // 
            this.txtComputadora.Id = 3;
            this.txtComputadora.Name = "txtComputadora";
            this.txtComputadora.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // mnuTipoVehiculo
            // 
            this.mnuTipoVehiculo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.mnuTipoVehiculo.Caption = "Tipos de Vehículo";
            this.mnuTipoVehiculo.Glyph = global::PV.Properties.Resources.tipoVehiculo_48px;
            this.mnuTipoVehiculo.Id = 4;
            this.mnuTipoVehiculo.Name = "mnuTipoVehiculo";
            this.mnuTipoVehiculo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuTipoVehiculo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuMarca
            // 
            this.mnuMarca.Caption = "Marcas";
            this.mnuMarca.Glyph = global::PV.Properties.Resources.marca_48px;
            this.mnuMarca.Id = 5;
            this.mnuMarca.Name = "mnuMarca";
            this.mnuMarca.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuMarca.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuLinea
            // 
            this.mnuLinea.Caption = "Líneas";
            this.mnuLinea.Glyph = global::PV.Properties.Resources.linea_48px;
            this.mnuLinea.Id = 6;
            this.mnuLinea.Name = "mnuLinea";
            this.mnuLinea.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuLinea.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuCliente
            // 
            this.mnuCliente.Caption = "Clientes";
            this.mnuCliente.Glyph = global::PV.Properties.Resources.cliente_48px;
            this.mnuCliente.Id = 7;
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuCliente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuTipoCosto
            // 
            this.mnuTipoCosto.Caption = "Tipos de Costo de Vehículos";
            this.mnuTipoCosto.Glyph = global::PV.Properties.Resources.tipoCosto_48px;
            this.mnuTipoCosto.Id = 8;
            this.mnuTipoCosto.Name = "mnuTipoCosto";
            this.mnuTipoCosto.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuTipoCosto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuIngresoVehiculo
            // 
            this.mnuIngresoVehiculo.Caption = "Ingreso de Vehículos";
            this.mnuIngresoVehiculo.Glyph = global::PV.Properties.Resources.ingresoVehiculos_48px;
            this.mnuIngresoVehiculo.Id = 9;
            this.mnuIngresoVehiculo.Name = "mnuIngresoVehiculo";
            this.mnuIngresoVehiculo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuIngresoVehiculo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuCotizacion
            // 
            this.mnuCotizacion.Caption = "Cotización";
            this.mnuCotizacion.Glyph = global::PV.Properties.Resources.cotizacion_48px;
            this.mnuCotizacion.Id = 10;
            this.mnuCotizacion.Name = "mnuCotizacion";
            this.mnuCotizacion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuCotizacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuVenta
            // 
            this.mnuVenta.Caption = "Venta";
            this.mnuVenta.Glyph = global::PV.Properties.Resources.venta_48px;
            this.mnuVenta.Id = 11;
            this.mnuVenta.Name = "mnuVenta";
            this.mnuVenta.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuVenta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuPago
            // 
            this.mnuPago.Caption = "Pago";
            this.mnuPago.Glyph = global::PV.Properties.Resources.pago_48px;
            this.mnuPago.Id = 12;
            this.mnuPago.Name = "mnuPago";
            this.mnuPago.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuPago.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuReporteVenta
            // 
            this.mnuReporteVenta.Caption = "Reporte de Ventas";
            this.mnuReporteVenta.Glyph = global::PV.Properties.Resources.reporteVenta_48px;
            this.mnuReporteVenta.Id = 13;
            this.mnuReporteVenta.Name = "mnuReporteVenta";
            this.mnuReporteVenta.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuReporteVenta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuReporteClientesAtrasados
            // 
            this.mnuReporteClientesAtrasados.Caption = "Clientes Con Cuotas Atrasadas";
            this.mnuReporteClientesAtrasados.Glyph = global::PV.Properties.Resources.Clock_48px;
            this.mnuReporteClientesAtrasados.Id = 14;
            this.mnuReporteClientesAtrasados.Name = "mnuReporteClientesAtrasados";
            this.mnuReporteClientesAtrasados.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuReporteClientesAtrasados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuCerrarSesion
            // 
            this.mnuCerrarSesion.Caption = "Cerrar Sesión";
            this.mnuCerrarSesion.Glyph = global::PV.Properties.Resources.Shutdown_48px;
            this.mnuCerrarSesion.Id = 15;
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuCerrarSesion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuCerrarSesion_ItemClick);
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Caption = "Usuarios";
            this.mnuUsuario.Glyph = global::PV.Properties.Resources.usuario_48px;
            this.mnuUsuario.Id = 16;
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuRol
            // 
            this.mnuRol.Caption = "Roles";
            this.mnuRol.Glyph = global::PV.Properties.Resources.rol_48px;
            this.mnuRol.Id = 17;
            this.mnuRol.Name = "mnuRol";
            this.mnuRol.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuRol.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuBackup
            // 
            this.mnuBackup.Caption = "Crear Copia de Seguridad";
            this.mnuBackup.Glyph = global::PV.Properties.Resources.backup_48px;
            this.mnuBackup.Id = 18;
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuBackup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // mnuRestaurar
            // 
            this.mnuRestaurar.Caption = "Restaurar";
            this.mnuRestaurar.Glyph = global::PV.Properties.Resources.restore_48px;
            this.mnuRestaurar.Id = 19;
            this.mnuRestaurar.Name = "mnuRestaurar";
            this.mnuRestaurar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuRestaurar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.mnuRestaurar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuRestaurar_ItemClick);
            // 
            // rbpMaestros
            // 
            this.rbpMaestros.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.rbpMaestros.Name = "rbpMaestros";
            this.rbpMaestros.Text = "Maestros";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuTipoVehiculo);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuMarca);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuLinea);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Maestros de vehículos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuCliente);
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuTipoCosto);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Otros Maestros";
            // 
            // rbpMovimientos
            // 
            this.rbpMovimientos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpMovimientos.Name = "rbpMovimientos";
            this.rbpMovimientos.Text = "Movimientos";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.mnuIngresoVehiculo);
            this.ribbonPageGroup3.ItemLinks.Add(this.mnuCotizacion);
            this.ribbonPageGroup3.ItemLinks.Add(this.mnuVenta);
            this.ribbonPageGroup3.ItemLinks.Add(this.mnuPago);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbpReportes
            // 
            this.rbpReportes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpReportes.Name = "rbpReportes";
            this.rbpReportes.Text = "Reportes";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.mnuReporteVenta);
            this.ribbonPageGroup4.ItemLinks.Add(this.mnuReporteClientesAtrasados);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // rbpSeguridad
            // 
            this.rbpSeguridad.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.rbpSeguridad.Name = "rbpSeguridad";
            this.rbpSeguridad.Text = "Seguridad";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.mnuCerrarSesion);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.mnuUsuario);
            this.ribbonPageGroup6.ItemLinks.Add(this.mnuRol);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Accesos";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.mnuBackup);
            this.ribbonPageGroup7.ItemLinks.Add(this.mnuRestaurar);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Base de Datos";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.txtComputadora, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.txtUsuario, true);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(730, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // alertControl1
            // 
            this.alertControl1.AppearanceCaption.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.alertControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.alertControl1.AppearanceCaption.Options.UseFont = true;
            this.alertControl1.AppearanceCaption.Options.UseForeColor = true;
            this.alertControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.alertControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alertControl1.AppearanceHotTrackedText.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertControl1.AppearanceHotTrackedText.ForeColor = System.Drawing.Color.Maroon;
            this.alertControl1.AppearanceHotTrackedText.Options.UseFont = true;
            this.alertControl1.AppearanceHotTrackedText.Options.UseForeColor = true;
            this.alertControl1.AppearanceText.Font = new System.Drawing.Font("Roboto", 9F);
            this.alertControl1.AppearanceText.ForeColor = System.Drawing.Color.Maroon;
            this.alertControl1.AppearanceText.Image = global::PV.Properties.Resources.High_Priority_24px;
            this.alertControl1.AppearanceText.Options.UseFont = true;
            this.alertControl1.AppearanceText.Options.UseForeColor = true;
            this.alertControl1.AppearanceText.Options.UseImage = true;
            this.alertControl1.AppearanceText.Options.UseTextOptions = true;
            this.alertControl1.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alertControl1.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.alertControl1.AutoHeight = true;
            alertButton2.Image = global::PV.Properties.Resources.Clock_24px;
            alertButton2.Name = "btnListado";
            this.alertControl1.Buttons.Add(alertButton2);
            this.alertControl1.ControlBoxPosition = DevExpress.XtraBars.Alerter.AlertFormControlBoxPosition.Right;
            this.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            this.alertControl1.LookAndFeel.SkinName = "Office 2013";
            this.alertControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            // 
            // FrmMain
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 591);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Importadora Génesis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpMaestros;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarStaticItem txtUsuario;
        private DevExpress.XtraBars.BarStaticItem txtComputadora;
        private DevExpress.XtraBars.BarButtonItem mnuTipoVehiculo;
        private DevExpress.XtraBars.BarButtonItem mnuMarca;
        private DevExpress.XtraBars.BarButtonItem mnuLinea;
        private DevExpress.XtraBars.BarButtonItem mnuCliente;
        private DevExpress.XtraBars.BarButtonItem mnuTipoCosto;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem mnuIngresoVehiculo;
        private DevExpress.XtraBars.BarButtonItem mnuCotizacion;
        private DevExpress.XtraBars.BarButtonItem mnuVenta;
        private DevExpress.XtraBars.BarButtonItem mnuPago;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpMovimientos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpReportes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem mnuReporteVenta;
        private DevExpress.XtraBars.BarButtonItem mnuReporteClientesAtrasados;
        private DevExpress.XtraBars.BarButtonItem mnuCerrarSesion;
        private DevExpress.XtraBars.BarButtonItem mnuUsuario;
        private DevExpress.XtraBars.BarButtonItem mnuRol;
        private DevExpress.XtraBars.BarButtonItem mnuBackup;
        private DevExpress.XtraBars.BarButtonItem mnuRestaurar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSeguridad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}