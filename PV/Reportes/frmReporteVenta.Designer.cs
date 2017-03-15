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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.editarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.idVentaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPagadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotasCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaUltimaCuotaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotasRestantesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.statusExistentes.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.ColumnHeadersHeight = 30;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editarCol,
            this.eliminarCol,
            this.idVentaCol,
            this.clienteCol,
            this.fechaCol,
            this.valorCol,
            this.montoPagadoCol,
            this.CuotasCol,
            this.fechaUltimaCuotaCol,
            this.saldoCol,
            this.cuotasRestantesCol});
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.GridColor = System.Drawing.Color.LightGray;
            this.grdDatos.Location = new System.Drawing.Point(0, 96);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.RowTemplate.Height = 30;
            this.grdDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(1049, 373);
            this.grdDatos.TabIndex = 39;
            // 
            // editarCol
            // 
            this.editarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.editarCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.editarCol.FillWeight = 121.8274F;
            this.editarCol.HeaderText = "";
            this.editarCol.Image = global::PV.Properties.Resources.Pencil_Tip_24px;
            this.editarCol.MinimumWidth = 30;
            this.editarCol.Name = "editarCol";
            this.editarCol.ReadOnly = true;
            this.editarCol.Visible = false;
            this.editarCol.Width = 30;
            // 
            // eliminarCol
            // 
            this.eliminarCol.FillWeight = 53.33205F;
            this.eliminarCol.HeaderText = "";
            this.eliminarCol.Image = global::PV.Properties.Resources.Delete_24px;
            this.eliminarCol.MinimumWidth = 30;
            this.eliminarCol.Name = "eliminarCol";
            this.eliminarCol.ReadOnly = true;
            this.eliminarCol.Visible = false;
            // 
            // idVentaCol
            // 
            this.idVentaCol.DataPropertyName = "idVenta";
            this.idVentaCol.HeaderText = "Codigo";
            this.idVentaCol.MaxInputLength = 10;
            this.idVentaCol.Name = "idVentaCol";
            this.idVentaCol.ReadOnly = true;
            this.idVentaCol.Visible = false;
            // 
            // clienteCol
            // 
            this.clienteCol.DataPropertyName = "cliente";
            this.clienteCol.HeaderText = "Cliente";
            this.clienteCol.MaxInputLength = 60;
            this.clienteCol.Name = "clienteCol";
            this.clienteCol.ReadOnly = true;
            // 
            // fechaCol
            // 
            this.fechaCol.DataPropertyName = "fecha";
            this.fechaCol.HeaderText = "Fecha";
            this.fechaCol.MaxInputLength = 30;
            this.fechaCol.Name = "fechaCol";
            this.fechaCol.ReadOnly = true;
            // 
            // valorCol
            // 
            this.valorCol.DataPropertyName = "valor";
            this.valorCol.HeaderText = "Valor";
            this.valorCol.MaxInputLength = 20;
            this.valorCol.Name = "valorCol";
            this.valorCol.ReadOnly = true;
            // 
            // montoPagadoCol
            // 
            this.montoPagadoCol.DataPropertyName = "montoPagado";
            this.montoPagadoCol.HeaderText = "Monto Pagado";
            this.montoPagadoCol.MaxInputLength = 20;
            this.montoPagadoCol.Name = "montoPagadoCol";
            this.montoPagadoCol.ReadOnly = true;
            // 
            // CuotasCol
            // 
            this.CuotasCol.DataPropertyName = "cantidadCuotas";
            this.CuotasCol.HeaderText = "Cuotas";
            this.CuotasCol.MaxInputLength = 10;
            this.CuotasCol.Name = "CuotasCol";
            this.CuotasCol.ReadOnly = true;
            // 
            // fechaUltimaCuotaCol
            // 
            this.fechaUltimaCuotaCol.DataPropertyName = "fechaUltimaCuota";
            this.fechaUltimaCuotaCol.HeaderText = "Fecha Ultima Cuota";
            this.fechaUltimaCuotaCol.MaxInputLength = 20;
            this.fechaUltimaCuotaCol.Name = "fechaUltimaCuotaCol";
            this.fechaUltimaCuotaCol.ReadOnly = true;
            // 
            // saldoCol
            // 
            this.saldoCol.DataPropertyName = "saldo";
            this.saldoCol.HeaderText = "Saldo";
            this.saldoCol.MaxInputLength = 20;
            this.saldoCol.Name = "saldoCol";
            this.saldoCol.ReadOnly = true;
            // 
            // cuotasRestantesCol
            // 
            this.cuotasRestantesCol.DataPropertyName = "cuotasRestantes";
            this.cuotasRestantesCol.HeaderText = "Cuotas Restantes";
            this.cuotasRestantesCol.MaxInputLength = 10;
            this.cuotasRestantesCol.Name = "cuotasRestantesCol";
            this.cuotasRestantesCol.ReadOnly = true;
            // 
            // statusExistentes
            // 
            this.statusExistentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes});
            this.statusExistentes.Location = new System.Drawing.Point(0, 472);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Size = new System.Drawing.Size(1047, 22);
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
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Desde:";
            // 
            // picFechaInicio
            // 
            this.picFechaInicio.CustomFormat = "dd/mm/yyyy";
            this.picFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.picFechaInicio.Location = new System.Drawing.Point(13, 65);
            this.picFechaInicio.Name = "picFechaInicio";
            this.picFechaInicio.Size = new System.Drawing.Size(259, 25);
            this.picFechaInicio.TabIndex = 42;
            // 
            // picFechaFin
            // 
            this.picFechaFin.CustomFormat = "dd/mm/yyyy";
            this.picFechaFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.picFechaFin.Location = new System.Drawing.Point(291, 65);
            this.picFechaFin.Name = "picFechaFin";
            this.picFechaFin.Size = new System.Drawing.Size(259, 25);
            this.picFechaFin.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
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
            this.btnBuscar.Location = new System.Drawing.Point(568, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 36);
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
            this.btnReestablecer.Location = new System.Drawing.Point(666, 54);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(124, 36);
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
            this.btnExportar.Location = new System.Drawing.Point(807, 55);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 35);
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
            this.lblTitulo.Size = new System.Drawing.Size(1047, 34);
            this.lblTitulo.TabIndex = 100;
            this.lblTitulo.Text = "Reporte Ventas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 494);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.picFechaFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusExistentes);
            this.Controls.Add(this.grdDatos);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporteVenta";
            this.Text = "FrmReporteVenta";
            this.Load += new System.EventHandler(this.frmReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker picFechaInicio;
        private System.Windows.Forms.DateTimePicker picFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.DataGridViewImageColumn editarCol;
        private System.Windows.Forms.DataGridViewImageColumn eliminarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPagadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotasCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaUltimaCuotaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotasRestantesCol;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblTitulo;
    }
}