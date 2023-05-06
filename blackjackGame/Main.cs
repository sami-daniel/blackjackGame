using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace blackjackGame
{
    public partial class Main : Form
    {
        public static List<string> cartasUsadasD = new List<string>();
        Random rnd = new Random();
        public static int pontosCasa = 0;
        public static int pontosJogador = 0;
        public static bool TemAs = false;
        public static bool EaPrimeiraCartaDoDealer = true;
        public static bool vencedorD = false;
        public static bool vencedorP = false;
        
        public Main()
        {
            InitializeComponent();
           
        }
      
        private void Main_Load(object sender, EventArgs e)
        {
            this.Width = 2000;
            this.Height = 900;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.mesaCasa.Left = (this.ClientSize.Width - this.mesaCasa.Width) / 2;
            this.mesaCasa.Top = 25;
            this.mesaCasa.BackColor = Color.Transparent;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.mesaJogador.Left = (this.ClientSize.Width - this.mesaJogador.Width) / 2;
            this.mesaJogador.Top = (ClientSize.Height - this.mesaJogador.Height - 25);
            this.mesaJogador.BackColor = Color.Transparent;
            this.mesaJogador.Visible = false;
            this.mesaCasa.Visible = false;
            this.btnStartGame.Location = new Point(ClientSize.Width / 2,ClientSize.Height/2) ;
            this.btnPedirCarta.Hide();
            this.btnPedirCarta.Location = new Point(ClientSize.Width - 2 * btnPedirCarta.Width);
            this.btnPedirCarta.Top = ClientSize.Height - 75;
            this.btnEncerrar.Hide();
            this.btnEncerrar.Location = new Point(ClientSize.Width - 2 * btnPedirCarta.Width);
            this.btnEncerrar.Top = ClientSize.Height - 75 - btnEncerrar.Height;
            this.lblPontosdaCasa.Hide();
            this.lblPontosdoJogador.Hide();
            this.lblWinner.Hide();
        }
       

        public void StartGame()
        {
            NovaCarta(mesaCasa,Baralho(),rnd.Next(1,13),0, mesaCasa);
            NovaCarta(mesaCasa, Baralho(), rnd.Next(1, 13), 0,mesaCasa);
            Thread.Sleep(1000);
            btnPedirCarta.Visible = true;
        }
        public static PictureBox NovaCarta(Guna2Panel mesa, Dictionary<int,string> Baralho1, int NewCardAleatorio, int index, Guna2Panel mesaD)
        {
            Debug.Assert(!(index != 0) || !(index != 1), "Index invalído");
            PictureBox novaCarta = new PictureBox();
            Main form = new Main();
            int i = 0;
            novaCarta.Size = new System.Drawing.Size(200,300);
            foreach (Control elemento in mesa.Controls) {i++;}
            novaCarta.Location = new System.Drawing.Point(i * 200, 0);
            novaCarta.SizeMode = PictureBoxSizeMode.Zoom;
            if (EaPrimeiraCartaDoDealer && index == 0)
            {
                novaCarta.ImageLocation = "C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\partedetrasdacarta.png";
                cartasUsadasD.Add(Baralho1[NewCardAleatorio]);
                EaPrimeiraCartaDoDealer = false;
                if(NewCardAleatorio == 10)
                {
                    pontosCasa += 10;
                }
                else if (NewCardAleatorio == 11)
                {
                    pontosCasa +=10;
                }
                else if (NewCardAleatorio == 12)
                {
                    pontosCasa += 10;
                }
                else
                {
                    pontosCasa += NewCardAleatorio;
                }
            }
            else if(index == 0)
            {
                novaCarta.ImageLocation = Baralho1[NewCardAleatorio];
                cartasUsadasD.Add(Baralho1[NewCardAleatorio]);
               
                if (NewCardAleatorio == 10)
                {
                    pontosCasa += 10;
                }
                else if (NewCardAleatorio == 11)
                {
                    pontosCasa += 10;
                }
                else if (NewCardAleatorio == 12)
                {
                    pontosCasa += 10;
                }
                else if (NewCardAleatorio == 0)
                {
                    pontosCasa += 11;
                    TemAs = true;
                }
                else
                {
                    pontosCasa += NewCardAleatorio;
                }
                if (index == 0 && TemAs && pontosCasa > 21)
                {
                    pontosCasa -= 11;
                    pontosCasa += 1;
                    TemAs = false;
                }
            }
            else if(index == 1)
            {
                novaCarta.ImageLocation = Baralho1[NewCardAleatorio];
                if (NewCardAleatorio == 10)
                {
                    pontosJogador += 10;
                }
                else if (NewCardAleatorio == 11)
                {
                    pontosJogador += 10;
                }
                else if (NewCardAleatorio == 12)
                {
                    pontosJogador += 10;
                }
                else if (NewCardAleatorio == 0)
                {
                    pontosJogador += 11;
                    TemAs = true;
                }
                else
                {
                    pontosJogador += NewCardAleatorio;
                }
                if (index == 1 && TemAs && pontosJogador > 21)
                {
                    pontosJogador -= 11;
                    pontosJogador += 1;
                    TemAs = false;
                }
            }
            
            mesa.Controls.Add(novaCarta);
            if(pontosCasa >= 21 || pontosJogador >= 21)
            {
                FimDeJogo(mesaD,form.lblPontosdoJogador);
                form.btnPedirCarta.Hide();
                form.btnEncerrar.Hide();    
            }
            return novaCarta;
        }
        
        public static Dictionary<int, string> Baralho()
        {
            Dictionary<int,string> baralho = new Dictionary<int,string>();
            for(int i = 1; i <= 13; i++)
            {
                if (i == 11)
                {
                    baralho.Add(i, "C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\q_de_copas.png");
                }
                else if (i == 12)
                {
                    baralho.Add(i, "C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\j_de_copas.png");
                }
                else if (i == 13)
                {
                    baralho.Add(i, "C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\k_de_copas.png");
                }
                else
                {
                    baralho.Add(i, $"C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\{i}_de_copas.png");
                }
            }
            return baralho;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
            btnStartGame.Enabled = false;
            btnStartGame.Visible = false;
            btnEncerrar.Visible = true;
            mesaCasa.Visible = true;
            mesaJogador.Visible = true;
            btnPedirCarta.Visible = true;
        }
        public static void FimDeJogo(Guna2Panel mesaD,Guna2HtmlLabel lbl)
        {
            Main form = new Main();
            
            if (pontosCasa > 21)
            {
                form.lblPontosdoJogador.Text = $"Pontos do jogador: {form.lblPontosdoJogador}";
                form.lblPontosdaCasa.Text = $"Pontos da casa: {form.lblPontosdaCasa}";
                form.lblWinner.Text = "Jogador venceu";
                form.btnEncerrar.Hide();
                form.btnStartGame.Hide();
                form.lblPontosdoJogador.Show();
                form.lblPontosdaCasa.Show();
                form.lblWinner.Show();
            }
            else if(pontosJogador > 21)
            {
                lbl.Show();
                form.lblPontosdoJogador.Text = $"Pontos do jogador: {form.lblPontosdoJogador}";
                form.lblPontosdaCasa.Text = $"Pontos da casa: {form.lblPontosdaCasa}";
                form.lblWinner.Text = "Casa venceu";
                form.btnEncerrar.Hide();
                form.btnStartGame.Hide();
                form.lblPontosdoJogador.Show();
                form.lblPontosdaCasa.Show();
                form.lblWinner.Show();
            }
            else if (pontosJogador == 21)
            {
                form.lblPontosdoJogador.Text = $"Pontos do jogador: {form.lblPontosdoJogador}";
                form.lblPontosdaCasa.Text = $"Pontos da casa: {form.lblPontosdaCasa}";
                form.lblWinner.Text = "Casa venceu";
                form.btnEncerrar.Hide();
                form.btnStartGame.Hide();
                form.lblPontosdoJogador.Show();
                form.lblPontosdaCasa.Show();
                form.lblWinner.Show();
            }
            else if (pontosCasa == 21)
            {
                form.lblPontosdoJogador.Text = $"Pontos do jogador: {form.lblPontosdoJogador}";
                form.lblPontosdaCasa.Text = $"Pontos da casa: {form.lblPontosdaCasa}";
                form.lblWinner.Text = "Casa venceu";
                form.btnEncerrar.Hide();
                form.btnStartGame.Hide();
                form.lblPontosdoJogador.Show();
                form.lblPontosdaCasa.Show();
                form.lblWinner.Show();
            }
            else if (pontosCasa == 21 && pontosJogador == 21)
            {
                form.lblPontosdoJogador.Text = $"Pontos do jogador: {form.lblPontosdoJogador}";
                form.lblPontosdaCasa.Text = $"Pontos da casa: {form.lblPontosdaCasa}";
                form.lblWinner.Text = "Empate";
               
                form.btnStartGame.Hide();
                form.lblPontosdoJogador.Show();
                form.lblPontosdaCasa.Show();
                form.lblWinner.Show();
            }
            mesaD.Controls.Clear();
            for (int x = 0; x < cartasUsadasD.Count; x++)
            {
                PictureBox cartaD = new PictureBox();
                cartaD.Width = 200;
                cartaD.Height = 300;
                cartaD.SizeMode = PictureBoxSizeMode.Zoom;
                int y = 0;
                foreach (Control elemento in mesaD.Controls) { y++; }
                cartaD.Location = new Point(y * 200, 0);
                cartaD.ImageLocation = cartasUsadasD[x];
                mesaD.Controls.Add(cartaD);
            }
        }
        private void btnPedirCarta_Click(object sender, EventArgs e)
        {
            NovaCarta(mesaJogador,Baralho(),rnd.Next(1,13),1, mesaCasa);
            if(mesaJogador.Controls.Count == 7)
            {
                btnPedirCarta.Visible = false;
            }
        }
        
        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            JogadaCasa();
            btnPedirCarta.Hide();
            btnEncerrar.Visible = false;
            btnPedirCarta.Hide();
        }
        private void JogadaCasa()
        {
            while(mesaCasa.Controls.Count != 7 || pontosCasa <= 19)
            {
                NovaCarta(mesaCasa, Baralho(), rnd.Next(1, 13), 0, mesaCasa);
            }
        }
    }
}
