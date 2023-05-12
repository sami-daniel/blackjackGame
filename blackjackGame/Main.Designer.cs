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
            this.btnPedirCarta = new Guna.UI2.WinForms.Guna2Button();
            this.btnIniciar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblPontosJogador = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPontosCasa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWinner = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblException = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReiniciar = new Guna.UI2.WinForms.Guna2Button();
            this.lblCrupie = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblJogador = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEncerra = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // mesaCasa
            // 
            this.mesaCasa.BackColor = System.Drawing.Color.Transparent;
            this.mesaCasa.BorderColor = System.Drawing.Color.Black;
            this.mesaCasa.BorderRadius = 8;
            this.mesaCasa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.mesaCasa.BorderThickness = 2;
            this.mesaCasa.Location = new System.Drawing.Point(81, 26);
            this.mesaCasa.Name = "mesaCasa";
            this.mesaCasa.Size = new System.Drawing.Size(1400, 300);
            this.mesaCasa.TabIndex = 0;
            // 
            // mesaJogador
            // 
            this.mesaJogador.BackColor = System.Drawing.Color.Transparent;
            this.mesaJogador.BorderColor = System.Drawing.Color.Black;
            this.mesaJogador.BorderRadius = 8;
            this.mesaJogador.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.mesaJogador.BorderThickness = 2;
            this.mesaJogador.Location = new System.Drawing.Point(81, 332);
            this.mesaJogador.Name = "mesaJogador";
            this.mesaJogador.Size = new System.Drawing.Size(1400, 300);
            this.mesaJogador.TabIndex = 1;
            this.mesaJogador.Visible = false;
            // 
            // btnPedirCarta
            // 
            this.btnPedirCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedirCarta.BorderRadius = 8;
            this.btnPedirCarta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPedirCarta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPedirCarta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPedirCarta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPedirCarta.FillColor = System.Drawing.Color.Lime;
            this.btnPedirCarta.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedirCarta.ForeColor = System.Drawing.Color.Black;
            this.btnPedirCarta.Location = new System.Drawing.Point(1552, 536);
            this.btnPedirCarta.Name = "btnPedirCarta";
            this.btnPedirCarta.Size = new System.Drawing.Size(138, 45);
            this.btnPedirCarta.TabIndex = 3;
            this.btnPedirCarta.Text = "Pedir Carta";
            this.btnPedirCarta.Click += new System.EventHandler(this.BtnPedirCarta_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniciar.FillColor = System.Drawing.Color.Lime;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(747, 237);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnIniciar.Size = new System.Drawing.Size(250, 146);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Start Game";
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // lblPontosJogador
            // 
            this.lblPontosJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblPontosJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosJogador.Location = new System.Drawing.Point(33, 176);
            this.lblPontosJogador.Name = "lblPontosJogador";
            this.lblPontosJogador.Size = new System.Drawing.Size(154, 22);
            this.lblPontosJogador.TabIndex = 5;
            this.lblPontosJogador.Text = "Pontos do jogador: ";
            // 
            // lblPontosCasa
            // 
            this.lblPontosCasa.BackColor = System.Drawing.Color.Transparent;
            this.lblPontosCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontosCasa.Location = new System.Drawing.Point(33, 148);
            this.lblPontosCasa.Name = "lblPontosCasa";
            this.lblPontosCasa.Size = new System.Drawing.Size(132, 22);
            this.lblPontosCasa.TabIndex = 6;
            this.lblPontosCasa.Text = "Pontos da casa: ";
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(33, 204);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(85, 22);
            this.lblWinner.TabIndex = 7;
            this.lblWinner.Text = "Vencedor: ";
            // 
            // lblException
            // 
            this.lblException.BackColor = System.Drawing.Color.Transparent;
            this.lblException.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblException.Location = new System.Drawing.Point(33, 232);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(3, 2);
            this.lblException.TabIndex = 8;
            this.lblException.Text = null;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.BorderRadius = 8;
            this.btnReiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReiniciar.FillColor = System.Drawing.Color.Lime;
            this.btnReiniciar.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.Black;
            this.btnReiniciar.Location = new System.Drawing.Point(1552, 485);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(138, 45);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblCrupie
            // 
            this.lblCrupie.BackColor = System.Drawing.Color.Transparent;
            this.lblCrupie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrupie.Location = new System.Drawing.Point(122, 12);
            this.lblCrupie.Name = "lblCrupie";
            this.lblCrupie.Size = new System.Drawing.Size(69, 22);
            this.lblCrupie.TabIndex = 10;
            this.lblCrupie.Text = "Crupie ↑";
            // 
            // lblJogador
            // 
            this.lblJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(101, 638);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(80, 22);
            this.lblJogador.TabIndex = 11;
            this.lblJogador.Text = "Jogador  ↧";
            // 
            // btnEncerra
            // 
            this.btnEncerra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerra.BorderRadius = 8;
            this.btnEncerra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncerra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncerra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncerra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncerra.FillColor = System.Drawing.Color.Red;
            this.btnEncerra.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerra.ForeColor = System.Drawing.Color.Black;
            this.btnEncerra.Location = new System.Drawing.Point(1552, 587);
            this.btnEncerra.Name = "btnEncerra";
            this.btnEncerra.Size = new System.Drawing.Size(138, 45);
            this.btnEncerra.TabIndex = 12;
            this.btnEncerra.Text = "Encerrar Jogada";
            this.btnEncerra.Click += new System.EventHandler(this.btnEncerra_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(118)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1980, 957);
            this.Controls.Add(this.btnEncerra);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.lblCrupie);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.lblPontosJogador);
            this.Controls.Add(this.lblPontosCasa);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnPedirCarta);
            this.Controls.Add(this.mesaJogador);
            this.Controls.Add(this.mesaCasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BlackJack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mesaCasa;
        private Guna.UI2.WinForms.Guna2Panel mesaJogador;
        private Guna.UI2.WinForms.Guna2Button btnPedirCarta;
        private Guna.UI2.WinForms.Guna2CircleButton btnIniciar;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblPontosJogador;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblPontosCasa;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblWinner;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblException;
        private Guna.UI2.WinForms.Guna2Button btnReiniciar;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblCrupie;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJogador;
        private Guna.UI2.WinForms.Guna2Button btnEncerra;
    }
}