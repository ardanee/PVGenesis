namespace PV
{
    partial class FrmAdjuntos
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
            this.picAdjunto1 = new System.Windows.Forms.PictureBox();
            this.picAdjunto2 = new System.Windows.Forms.PictureBox();
            this.lblAdjuntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAdjunto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdjunto2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjuntos";
            // 
            // picAdjunto1
            // 
            this.picAdjunto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdjunto1.Location = new System.Drawing.Point(12, 63);
            this.picAdjunto1.Name = "picAdjunto1";
            this.picAdjunto1.Size = new System.Drawing.Size(242, 307);
            this.picAdjunto1.TabIndex = 1;
            this.picAdjunto1.TabStop = false;
            this.picAdjunto1.Visible = false;
            this.picAdjunto1.Click += new System.EventHandler(this.picAdjunto1_Click);
            // 
            // picAdjunto2
            // 
            this.picAdjunto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdjunto2.Location = new System.Drawing.Point(260, 63);
            this.picAdjunto2.Name = "picAdjunto2";
            this.picAdjunto2.Size = new System.Drawing.Size(242, 307);
            this.picAdjunto2.TabIndex = 2;
            this.picAdjunto2.TabStop = false;
            this.picAdjunto2.Visible = false;
            this.picAdjunto2.Click += new System.EventHandler(this.picAdjunto2_Click);
            // 
            // lblAdjuntos
            // 
            this.lblAdjuntos.AutoSize = true;
            this.lblAdjuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjuntos.Location = new System.Drawing.Point(86, 34);
            this.lblAdjuntos.Name = "lblAdjuntos";
            this.lblAdjuntos.Size = new System.Drawing.Size(26, 16);
            this.lblAdjuntos.TabIndex = 3;
            this.lblAdjuntos.Text = "(0)";
            // 
            // FrmAdjuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 388);
            this.Controls.Add(this.lblAdjuntos);
            this.Controls.Add(this.picAdjunto2);
            this.Controls.Add(this.picAdjunto1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmAdjuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdjuntos";
            this.Load += new System.EventHandler(this.FrmAdjuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdjunto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdjunto2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAdjunto1;
        private System.Windows.Forms.PictureBox picAdjunto2;
        private System.Windows.Forms.Label lblAdjuntos;
    }
}