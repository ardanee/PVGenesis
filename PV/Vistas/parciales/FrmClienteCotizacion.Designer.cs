namespace PV.Vistas.parciales
{
    partial class FrmClienteCotizacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnGenerarCotizacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sucursal donde se cotiza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono asesor/sucursal";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(172, 61);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(327, 25);
            this.txtCliente.TabIndex = 3;
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(172, 92);
            this.txtSucursal.MaxLength = 60;
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(327, 25);
            this.txtSucursal.TabIndex = 4;
            this.txtSucursal.Text = "Importadora Genesis, Escuintla";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(172, 123);
            this.txtTelefono.MaxLength = 30;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(327, 25);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "78547812";
            // 
            // btnGenerarCotizacion
            // 
            this.btnGenerarCotizacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerarCotizacion.FlatAppearance.BorderSize = 0;
            this.btnGenerarCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerarCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerarCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerarCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCotizacion.Image = global::PV.Properties.Resources.Print_24px;
            this.btnGenerarCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarCotizacion.Location = new System.Drawing.Point(208, 168);
            this.btnGenerarCotizacion.Name = "btnGenerarCotizacion";
            this.btnGenerarCotizacion.Size = new System.Drawing.Size(181, 27);
            this.btnGenerarCotizacion.TabIndex = 32;
            this.btnGenerarCotizacion.Text = "Generar Cotización";
            this.btnGenerarCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCotizacion.UseVisualStyleBackColor = false;
            this.btnGenerarCotizacion.Click += new System.EventHandler(this.btnGenerarCotizacion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::PV.Properties.Resources.Error_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(395, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(515, 34);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Generador cotización";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmClienteCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 207);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerarCotizacion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmClienteCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClienteCotizacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGenerarCotizacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
    }
}