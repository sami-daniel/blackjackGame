namespace blackjackGame
{
    partial class MainProgram
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
            this.cartaImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bancadaDealer = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cartaImage)).BeginInit();
            this.bancadaDealer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartaImage
            // 
            this.cartaImage.ImageRotate = 0F;
            this.cartaImage.Location = new System.Drawing.Point(0, 0);
            this.cartaImage.Name = "cartaImage";
            this.cartaImage.Size = new System.Drawing.Size(216, 281);
            this.cartaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartaImage.TabIndex = 0;
            this.cartaImage.TabStop = false;
            // 
            // bancadaDealer
            // 
            this.bancadaDealer.Controls.Add(this.cartaImage);
            this.bancadaDealer.Location = new System.Drawing.Point(32, 12);
            this.bancadaDealer.Name = "bancadaDealer";
            this.bancadaDealer.Size = new System.Drawing.Size(890, 281);
            this.bancadaDealer.TabIndex = 1;
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(118)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1052, 554);
            this.Controls.Add(this.bancadaDealer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainProgram";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartaImage)).EndInit();
            this.bancadaDealer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox cartaImage;
        private Guna.UI2.WinForms.Guna2Panel bancadaDealer;
    }
}