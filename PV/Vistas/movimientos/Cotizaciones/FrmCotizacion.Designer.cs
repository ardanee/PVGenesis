namespace PV
{
    partial class FrmCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotizacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdExistentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.statusExistentes = new System.Windows.Forms.StatusStrip();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNuevaCotizacion = new System.Windows.Forms.Button();
            this.numeroCotizacionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioNegociadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diazValidezCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).BeginInit();
            this.statusExistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(945, 34);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Cotizaciones";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::PV.Properties.Resources.Error_24px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(384, 50);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 25);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(292, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 25);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdExistentes
            // 
            this.grdExistentes.AllowUserToAddRows = false;
            this.grdExistentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdExistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdExistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExistentes.BackgroundColor = System.Drawing.Color.White;
            this.grdExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdExistentes.ColumnHeadersHeight = 30;
            this.grdExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroCotizacionCol,
            this.clienteCol,
            this.sucursalCol,
            this.telefonoCol,
            this.formaPagoCol,
            this.descripcionCol,
            this.precioVentaCol,
            this.precioNegociadoCol,
            this.totalCol,
            this.diazValidezCol});
            this.grdExistentes.EnableHeadersVisualStyles = false;
            this.grdExistentes.GridColor = System.Drawing.Color.LightGray;
            this.grdExistentes.Location = new System.Drawing.Point(3, 93);
            this.grdExistentes.MultiSelect = false;
            this.grdExistentes.Name = "grdExistentes";
            this.grdExistentes.ReadOnly = true;
            this.grdExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdExistentes.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdExistentes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdExistentes.RowTemplate.Height = 30;
            this.grdExistentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExistentes.Size = new System.Drawing.Size(942, 301);
            this.grdExistentes.TabIndex = 35;
            this.grdExistentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExistentes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "BUSCAR";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(12, 54);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(257, 21);
            this.txtBusqueda.TabIndex = 33;
            // 
            // statusExistentes
            // 
            this.statusExistentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes});
            this.statusExistentes.Location = new System.Drawing.Point(0, 397);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Size = new System.Drawing.Size(945, 22);
            this.statusExistentes.TabIndex = 38;
            this.statusExistentes.Text = "statusStrip1";
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            this.lblExistentes.Size = new System.Drawing.Size(0, 17);
            // 
            // btnNuevaCotizacion
            // 
            this.btnNuevaCotizacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevaCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevaCotizacion.FlatAppearance.BorderSize = 0;
            this.btnNuevaCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNuevaCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNuevaCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCotizacion.Image = global::PV.Properties.Resources.Add_List_24px;
            this.btnNuevaCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaCotizacion.Location = new System.Drawing.Point(483, 50);
            this.btnNuevaCotizacion.Name = "btnNuevaCotizacion";
            this.btnNuevaCotizacion.Size = new System.Drawing.Size(90, 25);
            this.btnNuevaCotizacion.TabIndex = 39;
            this.btnNuevaCotizacion.Text = "Nueva";
            this.btnNuevaCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCotizacion.UseVisualStyleBackColor = false;
            this.btnNuevaCotizacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeroCotizacionCol
            // 
            this.numeroCotizacionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numeroCotizacionCol.DataPropertyName = "numeroCotizacion";
            this.numeroCotizacionCol.FillWeight = 406.3375F;
            this.numeroCotizacionCol.Frozen = true;
            this.numeroCotizacionCol.HeaderText = "Numero";
            this.numeroCotizacionCol.MaxInputLength = 10;
            this.numeroCotizacionCol.MinimumWidth = 30;
            this.numeroCotizacionCol.Name = "numeroCotizacionCol";
            this.numeroCotizacionCol.ReadOnly = true;
            this.numeroCotizacionCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numeroCotizacionCol.Width = 70;
            // 
            // clienteCol
            // 
            this.clienteCol.DataPropertyName = "cliente";
            this.clienteCol.FillWeight = 100.5474F;
            this.clienteCol.HeaderText = "Cliente";
            this.clienteCol.MaxInputLength = 60;
            this.clienteCol.Name = "clienteCol";
            this.clienteCol.ReadOnly = true;
            // 
            // sucursalCol
            // 
            this.sucursalCol.DataPropertyName = "sucursal";
            this.sucursalCol.FillWeight = 133.928F;
            this.sucursalCol.HeaderText = "Sucursal";
            this.sucursalCol.MaxInputLength = 60;
            this.sucursalCol.Name = "sucursalCol";
            this.sucursalCol.ReadOnly = true;
            // 
            // telefonoCol
            // 
            this.telefonoCol.DataPropertyName = "telefono";
            this.telefonoCol.FillWeight = 67.03159F;
            this.telefonoCol.HeaderText = "Teléfono";
            this.telefonoCol.MaxInputLength = 20;
            this.telefonoCol.Name = "telefonoCol";
            this.telefonoCol.ReadOnly = true;
            // 
            // formaPagoCol
            // 
            this.formaPagoCol.DataPropertyName = "formaPago";
            this.formaPagoCol.FillWeight = 67.03159F;
            this.formaPagoCol.HeaderText = "Forma pago";
            this.formaPagoCol.MaxInputLength = 20;
            this.formaPagoCol.Name = "formaPagoCol";
            this.formaPagoCol.ReadOnly = true;
            // 
            // descripcionCol
            // 
            this.descripcionCol.DataPropertyName = "descripcion";
            this.descripcionCol.FillWeight = 67.03159F;
            this.descripcionCol.HeaderText = "Descripcion Vehiculo";
            this.descripcionCol.MaxInputLength = 120;
            this.descripcionCol.Name = "descripcionCol";
            this.descripcionCol.ReadOnly = true;
            // 
            // precioVentaCol
            // 
            this.precioVentaCol.DataPropertyName = "precioVenta";
            this.precioVentaCol.FillWeight = 67.03159F;
            this.precioVentaCol.HeaderText = "Precio Venta";
            this.precioVentaCol.MaxInputLength = 20;
            this.precioVentaCol.Name = "precioVentaCol";
            this.precioVentaCol.ReadOnly = true;
            // 
            // precioNegociadoCol
            // 
            this.precioNegociadoCol.DataPropertyName = "precioNegociado";
            this.precioNegociadoCol.FillWeight = 67.03159F;
            this.precioNegociadoCol.HeaderText = "Precio Negociado";
            this.precioNegociadoCol.MaxInputLength = 20;
            this.precioNegociadoCol.Name = "precioNegociadoCol";
            this.precioNegociadoCol.ReadOnly = true;
            // 
            // totalCol
            // 
            this.totalCol.DataPropertyName = "totalFinanciado";
            this.totalCol.FillWeight = 67.03159F;
            this.totalCol.HeaderText = "Total Financiado";
            this.totalCol.MaxInputLength = 20;
            this.totalCol.Name = "totalCol";
            this.totalCol.ReadOnly = true;
            // 
            // diazValidezCol
            // 
            this.diazValidezCol.DataPropertyName = "validez";
            this.diazValidezCol.FillWeight = 100.5474F;
            this.diazValidezCol.HeaderText = "Dias Validez";
            this.diazValidezCol.MaxInputLength = 5;
            this.diazValidezCol.Name = "diazValidezCol";
            this.diazValidezCol.ReadOnly = true;
            // 
            // FrmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 419);
            this.Controls.Add(this.btnNuevaCotizacion);
            this.Controls.Add(this.statusExistentes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grdExistentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCotizacion";
            this.Load += new System.EventHandler(this.FrmCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.Button btnNuevaCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCotizacionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioNegociadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn diazValidezCol;
    }
}