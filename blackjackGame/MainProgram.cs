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

namespace blackjackGame
{
    public partial class MainProgram : Form
    {
        private List<string> cartasNaBancada = new List<string>();
        private int pontosDaCasa;
        private int PontosDoJogador;
        bool TemAs;
        public MainProgram()
        {
            InitializeComponent();
            StartGame();
        }
        private void MainProgram_Load(object sender, EventArgs e)
        {
            this.Width = 1600;
            this.Height = 900;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.bancadaDealer.Left = (this.ClientSize.Width - this.bancadaDealer.Width) / 2;
            this.bancadaDealer.Top = 25;
            //Configuraçoes da tela do jogo, somente estetico
        }
        
        private void StartGame()
        {
            AdicionarCarta(true, 1, Baralho());
            for (int i = 0; i < 4; i++)
            {
                AdicionarCarta(false, 1, Baralho());
            }
        }
        private void AdicionarCarta(bool IsFirstCard,int index,  Dictionary<int, string> Baralho)
        {
            Random cartaAleatoria = new Random();
            //Parte da seleção aleatoria da carta do baralho
            int selecionarCarta = cartaAleatoria.Next(1, 13);
            if(selecionarCarta == 1)
            {
                TemAs = true;
            }
            
            AdicionarCartaImagem(IsFirstCard,Baralho[selecionarCarta],"newCard",Baralho,selecionarCarta);
            if (index == 1)
            {
                if (selecionarCarta == 11)
                {
                    pontosDaCasa += 10;
                }
                else if (selecionarCarta == 12)
                {
                    pontosDaCasa += 10;
                }
                else if(selecionarCarta == 13)
                {
                    pontosDaCasa += 10;
                }
                else if (selecionarCarta == 1)
                {
                    pontosDaCasa += 11;
                }
                else
                {
                    pontosDaCasa += selecionarCarta;
                }
                if(pontosDaCasa > 21 && TemAs == true)
                {
                    pontosDaCasa -= 11;
                    pontosDaCasa += 1;
                }
                if(pontosDaCasa > 21 && TemAs == false)
                {
                    FimDoJogo();
                }
                guna2HtmlLabel1.Text = pontosDaCasa.ToString();
            }
        }

        //Metodo pra criar a imagem da carta e adicionar na mesa
        private void AdicionarCartaImagem(bool isFirstCard, string imageLocation, string nomeCarta, Dictionary<int, string> Baralho,int rnd)
        {
            Guna2PictureBox novaCarta = new Guna2PictureBox();
            int i = 0;
            if (isFirstCard)
            {
                novaCarta.ImageLocation = @"C:\Users\Sami\Projetos\blackjackGame\blackjackGame\Assets\Baralho\partedetrasdacarta.png";
                novaCarta.Name = "cartaVirada";
                cartasNaBancada.Add(imageLocation);
            }
            else
            {
               novaCarta.ImageLocation= imageLocation;
                cartasNaBancada.Add(imageLocation);
            }
            novaCarta.Width = 200;
            novaCarta.Height = 300;
            foreach (Control elemento in bancadaDealer.Controls)
            {
                i++;
            }
            novaCarta.Location = new Point(i * 200, 0);
            novaCarta.Name = nomeCarta;
            novaCarta.FillColor = Color.Transparent;
            novaCarta.SizeMode = PictureBoxSizeMode.Zoom;
            bancadaDealer.Controls.Add(novaCarta);
        }
        private void FimDoJogo()
        {
            foreach(Control elemento in bancadaDealer.Controls)
            {
                bancadaDealer.Controls.Remove(elemento);
                elemento.Dispose();
            }
        }
        private Dictionary<int, string> Baralho()
        {
            Dictionary<int,string> baralho = new Dictionary<int,string>();
            for(int i = 1; i<=13;i++)
            {
                if (i == 11)
                {
                    baralho.Add(i, $"C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\j_de_copas.png");
                }
                else if(i == 12)
                {
                    baralho.Add(i, $"C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\k_de_copas.png");
                }
                else if(i == 13)
                {
                    baralho.Add(i, $"C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\q_de_copas.png");
                }
                else
                {
                    baralho.Add(i, $"C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\{i}_de_copas.png");
                }
            }
            return baralho;
        }
    }
}
