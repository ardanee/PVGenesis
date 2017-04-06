namespace PV
{
    partial class FrmCorreo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorreo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreoDestino = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCorreoOrigen = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.grdExistentes = new System.Windows.Forms.DataGridView();
            this.statusExistentes = new System.Windows.Forms.StatusStrip();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.checkBuscar = new System.Windows.Forms.CheckBox();
            this.editarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.idCorreoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDestinoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoOrigenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).BeginInit();
            this.statusExistentes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 300;
            this.label1.Text = "Correo Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Correo Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 200;
            this.label3.Text = "Contraseña";
            // 
            // txtCorreoDestino
            // 
            this.txtCorreoDestino.Location = new System.Drawing.Point(12, 160);
            this.txtCorreoDestino.MaxLength = 60;
            this.txtCorreoDestino.Name = "txtCorreoDestino";
            this.txtCorreoDestino.Size = new System.Drawing.Size(227, 20);
            this.txtCorreoDestino.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(702, 54);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Reporte por correo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCorreoOrigen
            // 
            this.txtCorreoOrigen.Location = new System.Drawing.Point(11, 35);
            this.txtCorreoOrigen.MaxLength = 60;
            this.txtCorreoOrigen.Name = "txtCorreoOrigen";
            this.txtCorreoOrigen.Size = new System.Drawing.Size(190, 20);
            this.txtCorreoOrigen.TabIndex = 10;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(207, 35);
            this.txtContrasena.MaxLength = 60;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(190, 20);
            this.txtContrasena.TabIndex = 11;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdExistentes.ColumnHeadersHeight = 30;
            this.grdExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editarCol,
            this.eliminarCol,
            this.idCorreoCol,
            this.correoDestinoCol,
            this.correoOrigenCol,
            this.contrasenaCol,
            this.estatadoCol});
            this.grdExistentes.EnableHeadersVisualStyles = false;
            this.grdExistentes.GridColor = System.Drawing.Color.LightGray;
            this.grdExistentes.Location = new System.Drawing.Point(3, 188);
            this.grdExistentes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grdExistentes.MultiSelect = false;
            this.grdExistentes.Name = "grdExistentes";
            this.grdExistentes.ReadOnly = true;
            this.grdExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.grdExistentes.Size = new System.Drawing.Size(699, 263);
            this.grdExistentes.TabIndex = 109;
            this.grdExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExistentes_CellClick);
            // 
            // statusExistentes
            // 
            this.statusExistentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes});
            this.statusExistentes.Location = new System.Drawing.Point(0, 456);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusExistentes.Size = new System.Drawing.Size(702, 22);
            this.statusExistentes.TabIndex = 118;
            this.statusExistentes.Text = "statusStrip1";
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            this.lblExistentes.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCorreoOrigen);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sesión de Correo";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerificar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Image = global::PV.Properties.Resources.Checked_Checkbox_24px;
            this.btnVerificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVerificar.Location = new System.Drawing.Point(418, 26);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(95, 29);
            this.btnVerificar.TabIndex = 12;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerificar.UseVisualStyleBackColor = false;
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
            this.dataGridViewImageColumn1.Image = global::PV.Properties.Resources.Pencil_Tip_24px;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 53.33205F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PV.Properties.Resources.Delete_24px;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 82;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Image = global::PV.Properties.Resources.Save_as_24px;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGrabar.Location = new System.Drawing.Point(466, 150);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(95, 29);
            this.btnGrabar.TabIndex = 16;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(258, 159);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(117, 21);
            this.cmbEstado.TabIndex = 14;
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
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.Location = new System.Drawing.Point(567, 150);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 29);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // checkBuscar
            // 
            this.checkBuscar.AutoSize = true;
            this.checkBuscar.Location = new System.Drawing.Point(392, 163);
            this.checkBuscar.Name = "checkBuscar";
            this.checkBuscar.Size = new System.Drawing.Size(59, 17);
            this.checkBuscar.TabIndex = 15;
            this.checkBuscar.Text = "Buscar";
            this.checkBuscar.UseVisualStyleBackColor = true;
            this.checkBuscar.CheckedChanged += new System.EventHandler(this.checkBuscar_CheckedChanged);
            // 
            // editarCol
            // 
            this.editarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.editarCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.editarCol.FillWeight = 121.8274F;
            this.editarCol.HeaderText = "";
            this.editarCol.Image = global::PV.Properties.Resources.Pencil_Tip_24px;
            this.editarCol.MinimumWidth = 25;
            this.editarCol.Name = "editarCol";
            this.editarCol.ReadOnly = true;
            this.editarCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editarCol.Width = 25;
            // 
            // eliminarCol
            // 
            this.eliminarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.eliminarCol.FillWeight = 69.20419F;
            this.eliminarCol.HeaderText = "";
            this.eliminarCol.Image = global::PV.Properties.Resources.Delete_24px;
            this.eliminarCol.MinimumWidth = 25;
            this.eliminarCol.Name = "eliminarCol";
            this.eliminarCol.ReadOnly = true;
            this.eliminarCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminarCol.Width = 25;
            // 
            // idCorreoCol
            // 
            this.idCorreoCol.DataPropertyName = "idCorreo";
            this.idCorreoCol.HeaderText = "id Correo";
            this.idCorreoCol.Name = "idCorreoCol";
            this.idCorreoCol.ReadOnly = true;
            this.idCorreoCol.Visible = false;
            // 
            // correoDestinoCol
            // 
            this.correoDestinoCol.DataPropertyName = "correoDestino";
            this.correoDestinoCol.FillWeight = 108.6944F;
            this.correoDestinoCol.HeaderText = "Correo destino";
            this.correoDestinoCol.MaxInputLength = 60;
            this.correoDestinoCol.Name = "correoDestinoCol";
            this.correoDestinoCol.ReadOnly = true;
            // 
            // correoOrigenCol
            // 
            this.correoOrigenCol.DataPropertyName = "correoOrigen";
            this.correoOrigenCol.FillWeight = 217.1696F;
            this.correoOrigenCol.HeaderText = "Correo Origen";
            this.correoOrigenCol.MaxInputLength = 60;
            this.correoOrigenCol.Name = "correoOrigenCol";
            this.correoOrigenCol.ReadOnly = true;
            // 
            // contrasenaCol
            // 
            this.contrasenaCol.DataPropertyName = "contrasena";
            this.contrasenaCol.FillWeight = 108.6944F;
            this.contrasenaCol.HeaderText = "Contraseña";
            this.contrasenaCol.MaxInputLength = 60;
            this.contrasenaCol.Name = "contrasenaCol";
            this.contrasenaCol.ReadOnly = true;
            this.contrasenaCol.Visible = false;
            // 
            // estatadoCol
            // 
            this.estatadoCol.DataPropertyName = "estado";
            this.estatadoCol.FillWeight = 108.6944F;
            this.estatadoCol.HeaderText = "Estado";
            this.estatadoCol.MaxInputLength = 20;
            this.estatadoCol.Name = "estatadoCol";
            this.estatadoCol.ReadOnly = true;
            // 
            // FrmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 478);
            this.Controls.Add(this.checkBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusExistentes);
            this.Controls.Add(this.grdExistentes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCorreoDestino);
            this.Controls.Add(this.label1);
            this.Name = "FrmCorreo";
            this.Text = "FrmCorreo";
            this.Load += new System.EventHandler(this.FrmCorreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreoDestino;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCorreoOrigen;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox checkBuscar;
        private System.Windows.Forms.DataGridViewImageColumn editarCol;
        private System.Windows.Forms.DataGridViewImageColumn eliminarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCorreoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDestinoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoOrigenCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatadoCol;
    }
}