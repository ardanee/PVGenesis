namespace PV.Vistas.parciales
{
    partial class PfrmVentaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PfrmVentaLista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdExistentes = new System.Windows.Forms.DataGridView();
            this.verCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.idVentaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoVentaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusExistentes = new System.Windows.Forms.StatusStrip();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).BeginInit();
            this.statusExistentes.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdExistentes.ColumnHeadersHeight = 30;
            this.grdExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verCol,
            this.eliminarCol,
            this.idVentaCol,
            this.clienteCol,
            this.fechaCol,
            this.montoVentaCol});
            this.grdExistentes.EnableHeadersVisualStyles = false;
            this.grdExistentes.GridColor = System.Drawing.Color.LightGray;
            this.grdExistentes.Location = new System.Drawing.Point(0, 56);
            this.grdExistentes.MultiSelect = false;
            this.grdExistentes.Name = "grdExistentes";
            this.grdExistentes.ReadOnly = true;
            this.grdExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdExistentes.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdExistentes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdExistentes.RowTemplate.Height = 30;
            this.grdExistentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExistentes.Size = new System.Drawing.Size(890, 376);
            this.grdExistentes.TabIndex = 5;
            this.grdExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExistentes_CellContentClick);
            // 
            // verCol
            // 
            this.verCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.verCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.verCol.FillWeight = 121.8274F;
            this.verCol.HeaderText = "";
            this.verCol.Image = global::PV.Properties.Resources.Visible_24px;
            this.verCol.MinimumWidth = 10;
            this.verCol.Name = "verCol";
            this.verCol.ReadOnly = true;
            this.verCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.verCol.Width = 30;
            // 
            // eliminarCol
            // 
            this.eliminarCol.FillWeight = 89.26021F;
            this.eliminarCol.HeaderText = "";
            this.eliminarCol.Image = global::PV.Properties.Resources.Delete_24px;
            this.eliminarCol.MinimumWidth = 10;
            this.eliminarCol.Name = "eliminarCol";
            this.eliminarCol.ReadOnly = true;
            this.eliminarCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminarCol.Visible = false;
            // 
            // idVentaCol
            // 
            this.idVentaCol.DataPropertyName = "idVenta";
            this.idVentaCol.FillWeight = 44.53566F;
            this.idVentaCol.HeaderText = "Código";
            this.idVentaCol.MaxInputLength = 10;
            this.idVentaCol.MinimumWidth = 10;
            this.idVentaCol.Name = "idVentaCol";
            this.idVentaCol.ReadOnly = true;
            // 
            // clienteCol
            // 
            this.clienteCol.DataPropertyName = "cliente";
            this.clienteCol.FillWeight = 181.4514F;
            this.clienteCol.HeaderText = "Cliente";
            this.clienteCol.MaxInputLength = 90;
            this.clienteCol.Name = "clienteCol";
            this.clienteCol.ReadOnly = true;
            // 
            // fechaCol
            // 
            this.fechaCol.DataPropertyName = "fecha";
            this.fechaCol.FillWeight = 90.81728F;
            this.fechaCol.HeaderText = "Fecha";
            this.fechaCol.MaxInputLength = 10;
            this.fechaCol.Name = "fechaCol";
            this.fechaCol.ReadOnly = true;
            // 
            // montoVentaCol
            // 
            this.montoVentaCol.DataPropertyName = "montoVenta";
            this.montoVentaCol.FillWeight = 90.81728F;
            this.montoVentaCol.HeaderText = "Monto Venta";
            this.montoVentaCol.MaxInputLength = 10;
            this.montoVentaCol.Name = "montoVentaCol";
            this.montoVentaCol.ReadOnly = true;
            // 
            // statusExistentes
            // 
            this.statusExistentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes});
            this.statusExistentes.Location = new System.Drawing.Point(0, 434);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusExistentes.Size = new System.Drawing.Size(890, 22);
            this.statusExistentes.TabIndex = 6;
            this.statusExistentes.Text = "statusStrip1";
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            this.lblExistentes.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(12, 29);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(394, 22);
            this.txtCriterio.TabIndex = 8;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.FillWeight = 121.8274F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PV.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 53.33205F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PV.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 131;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaVenta.BackColor = System.Drawing.Color.Navy;
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Image = global::PV.Properties.Resources.Buy_24px1;
            this.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaVenta.Location = new System.Drawing.Point(510, 29);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(127, 24);
            this.btnNuevaVenta.TabIndex = 10;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(412, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 24);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // PfrmVentaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 456);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusExistentes);
            this.Controls.Add(this.grdExistentes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PfrmVentaLista";
            this.Text = "PfrmListaVentas";
            this.Load += new System.EventHandler(this.PfrmListaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn verCol;
        private System.Windows.Forms.DataGridViewImageColumn eliminarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoVentaCol;

    }
}