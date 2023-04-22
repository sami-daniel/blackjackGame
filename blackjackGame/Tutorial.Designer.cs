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
            this.textTutorial = new Guna.UI2.WinForms.Guna2TextBox();
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
            // textTutorial
            // 
            this.textTutorial.BackColor = System.Drawing.Color.Black;
            this.textTutorial.BorderColor = System.Drawing.Color.White;
            this.textTutorial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTutorial.DefaultText = "";
            this.textTutorial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTutorial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTutorial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTutorial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTutorial.FillColor = System.Drawing.Color.Black;
            this.textTutorial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTutorial.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.textTutorial.ForeColor = System.Drawing.Color.Red;
            this.textTutorial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTutorial.Location = new System.Drawing.Point(12, 92);
            this.textTutorial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textTutorial.Name = "textTutorial";
            this.textTutorial.PasswordChar = '\0';
            this.textTutorial.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textTutorial.PlaceholderText = "";
            this.textTutorial.SelectedText = "";
            this.textTutorial.Size = new System.Drawing.Size(286, 35);
            this.textTutorial.TabIndex = 1;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1202, 625);
            this.Controls.Add(this.textTutorial);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Tutorial";
            this.ShowIcon = false;
            this.Text = "Tutorial";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel btnVoltar;
        private Guna.UI2.WinForms.Guna2TextBox textTutorial;
    }
}