namespace PV
{
    partial class FrmCrearBackup
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
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnCrearCopia = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRuta.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRuta.FlatAppearance.BorderSize = 0;
            this.btnRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuta.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.btnRuta.ForeColor = System.Drawing.Color.White;
            this.btnRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRuta.Location = new System.Drawing.Point(283, 69);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(35, 27);
            this.btnRuta.TabIndex = 60;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnCrearCopia
            // 
            this.btnCrearCopia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearCopia.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearCopia.FlatAppearance.BorderSize = 0;
            this.btnCrearCopia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCrearCopia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCrearCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCopia.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrearCopia.ForeColor = System.Drawing.Color.White;
            this.btnCrearCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearCopia.Location = new System.Drawing.Point(90, 113);
            this.btnCrearCopia.Name = "btnCrearCopia";
            this.btnCrearCopia.Size = new System.Drawing.Size(139, 27);
            this.btnCrearCopia.TabIndex = 61;
            this.btnCrearCopia.Text = "Iniciar Copia";
            this.btnCrearCopia.UseVisualStyleBackColor = false;
            this.btnCrearCopia.Click += new System.EventHandler(this.btnCrearCopia_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(1, 69);
            this.txtRuta.MaxLength = 50;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(281, 27);
            this.txtRuta.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 47);
            this.label3.TabIndex = 63;
            this.label3.Text = "Crear copia de seguridad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Guardar en:";
            // 
            // FrmCrearBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 146);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnCrearCopia);
            this.Controls.Add(this.btnRuta);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCrearBackup";
            this.Text = "FrmCrearBackup";
            this.Load += new System.EventHandler(this.FrmCrearBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnCrearCopia;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}