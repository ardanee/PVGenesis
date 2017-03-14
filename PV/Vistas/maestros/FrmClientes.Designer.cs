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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCAncelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblExistentes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).BeginInit();
            this.statusExistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(270, 161);
            this.txtCorreoElectronico.MaxLength = 50;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(249, 22);
            this.txtCorreoElectronico.TabIndex = 6;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonos.Location = new System.Drawing.Point(17, 161);
            this.txtTelefonos.MaxLength = 50;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(236, 22);
            this.txtTelefonos.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(176, 115);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(343, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtDpi
            // 
            this.txtDpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDpi.Location = new System.Drawing.Point(15, 115);
            this.txtDpi.MaxLength = 13;
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(142, 22);
            this.txtDpi.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(153, 71);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(366, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(15, 71);
            this.txtNit.MaxLength = 25;
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(119, 22);
            this.txtNit.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(53, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 5);
            this.panel2.TabIndex = 98;
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
            this.btnBuscar.Location = new System.Drawing.Point(534, 152);
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
            this.btnCAncelar.Location = new System.Drawing.Point(768, 154);
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
            this.btnGrabar.Location = new System.Drawing.Point(651, 153);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(111, 29);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblExistentes
            // 
            this.lblExistentes.Name = "lblExistentes";
            this.lblExistentes.Size = new System.Drawing.Size(0, 17);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "NIT";
            // 
            // grdExistentes
            // 
            this.grdExistentes.AllowUserToAddRows = false;
            this.grdExistentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdExistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdExistentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExistentes.BackgroundColor = System.Drawing.Color.White;
            this.grdExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.grdExistentes.Location = new System.Drawing.Point(1, 227);
            this.grdExistentes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grdExistentes.MultiSelect = false;
            this.grdExistentes.Name = "grdExistentes";
            this.grdExistentes.ReadOnly = true;
            this.grdExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdExistentes.RowHeadersWidth = 20;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdExistentes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdExistentes.RowTemplate.Height = 30;
            this.grdExistentes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdExistentes.Size = new System.Drawing.Size(896, 373);
            this.grdExistentes.TabIndex = 10;
            // 
            // editarCol
            // 
            this.editarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.editarCol.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.statusExistentes.Location = new System.Drawing.Point(0, 605);
            this.statusExistentes.Name = "statusExistentes";
            this.statusExistentes.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusExistentes.Size = new System.Drawing.Size(897, 22);
            this.statusExistentes.TabIndex = 91;
            this.statusExistentes.Text = "statusStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Nombre *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "DPI *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Telefonos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Email";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(897, 34);
            this.lblTitulo.TabIndex = 99;
            this.lblTitulo.Text = "Clientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 627);
            this.Controls.Add(this.lblTitulo);
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
            this.Controls.Add(this.grdExistentes);
            this.Controls.Add(this.statusExistentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdExistentes)).EndInit();
            this.statusExistentes.ResumeLayout(false);
            this.statusExistentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCAncelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ToolStripStatusLabel lblExistentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdExistentes;
        private System.Windows.Forms.DataGridViewImageColumn editarCol;
        private System.Windows.Forms.DataGridViewImageColumn eliminarCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonosCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionCol;
        private System.Windows.Forms.StatusStrip statusExistentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTitulo;
    }
}