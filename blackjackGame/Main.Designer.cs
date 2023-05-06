namespace blackjackGame
{
    partial class Main
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
            this.mesaCasa = new Guna.UI2.WinForms.Guna2Panel();
            this.mesaJogador = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStartGame = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPedirCarta = new Guna.UI2.WinForms.Guna2Button();
            this.btnEncerrar = new Guna.UI2.WinForms.Guna2Button();
            this.lblPontosdaCasa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPontosdoJogador = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWinner = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // mesaCasa
            // 
            this.mesaCasa.FillColor = System.Drawing.Color.Transparent;
            this.mesaCasa.Location = new System.Drawing.Point(212, 22);
            this.mesaCasa.Name = "mesaCasa";
            this.mesaCasa.Size = new System.Drawing.Size(1600, 300);
            this.mesaCasa.TabIndex = 0;
            // 
            // mesaJogador
            // 
            this.mesaJogador.FillColor = System.Drawing.Color.Transparent;
            this.mesaJogador.Location = new System.Drawing.Point(92, 546);
            this.mesaJogador.Name = "mesaJogador";
            this.mesaJogador.Size = new System.Drawing.Size(1600, 300);
            this.mesaJogador.TabIndex = 1;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartGame.FillColor = System.Drawing.Color.Lime;
            this.btnStartGame.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Black;
            this.btnStartGame.Location = new System.Drawing.Point(1000, 350);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStartGame.Size = new System.Drawing.Size(111, 79);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Iniciar";
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnPedirCarta
            // 
            this.btnPedirCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedirCarta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPedirCarta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPedirCarta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPedirCarta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPedirCarta.FillColor = System.Drawing.Color.DarkGreen;
            this.btnPedirCarta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPedirCarta.ForeColor = System.Drawing.Color.White;
            this.btnPedirCarta.Location = new System.Drawing.Point(1681, 600);
            this.btnPedirCarta.Name = "btnPedirCarta";
            this.btnPedirCarta.Size = new System.Drawing.Size(180, 45);
            this.btnPedirCarta.TabIndex = 5;
            this.btnPedirCarta.Text = "Pedir carta";
            this.btnPedirCarta.Click += new System.EventHandler(this.btnPedirCarta_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncerrar.FillColor = System.Drawing.Color.Red;
            this.btnEncerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncerrar.ForeColor = System.Drawing.Color.White;
            this.btnEncerrar.Location = new System.Drawing.Point(1681, 549);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(180, 45);
            this.btnEncerrar.TabIndex = 6;
            this.btnEncerrar.Text = "Encerrar jogada";
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblPontosdaCasa
            // 
            this.lblPontosdaCasa.BackColor = System.Drawing.Color.Transparent;
            this.lblPontosdaCasa.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosdaCasa.Location = new System.Drawing.Point(1443, 375);
            this.lblPontosdaCasa.Name = "lblPontosdaCasa";
            this.lblPontosdaCasa.Size = new System.Drawing.Size(118, 21);
            this.lblPontosdaCasa.TabIndex = 7;
            this.lblPontosdaCasa.Text = "guna2HtmlLabel1";
            // 
            // lblPontosdoJogador
            // 
            this.lblPontosdoJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblPontosdoJogador.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosdoJogador.Location = new System.Drawing.Point(1443, 408);
            this.lblPontosdoJogador.Name = "lblPontosdoJogador";
            this.lblPontosdoJogador.Size = new System.Drawing.Size(118, 21);
            this.lblPontosdoJogador.TabIndex = 8;
            this.lblPontosdoJogador.Text = "guna2HtmlLabel1";
            this.lblPontosdoJogador.Visible = false;
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(1443, 435);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(118, 21);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "guna2HtmlLabel1";
            this.lblWinner.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(118)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1980, 657);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblPontosdoJogador);
            this.Controls.Add(this.lblPontosdaCasa);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnPedirCarta);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.mesaJogador);
            this.Controls.Add(this.mesaCasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Panel mesaJogador;
        private Guna.UI2.WinForms.Guna2CircleButton btnStartGame;
        public Guna.UI2.WinForms.Guna2Panel mesaCasa;
        private Guna.UI2.WinForms.Guna2Button btnPedirCarta;
        private Guna.UI2.WinForms.Guna2Button btnEncerrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPontosdaCasa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPontosdoJogador;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWinner;
    }
}