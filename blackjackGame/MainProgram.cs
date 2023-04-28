using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
            this.Width = 1200;
            this.Height = 900;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            //baralho
            
        }
        private void StartGame()
        {
            int pontosDealer = 0;
            int pontosJogador = 0;
            int valueCard;
            Dictionary<int, string> Baralho = new Dictionary<int, string>();
            for (int i = 1; i < 13; i++)
            {
                Baralho.Add(i, $"C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\{i}_de_copas.png");
            }
            
            //Da a 1 cartas iniciais ao dealer
            Random cartaAleatorio = new Random();
            int carta1 = cartaAleatorio.Next(1,13);
            if(carta1 == 11)
            {
                valueCard = 10;
                cartaImage.ImageLocation = Baralho[11];
                pontosDealer += valueCard;
            }
            else if(carta1 == 12)
            {
                valueCard = 10;
                cartaImage.ImageLocation = Baralho[12];
                pontosDealer += valueCard;
            }
            else if (carta1 == 13) 
            {
                valueCard = 10;
                cartaImage.ImageLocation= Baralho[13];
                pontosDealer += valueCard;
            }
            else
            {
                valueCard = carta1;
                cartaImage.ImageLocation = Baralho[carta1];
                pontosDealer += valueCard;
            }
            
        }
    }
}
