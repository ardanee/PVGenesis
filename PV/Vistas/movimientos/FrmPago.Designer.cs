namespace PV
{
    partial class FrmPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.grdVenta = new System.Windows.Forms.DataGridView();
            this.verPagosCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.estadoCuentaCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.nuevoPagoCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.idVentaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPago = new System.Windows.Forms.DataGridView();
            this.adjuntoCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.anularCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.idPagoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCuotaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaAdjuntoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCreacionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(341, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(2, 57);
            this.txtBusqueda.MaxLength = 50;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(336, 22);
            this.txtBusqueda.TabIndex = 3;
            // 
            // grdVenta
            // 
            this.grdVenta.AllowUserToAddRows = false;
            this.grdVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVenta.BackgroundColor = System.Drawing.Color.White;
            this.grdVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVenta.ColumnHeadersHeight = 30;
            this.grdVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verPagosCol,
            this.estadoCuentaCol,
            this.nuevoPagoCol,
            this.idVentaCol,
            this.nombreCol,
            this.telefonosCol,
            this.vehiculoCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdVenta.EnableHeadersVisualStyles = false;
            this.grdVenta.GridColor = System.Drawing.Color.LightGray;
            this.grdVenta.Location = new System.Drawing.Point(1, 84);
            this.grdVenta.MultiSelect = false;
            this.grdVenta.Name = "grdVenta";
            this.grdVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdVenta.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdVenta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdVenta.RowTemplate.Height = 30;
            this.grdVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVenta.Size = new System.Drawing.Size(998, 188);
            this.grdVenta.TabIndex = 4;
            this.grdVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVenta_CellClick);
            // 
            // verPagosCol
            // 
            this.verPagosCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.verPagosCol.FillWeight = 304.5685F;
            this.verPagosCol.HeaderText = "Ver Pagos";
            this.verPagosCol.Image = global::PV.Properties.Resources.Todo_List_24px;
            this.verPagosCol.Name = "verPagosCol";
            this.verPagosCol.Width = 75;
            // 
            // estadoCuentaCol
            // 
            this.estadoCuentaCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estadoCuentaCol.FillWeight = 59.08629F;
            this.estadoCuentaCol.HeaderText = "Estado de Cuenta";
            this.estadoCuentaCol.Image = global::PV.Properties.Resources.Accounting_24px;
            this.estadoCuentaCol.Name = "estadoCuentaCol";
            this.estadoCuentaCol.Width = 90;
            // 
            // nuevoPagoCol
            // 
            this.nuevoPagoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nuevoPagoCol.FillWeight = 59.08629F;
            this.nuevoPagoCol.HeaderText = "Nuevo Pago";
            this.nuevoPagoCol.Image = global::PV.Properties.Resources.Cash_In_Hand_24px;
            this.nuevoPagoCol.Name = "nuevoPagoCol";
            this.nuevoPagoCol.Width = 75;
            // 
            // idVentaCol
            // 
            this.idVentaCol.DataPropertyName = "idVenta";
            this.idVentaCol.HeaderText = "idVenta";
            this.idVentaCol.Name = "idVentaCol";
            this.idVentaCol.Visible = false;
            // 
            // nombreCol
            // 
            this.nombreCol.DataPropertyName = "nombre";
            this.nombreCol.FillWeight = 59.08629F;
            this.nombreCol.HeaderText = "Cliente";
            this.nombreCol.Name = "nombreCol";
            // 
            // telefonosCol
            // 
            this.telefonosCol.FillWeight = 59.08629F;
            this.telefonosCol.HeaderText = "Teléfonos";
            this.telefonosCol.Name = "telefonosCol";
            // 
            // vehiculoCol
            // 
            this.vehiculoCol.DataPropertyName = "vehiculo";
            this.vehiculoCol.FillWeight = 59.08629F;
            this.vehiculoCol.HeaderText = "Vehículo";
            this.vehiculoCol.Name = "vehiculoCol";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1007, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pagos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Busque un crédito activo";
            // 
            // grdPago
            // 
            this.grdPago.AllowUserToAddRows = false;
            this.grdPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPago.BackgroundColor = System.Drawing.Color.White;
            this.grdPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdPago.ColumnHeadersHeight = 30;
            this.grdPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adjuntoCol,
            this.anularCol,
            this.idPagoCol,
            this.fechaCol,
            this.numeroCuotaCol,
            this.montoCol,
            this.metodoPagoCol,
            this.rutaAdjuntoCol,
            this.usuarioCreacionCol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPago.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdPago.EnableHeadersVisualStyles = false;
            this.grdPago.GridColor = System.Drawing.Color.LightGray;
            this.grdPago.Location = new System.Drawing.Point(1, 310);
            this.grdPago.MultiSelect = false;
            this.grdPago.Name = "grdPago";
            this.grdPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdPago.RowHeadersWidth = 20;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdPago.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdPago.RowTemplate.Height = 30;
            this.grdPago.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPago.Size = new System.Drawing.Size(998, 190);
            this.grdPago.TabIndex = 13;
            this.grdPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPago_CellClick);
            // 
            // adjuntoCol
            // 
            this.adjuntoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.adjuntoCol.HeaderText = "Adjunto";
            this.adjuntoCol.Image = global::PV.Properties.Resources.Attach_24px;
            this.adjuntoCol.Name = "adjuntoCol";
            this.adjuntoCol.Width = 65;
            // 
            // anularCol
            // 
            this.anularCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.anularCol.FillWeight = 344.697F;
            this.anularCol.HeaderText = "Anular";
            this.anularCol.Image = global::PV.Properties.Resources.No_Cash_24px;
            this.anularCol.Name = "anularCol";
            this.anularCol.Width = 65;
            // 
            // idPagoCol
            // 
            this.idPagoCol.DataPropertyName = "idPago";
            this.idPagoCol.HeaderText = "idPago";
            this.idPagoCol.Name = "idPagoCol";
            this.idPagoCol.Visible = false;
            // 
            // fechaCol
            // 
            this.fechaCol.DataPropertyName = "fecha";
            this.fechaCol.FillWeight = 59.21717F;
            this.fechaCol.HeaderText = "Fecha";
            this.fechaCol.Name = "fechaCol";
            // 
            // numeroCuotaCol
            // 
            this.numeroCuotaCol.DataPropertyName = "numeroCuota";
            this.numeroCuotaCol.FillWeight = 59.21717F;
            this.numeroCuotaCol.HeaderText = "No. Cuota";
            this.numeroCuotaCol.Name = "numeroCuotaCol";
            // 
            // montoCol
            // 
            this.montoCol.DataPropertyName = "monto";
            this.montoCol.FillWeight = 59.21717F;
            this.montoCol.HeaderText = "Monto";
            this.montoCol.Name = "montoCol";
            // 
            // metodoPagoCol
            // 
            this.metodoPagoCol.DataPropertyName = "metodoPago";
            this.metodoPagoCol.FillWeight = 59.21717F;
            this.metodoPagoCol.HeaderText = "Método de Pago";
            this.metodoPagoCol.Name = "metodoPagoCol";
            // 
            // rutaAdjuntoCol
            // 
            this.rutaAdjuntoCol.DataPropertyName = "rutaAdjunto";
            this.rutaAdjuntoCol.FillWeight = 59.21717F;
            this.rutaAdjuntoCol.HeaderText = "rutaAdjunto";
            this.rutaAdjuntoCol.Name = "rutaAdjuntoCol";
            // 
            // usuarioCreacionCol
            // 
            this.usuarioCreacionCol.DataPropertyName = "usuarioCreacion";
            this.usuarioCreacionCol.FillWeight = 59.21717F;
            this.usuarioCreacionCol.HeaderText = "Operado Por";
            this.usuarioCreacionCol.Name = "usuarioCreacionCol";
            // 
            // lblTituloVenta
            // 
            this.lblTituloVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloVenta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTituloVenta.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloVenta.ForeColor = System.Drawing.Color.White;
            this.lblTituloVenta.Location = new System.Drawing.Point(-2, 275);
            this.lblTituloVenta.Name = "lblTituloVenta";
            this.lblTituloVenta.Size = new System.Drawing.Size(1007, 34);
            this.lblTituloVenta.TabIndex = 14;
            this.lblTituloVenta.Text = "Lista de pagos recibidos";
            this.lblTituloVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 501);
            this.Controls.Add(this.lblTituloVenta);
            this.Controls.Add(this.grdPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.grdVenta);
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView grdVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPago;
        private System.Windows.Forms.Label lblTituloVenta;
        private System.Windows.Forms.DataGridViewImageColumn verPagosCol;
        private System.Windows.Forms.DataGridViewImageColumn estadoCuentaCol;
        private System.Windows.Forms.DataGridViewImageColumn nuevoPagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoCol;
        private System.Windows.Forms.DataGridViewImageColumn adjuntoCol;
        private System.Windows.Forms.DataGridViewImageColumn anularCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCuotaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPagoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaAdjuntoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCreacionCol;
    }
}