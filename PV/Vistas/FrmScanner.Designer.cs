namespace PV
{
    partial class FrmScanner
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
            this.lstDispositivos = new System.Windows.Forms.ListBox();
            this.imgScanner = new System.Windows.Forms.PictureBox();
            this.btnEscanear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDispositivos
            // 
            this.lstDispositivos.FormattingEnabled = true;
            this.lstDispositivos.Location = new System.Drawing.Point(490, 13);
            this.lstDispositivos.Name = "lstDispositivos";
            this.lstDispositivos.Size = new System.Drawing.Size(243, 225);
            this.lstDispositivos.TabIndex = 0;
            // 
            // imgScanner
            // 
            this.imgScanner.Location = new System.Drawing.Point(12, 12);
            this.imgScanner.Name = "imgScanner";
            this.imgScanner.Size = new System.Drawing.Size(474, 479);
            this.imgScanner.TabIndex = 1;
            this.imgScanner.TabStop = false;
            // 
            // btnEscanear
            // 
            this.btnEscanear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEscanear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEscanear.FlatAppearance.BorderSize = 0;
            this.btnEscanear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEscanear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEscanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscanear.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanear.ForeColor = System.Drawing.Color.White;
            this.btnEscanear.Location = new System.Drawing.Point(490, 240);
            this.btnEscanear.Name = "btnEscanear";
            this.btnEscanear.Size = new System.Drawing.Size(243, 23);
            this.btnEscanear.TabIndex = 3;
            this.btnEscanear.Text = "Explorar Documento";
            this.btnEscanear.UseVisualStyleBackColor = false;
            this.btnEscanear.Click += new System.EventHandler(this.btnEscanear_Click);
            // 
            // FrmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 503);
            this.Controls.Add(this.btnEscanear);
            this.Controls.Add(this.imgScanner);
            this.Controls.Add(this.lstDispositivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmScanner";
            this.Text = "FrmScanner";
            this.Load += new System.EventHandler(this.FrmScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgScanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDispositivos;
        private System.Windows.Forms.PictureBox imgScanner;
        private System.Windows.Forms.Button btnEscanear;
    }
}