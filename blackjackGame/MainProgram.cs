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



        public void StartGame()
        {
           for (int i = 0; i < 7 ; i++)
            {
                AdicionarCarta("a",Baralho());
            }
           //teste
        }
        private void AdicionarCarta(string index,  Dictionary<int, string> baralho)
        {
            Random cartaAleatoria = new Random();
           
            //Parte da seleção aleatoria da carta do baralho
            int selecionaCarta = cartaAleatoria.Next(1, 13);
            AdicionarCartaImagem(baralho[selecionaCarta],"newCard");
        }
        //Metodo pra criar a imagem da carta e adicionar na mesa
        private void AdicionarCartaImagem(string imageLocation, string nomeCarta)
        {
            Guna2PictureBox novaCarta = new Guna2PictureBox();
            int i = 0;
            novaCarta.ImageLocation = imageLocation;
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
            //gira a imagem
            novaCarta.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            bancadaDealer.Controls.Add(novaCarta);
        }
        
        public Dictionary<int, string> Baralho()
        {
            Dictionary<int,string> baralho = new Dictionary<int,string>();
            for(int i = 1; i<13;i++)
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
