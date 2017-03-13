namespace PV.Vistas.maestros
{
    partial class FrmIngresoVehiculo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCostosVehiculo = new System.Windows.Forms.TabControl();
            this.pageInfoVehiculo = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pageInfoPropietario = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pagePrecioVentaVehiculo = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCostosVehiculo.SuspendLayout();
            this.pageInfoVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PV.Properties.Resources.Traffic_Jam_48px;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso Vehiculos";
            // 
            // tabCostosVehiculo
            // 
            this.tabCostosVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCostosVehiculo.Controls.Add(this.pageInfoVehiculo);
            this.tabCostosVehiculo.Controls.Add(this.pageInfoPropietario);
            this.tabCostosVehiculo.Controls.Add(this.tabPage1);
            this.tabCostosVehiculo.Controls.Add(this.pagePrecioVentaVehiculo);
            this.tabCostosVehiculo.ItemSize = new System.Drawing.Size(67, 25);
            this.tabCostosVehiculo.Location = new System.Drawing.Point(12, 75);
            this.tabCostosVehiculo.Name = "tabCostosVehiculo";
            this.tabCostosVehiculo.Padding = new System.Drawing.Point(6, 6);
            this.tabCostosVehiculo.SelectedIndex = 0;
            this.tabCostosVehiculo.Size = new System.Drawing.Size(944, 402);
            this.tabCostosVehiculo.TabIndex = 1;
            this.tabCostosVehiculo.Tag = "Informacion de Vehiculo";
            // 
            // pageInfoVehiculo
            // 
            this.pageInfoVehiculo.BackColor = System.Drawing.Color.White;
            this.pageInfoVehiculo.Controls.Add(this.textBox2);
            this.pageInfoVehiculo.Controls.Add(this.label7);
            this.pageInfoVehiculo.Controls.Add(this.textBox1);
            this.pageInfoVehiculo.Controls.Add(this.label6);
            this.pageInfoVehiculo.Controls.Add(this.button2);
            this.pageInfoVehiculo.Controls.Add(this.button1);
            this.pageInfoVehiculo.Controls.Add(this.cmbLinea);
            this.pageInfoVehiculo.Controls.Add(this.label5);
            this.pageInfoVehiculo.Controls.Add(this.cmbModelo);
            this.pageInfoVehiculo.Controls.Add(this.label4);
            this.pageInfoVehiculo.Controls.Add(this.cmbMarca);
            this.pageInfoVehiculo.Controls.Add(this.label3);
            this.pageInfoVehiculo.Controls.Add(this.cmbTipoVehiculo);
            this.pageInfoVehiculo.Controls.Add(this.label2);
            this.pageInfoVehiculo.Location = new System.Drawing.Point(4, 29);
            this.pageInfoVehiculo.Name = "pageInfoVehiculo";
            this.pageInfoVehiculo.Padding = new System.Windows.Forms.Padding(3);
            this.pageInfoVehiculo.Size = new System.Drawing.Size(936, 369);
            this.pageInfoVehiculo.TabIndex = 0;
            this.pageInfoVehiculo.Text = "Informacion Vehiculo";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(359, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 25);
            this.textBox2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "COLOR";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(26, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 25);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "MODELO";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::PV.Properties.Resources.Close_Window_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(670, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PV.Properties.Resources.Right_Squared_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(803, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbLinea
            // 
            this.cmbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinea.Enabled = false;
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(30, 213);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(214, 25);
            this.cmbLinea.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "LINEA";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.Enabled = false;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(30, 156);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(214, 25);
            this.cmbModelo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "MODELO";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Enabled = false;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(30, 98);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(214, 25);
            this.cmbMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MARCA";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(30, 41);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(214, 25);
            this.cmbTipoVehiculo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "TIPO VEHICULO";
            // 
            // pageInfoPropietario
            // 
            this.pageInfoPropietario.Location = new System.Drawing.Point(4, 29);
            this.pageInfoPropietario.Name = "pageInfoPropietario";
            this.pageInfoPropietario.Padding = new System.Windows.Forms.Padding(3);
            this.pageInfoPropietario.Size = new System.Drawing.Size(936, 369);
            this.pageInfoPropietario.TabIndex = 1;
            this.pageInfoPropietario.Text = "Informacion Propietario";
            this.pageInfoPropietario.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 369);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Costos Vehiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pagePrecioVentaVehiculo
            // 
            this.pagePrecioVentaVehiculo.Location = new System.Drawing.Point(4, 29);
            this.pagePrecioVentaVehiculo.Name = "pagePrecioVentaVehiculo";
            this.pagePrecioVentaVehiculo.Padding = new System.Windows.Forms.Padding(3);
            this.pagePrecioVentaVehiculo.Size = new System.Drawing.Size(936, 369);
            this.pagePrecioVentaVehiculo.TabIndex = 3;
            this.pagePrecioVentaVehiculo.Text = "PRECIO VENTA";
            this.pagePrecioVentaVehiculo.UseVisualStyleBackColor = true;
            // 
            // frmIngresoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 485);
            this.Controls.Add(this.tabCostosVehiculo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIngresoVehiculo";
            this.Text = "frmIngresoVehiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCostosVehiculo.ResumeLayout(false);
            this.pageInfoVehiculo.ResumeLayout(false);
            this.pageInfoVehiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCostosVehiculo;
        private System.Windows.Forms.TabPage pageInfoVehiculo;
        private System.Windows.Forms.TabPage pageInfoPropietario;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage pagePrecioVentaVehiculo;
    }
}