namespace PV
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grdExistentes = new System.Windows.Forms.DataGridView();
            this.editarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombresCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusExistentes = new System.Windows.Forms.StatusStrip();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCAncelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).BeginInit();
            this.statusExistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
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
            this.nombresCol,
            this.nitCol,
            this.dpiCol,
            this.telefonosCol,
            this.correoElectronicoCol,
            this.direccionCol});
            this.grdExistentes.EnableHeadersVisualStyles = false;
            this.grdExistentes.GridColor = System.Drawing.Color.LightGray;
            this.grdExistentes.Location = new System.Drawing.Point(0, 240);
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
            this.grdExistentes.Size = new System.Drawing.Size(945, 276);
            this.grdExistentes.TabIndex = 10;
            this.grdExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExistentes_CellClick);
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
            this.editarCol.MinimumWidth = 30;
            this.editarCol.Name = "editarCol";
            this.editarCol.ReadOnly = true;
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
            // 
            // nombresCol
            // 
            this.nombresCol.DataPropertyName = "nombres";
            this.nombresCol.FillWeight = 199.7983F;
            this.nombresCol.HeaderText = "Nombres";
            this.nombresCol.Name = "nombresCol";
            this.nombresCol.ReadOnly = true;
            // 
            // nitCol
            // 
            this.nitCol.DataPropertyName = "nit";
            this.nitCol.HeaderText = "NIT";
            this.nitCol.Name = "nitCol";
            this.nitCol.ReadOnly = true;
            // 
            // dpiCol
            // 
            this.dpiCol.DataPropertyName = "dpi";
            this.dpiCol.HeaderText = "DPI";
            this.dpiCol.Name = "dpiCol";
            this.dpiCol.ReadOnly = true;
            // 
            // telefonosCol
            // 
            this.telefonosCol.DataPropertyName = "telefonos";
            this.telefonosCol.HeaderText = "Telefonos";
            this.telefonosCol.Name = "telefonosCol";
            this.telefonosCol.ReadOnly = true;
            // 
            // correoElectronicoCol
            // 
            this.correoElectronicoCol.DataPropertyName = "correoElectronico";
            this.correoElectronicoCol.HeaderText = "Email";
            this.correoElectronicoCol.Name = "correoElectronicoCol";
            this.correoElectronicoCol.ReadOnly = true;
            // 
            // direccionCol
            // 
            this.direccionCol.DataPropertyName = "direccion";
            this.direccionCol.HeaderText = "Dirección";
            this.direccionCol.Name = "direccionCol";
            this.direccionCol.ReadOnly = true;
            // 
            // statusExistentes
            // 
            this.statusExistentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblExistentes});
            this.statusExistentes.Location = new System.Drawing.Point(0, 521);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusExistentes.Size = new System.Drawing.Size(942, 22);
            this.statusExistentes.TabIndex = 48;
            this.statusExistentes.Text = "statusStrip1";
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            this.lblExistentes.Size = new System.Drawing.Size(0, 17);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "NIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Telefonos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nombre *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "DPI *";
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
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(786, 88);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 31);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCAncelar
            // 
            this.btnCAncelar.BackColor = System.Drawing.Color.Red;
            this.btnCAncelar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCAncelar.FlatAppearance.BorderSize = 0;
            this.btnCAncelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCAncelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCAncelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAncelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAncelar.ForeColor = System.Drawing.Color.White;
            this.btnCAncelar.Image = global::PV.Properties.Resources.Cancel_File_24px;
            this.btnCAncelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCAncelar.Location = new System.Drawing.Point(786, 181);
            this.btnCAncelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCAncelar.Name = "btnCAncelar";
            this.btnCAncelar.Size = new System.Drawing.Size(111, 29);
            this.btnCAncelar.TabIndex = 9;
            this.btnCAncelar.Text = "Cancelar";
            this.btnCAncelar.UseVisualStyleBackColor = false;
            this.btnCAncelar.Click += new System.EventHandler(this.btnCAncelar_Click);
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
            this.btnGrabar.Location = new System.Drawing.Point(786, 135);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(111, 29);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(40, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 3);
            this.panel2.TabIndex = 79;
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(38, 89);
            this.txtNit.MaxLength = 25;
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(171, 22);
            this.txtNit.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(224, 89);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(522, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDpi
            // 
            this.txtDpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDpi.Location = new System.Drawing.Point(38, 133);
            this.txtDpi.MaxLength = 13;
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(186, 22);
            this.txtDpi.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(241, 133);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(504, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonos.Location = new System.Drawing.Point(38, 179);
            this.txtTelefonos.MaxLength = 50;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(280, 22);
            this.txtTelefonos.TabIndex = 5;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(340, 179);
            this.txtCorreoElectronico.MaxLength = 50;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(406, 22);
            this.txtCorreoElectronico.TabIndex = 6;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 543);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.txtTelefonos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDpi);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCAncelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusExistentes);
            this.Controls.Add(this.grdExistentes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCAncelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.DataGridViewImageColumn editarCol;
        private System.Windows.Forms.DataGridViewImageColumn eliminarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionCol;
    }
}