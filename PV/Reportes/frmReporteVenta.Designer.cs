namespace PV
{
    partial class FrmReporteVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusExistentes = new System.Windows.Forms.StatusStrip();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.picFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.picFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoVenta = new System.Windows.Forms.ComboBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.codigoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVentaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engancheCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCuotasCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCuotaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFinanciadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusExistentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusExistentes
            // 
            this.statusExistentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes});
            this.statusExistentes.Location = new System.Drawing.Point(0, 414);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Size = new System.Drawing.Size(1260, 22);
            this.statusExistentes.TabIndex = 40;
            this.statusExistentes.Text = "statusStrip1";
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            this.lblExistentes.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Desde:";
            // 
            // picFechaInicio
            // 
            this.picFechaInicio.CustomFormat = "dd/mm/yyyy";
            this.picFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.picFechaInicio.Location = new System.Drawing.Point(5, 57);
            this.picFechaInicio.Name = "picFechaInicio";
            this.picFechaInicio.Size = new System.Drawing.Size(246, 21);
            this.picFechaInicio.TabIndex = 42;
            // 
            // picFechaFin
            // 
            this.picFechaFin.CustomFormat = "dd/mm/yyyy";
            this.picFechaFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.picFechaFin.Location = new System.Drawing.Point(257, 57);
            this.picFechaFin.Name = "picFechaFin";
            this.picFechaFin.Size = new System.Drawing.Size(259, 21);
            this.picFechaFin.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::PV.Properties.Resources.Search_24px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(706, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 26);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.BackColor = System.Drawing.Color.Red;
            this.btnReestablecer.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReestablecer.FlatAppearance.BorderSize = 0;
            this.btnReestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.ForeColor = System.Drawing.Color.White;
            this.btnReestablecer.Image = global::PV.Properties.Resources.Clear_Filters_24px;
            this.btnReestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReestablecer.Location = new System.Drawing.Point(804, 52);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(124, 26);
            this.btnReestablecer.TabIndex = 46;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReestablecer.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::PV.Properties.Resources.Microsoft_Excel_24px;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(934, 53);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 25);
            this.btnExportar.TabIndex = 47;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1260, 30);
            this.lblTitulo.TabIndex = 100;
            this.lblTitulo.Text = "Reporte Ventas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 109;
            this.label4.Text = "Tipo Venta";
            // 
            // cmbTipoVenta
            // 
            this.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVenta.FormattingEnabled = true;
            this.cmbTipoVenta.Location = new System.Drawing.Point(527, 55);
            this.cmbTipoVenta.Name = "cmbTipoVenta";
            this.cmbTipoVenta.Size = new System.Drawing.Size(166, 23);
            this.cmbTipoVenta.TabIndex = 110;
            this.cmbTipoVenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVenta_SelectedIndexChanged);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.BackgroundColor = System.Drawing.Color.White;
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.ColumnHeadersHeight = 30;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCol,
            this.vendedorCol,
            this.clienteCol,
            this.tipoCol,
            this.marcaCol,
            this.lineaCol,
            this.fechaCol,
            this.formaCol,
            this.precioVentaCol,
            this.valorVentaCol,
            this.engancheCol,
            this.noCuotasCol,
            this.valorCuotaCol,
            this.valorFinanciadoCol,
            this.saldoCol,
            this.pagadoCol});
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.LightGray;
            this.grdDatos.Location = new System.Drawing.Point(0, 97);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.RowTemplate.Height = 30;
            this.grdDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1260, 314);
            this.grdDatos.TabIndex = 111;
            // 
            // codigoCol
            // 
            this.codigoCol.DataPropertyName = "codigo";
            this.codigoCol.HeaderText = "Código";
            this.codigoCol.MaxInputLength = 10;
            this.codigoCol.Name = "codigoCol";
            this.codigoCol.ReadOnly = true;
            // 
            // vendedorCol
            // 
            this.vendedorCol.DataPropertyName = "vendedor";
            this.vendedorCol.HeaderText = "Vendedor";
            this.vendedorCol.MaxInputLength = 60;
            this.vendedorCol.Name = "vendedorCol";
            this.vendedorCol.ReadOnly = true;
            // 
            // clienteCol
            // 
            this.clienteCol.DataPropertyName = "cliente";
            this.clienteCol.HeaderText = "Cliente";
            this.clienteCol.MaxInputLength = 60;
            this.clienteCol.Name = "clienteCol";
            this.clienteCol.ReadOnly = true;
            // 
            // tipoCol
            // 
            this.tipoCol.DataPropertyName = "tipo";
            this.tipoCol.HeaderText = "Tipo Vehiculo";
            this.tipoCol.Name = "tipoCol";
            this.tipoCol.ReadOnly = true;
            // 
            // marcaCol
            // 
            this.marcaCol.DataPropertyName = "marca";
            this.marcaCol.HeaderText = "Marca";
            this.marcaCol.MaxInputLength = 60;
            this.marcaCol.Name = "marcaCol";
            this.marcaCol.ReadOnly = true;
            // 
            // lineaCol
            // 
            this.lineaCol.DataPropertyName = "linea";
            this.lineaCol.HeaderText = "Linea";
            this.lineaCol.MaxInputLength = 60;
            this.lineaCol.Name = "lineaCol";
            this.lineaCol.ReadOnly = true;
            // 
            // fechaCol
            // 
            this.fechaCol.DataPropertyName = "fecha";
            this.fechaCol.HeaderText = "Fecha";
            this.fechaCol.MaxInputLength = 15;
            this.fechaCol.Name = "fechaCol";
            this.fechaCol.ReadOnly = true;
            // 
            // formaCol
            // 
            this.formaCol.DataPropertyName = "forma";
            this.formaCol.HeaderText = "Forma pago";
            this.formaCol.MaxInputLength = 20;
            this.formaCol.Name = "formaCol";
            this.formaCol.ReadOnly = true;
            // 
            // precioVentaCol
            // 
            this.precioVentaCol.DataPropertyName = "precio_venta";
            this.precioVentaCol.HeaderText = "Precio venta";
            this.precioVentaCol.Name = "precioVentaCol";
            this.precioVentaCol.ReadOnly = true;
            // 
            // valorVentaCol
            // 
            this.valorVentaCol.DataPropertyName = "valor_venta";
            this.valorVentaCol.HeaderText = "Valor venta";
            this.valorVentaCol.Name = "valorVentaCol";
            this.valorVentaCol.ReadOnly = true;
            // 
            // engancheCol
            // 
            this.engancheCol.DataPropertyName = "enganche";
            this.engancheCol.HeaderText = "Enganche";
            this.engancheCol.MaxInputLength = 30;
            this.engancheCol.Name = "engancheCol";
            this.engancheCol.ReadOnly = true;
            // 
            // noCuotasCol
            // 
            this.noCuotasCol.DataPropertyName = "cuotas";
            this.noCuotasCol.HeaderText = "Cuotas";
            this.noCuotasCol.MaxInputLength = 10;
            this.noCuotasCol.Name = "noCuotasCol";
            this.noCuotasCol.ReadOnly = true;
            // 
            // valorCuotaCol
            // 
            this.valorCuotaCol.DataPropertyName = "valor_cuota";
            this.valorCuotaCol.HeaderText = "Valor cuota";
            this.valorCuotaCol.MaxInputLength = 30;
            this.valorCuotaCol.Name = "valorCuotaCol";
            this.valorCuotaCol.ReadOnly = true;
            // 
            // valorFinanciadoCol
            // 
            this.valorFinanciadoCol.DataPropertyName = "valor_financiado";
            this.valorFinanciadoCol.HeaderText = "Valor Financiado";
            this.valorFinanciadoCol.MaxInputLength = 30;
            this.valorFinanciadoCol.Name = "valorFinanciadoCol";
            this.valorFinanciadoCol.ReadOnly = true;
            // 
            // saldoCol
            // 
            this.saldoCol.DataPropertyName = "saldo";
            this.saldoCol.HeaderText = "Saldo";
            this.saldoCol.Name = "saldoCol";
            this.saldoCol.ReadOnly = true;
            // 
            // pagadoCol
            // 
            this.pagadoCol.DataPropertyName = "pagado";
            this.pagadoCol.HeaderText = "Pagado";
            this.pagadoCol.MaxInputLength = 30;
            this.pagadoCol.Name = "pagadoCol";
            this.pagadoCol.ReadOnly = true;
            // 
            // FrmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 436);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.cmbTipoVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.picFechaFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusExistentes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporteVenta";
            this.Text = "FrmReporteVenta";
            this.Load += new System.EventHandler(this.frmReporteVenta_Load);
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker picFechaInicio;
        private System.Windows.Forms.DateTimePicker picFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoVenta;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVentaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn engancheCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCuotasCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCuotaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFinanciadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagadoCol;
    }
}