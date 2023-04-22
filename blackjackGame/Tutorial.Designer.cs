namespace blackjackGame
{
    partial class Tutorial
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
            this.btnVoltar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NavegadorWeb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(35, 57);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "↺";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // NavegadorWeb
            // 
            this.NavegadorWeb.AllowNavigation = false;
            this.NavegadorWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavegadorWeb.Location = new System.Drawing.Point(0, 0);
            this.NavegadorWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.NavegadorWeb.Name = "NavegadorWeb";
            this.NavegadorWeb.Size = new System.Drawing.Size(1202, 625);
            this.NavegadorWeb.TabIndex = 4;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1202, 625);
            this.Controls.Add(this.NavegadorWeb);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Tutorial";
            this.ShowIcon = false;
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.Tutorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel btnVoltar;
        private System.Windows.Forms.WebBrowser NavegadorWeb;
    }
}