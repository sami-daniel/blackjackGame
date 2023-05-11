using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using EnvDTE;
using static blackjackGame.Deck;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Threading;
using System.Web.UI.WebControls;
using System.Runtime.CompilerServices;

namespace blackjackGame
{
    public partial class Main : Form
    {
        List<Carta> cartaListJogador = new List<Carta>();
        List<Carta> cartaListCasa = new List<Carta>();
        public bool PrimeiraCartaCasa = true;
        public Main()
        {
            InitializeComponent();
            Deck.DeckCreate();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.mesaCasa.Left = (this.ClientSize.Width - this.mesaCasa.Width) / 2;
            this.mesaCasa.Top = 155;


            this.mesaJogador.Left = (this.ClientSize.Width - this.mesaJogador.Width) / 2;
            this.mesaJogador.Top = (ClientSize.Height - this.mesaJogador.Height - 155);


            this.btnEncerrarJogada.Left = 25;
            this.btnPedirCarta.Left = 25;

            this.btnIniciar.Left = 900;
            this.btnIniciar.Top = 400;

            this.lblPontosCasa.Left = 25;
            this.lblPontosJogador.Left = 25;


            this.lblWinner.Left = 25;


            this.btnReiniciar.Left = 25;


            this.lblException.Left = 25;


            this.lblCrupie.Left = 250;
            this.lblCrupie.Top = 850;

            this.lblJogador.Left = 250;
            this.lblJogador.Top = 80;

            this.lblCrupie.Visible = false;
            this.lblJogador.Visible = false;
            this.lblPontosCasa.Visible = false;
            this.lblPontosJogador.Visible = false;
            this.btnReiniciar.Visible = false;
            this.lblException.Visible = false;
            this.lblWinner.Visible = false;
            this.mesaJogador.Visible = false;
            this.mesaCasa.Visible = false;
            this.btnEncerrarJogada.Visible = false;
            this.btnPedirCarta.Visible = false;
            //Algumas propriedades de formatação dos elementos do formulario  


        }
        //Metodos para a criaçao das cartas
        private void CriaCartaJogador()
        {
            Carta cartaJogador = Game.PegarCartaJogador(ref deck, lblPontosJogador, lblException);
            AdicionarCartaJogador(cartaJogador);
            TesteJogador();
            cartaListJogador.Add(cartaJogador);
        }
        private void CriaCartaCasa()
        {
            Carta cartaCasa = Game.PegarCartaCasa(ref deck, lblPontosCasa, lblException);
            AdicionarCartaCasa(cartaCasa);
            TesteCasa();
            cartaListCasa.Add(cartaCasa);
        }
        //Metodo de inicio(Não utilizado os metódos acima por que alguns testes nao podem ser feitos da mesma maneira)
        private void StartGame()
        {
            Carta cartaCasa = Game.PegarCartaCasa(ref deck, lblPontosCasa, lblException);
            AdicionarCartaCasa(cartaCasa);
            Carta cartaCasa1 = Game.PegarCartaCasa(ref deck, lblPontosCasa, lblException);
            AdicionarCartaCasa(cartaCasa1);
            cartaListCasa.Add(cartaCasa);
            cartaListCasa.Add(cartaCasa1);


            Carta cartaJogador = Game.PegarCartaJogador(ref deck, lblPontosJogador, lblException);
            AdicionarCartaJogador(cartaJogador);
            Carta cartajogador1 = Game.PegarCartaJogador(ref deck, lblPontosJogador, lblException);
            AdicionarCartaJogador(cartajogador1);
            cartaListJogador.Add(cartaJogador);
            cartaListJogador.Add(cartajogador1);


            if (Game.pontosCasa == 21)
            {
                btnEncerrarJogada.Hide();
                btnPedirCarta.Hide();
                lblWinner.Show();
                lblWinner.Text = "Vencedor: Casa";
                this.btnReiniciar.Visible = true;
                this.lblPontosCasa.Visible = true;
                this.lblPontosJogador.Visible = true;
                MostrarCartasCompletasCasa();
            }

            else if (Game.pontosPlayer == 21)
            {
                btnEncerrarJogada.Hide();
                btnPedirCarta.Hide();
                lblWinner.Show();
                lblWinner.Text = "Vencedor: Jogador";
                this.btnReiniciar.Visible = true;
                this.lblPontosCasa.Visible = true;
                this.lblPontosJogador.Visible = true;
                MostrarCartasCompletasCasa();
            }

        }
        //Testa se o jogador perdeu ou ganhou
        private void TesteJogador()
        {
            if (Game.pontosPlayer > 21)
            {
                foreach (Carta carta in cartaListJogador)
                {
                    if (carta.Valor == 11)
                    {
                        Game.pontosPlayer -= 10;
                        carta.Valor = 1;
                        break;
                    }
                    else
                    {
                        btnEncerrarJogada.Hide();
                        btnPedirCarta.Hide();
                        lblWinner.Show();
                        lblWinner.Text = "Vencedor: Casa";
                        this.btnReiniciar.Visible = true;
                        this.lblPontosCasa.Visible = true;
                        this.lblPontosJogador.Visible = true;
                        MostrarCartasCompletasCasa();
                    }
                }
            }
            else if (Game.pontosPlayer == 21)
            {
                btnEncerrarJogada.Hide();
                btnPedirCarta.Hide();
                lblWinner.Show();
                lblWinner.Text = "Vencedor: Jogador";
                this.btnReiniciar.Visible = true;
                this.lblPontosCasa.Visible = true;
                this.lblPontosJogador.Visible = true;
                MostrarCartasCompletasCasa();
            }
        }
        //testa se a casa ganhou ou perdeu
        private void TesteCasa()
        {
            if (Game.pontosCasa < 21 && Game.pontosCasa > Game.pontosPlayer)
            {
                btnEncerrarJogada.Hide();
                btnPedirCarta.Hide();
                lblWinner.Show();
                lblWinner.Text = "Vencedor: Casa";
                this.btnReiniciar.Visible = true;
                this.lblPontosCasa.Visible = true;
                this.lblPontosJogador.Visible = true;
                MostrarCartasCompletasCasa();
            }
            if (Game.pontosCasa > 21)
            {
                foreach (Carta carta in cartaListCasa)
                {
                    if (carta.Valor == 11)
                    {
                        Game.pontosCasa -= 10;
                        carta.Valor = 1;
                        break;
                    }
                    else
                    {
                        btnEncerrarJogada.Hide();
                        btnPedirCarta.Hide();
                        lblWinner.Show();
                        lblWinner.Text = "Vencedor: Jogador";
                        this.btnReiniciar.Visible = true;
                        this.lblPontosCasa.Visible = true;
                        this.lblPontosJogador.Visible = true;
                        MostrarCartasCompletasCasa();
                    }
                }
            }
            if (Game.pontosCasa == 21)
            {
                btnEncerrarJogada.Hide();
                btnPedirCarta.Hide();
                lblWinner.Show();
                lblWinner.Text = "Vencedor: Casa";
                this.btnReiniciar.Visible = true;
                this.lblPontosCasa.Visible = true;
                this.lblPontosJogador.Visible = true;
                MostrarCartasCompletasCasa();
            }
        }



        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            mesaCasa.Visible = true;
            mesaJogador.Visible = true;
            btnEncerrarJogada.Visible = true;
            btnPedirCarta.Visible = true;
            lblCrupie.Visible = true;
            lblJogador.Visible=true;
            StartGame();
        }


        private void BtnPedirCarta_Click(object sender, EventArgs e)
        {
            CriaCartaJogador();
        }


        private void btnEncerrarJogada_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Game.pontosCasa > 17 && Game.pontosCasa > Game.pontosPlayer)
            {
                btnEncerrarJogada.Hide();
                btnPedirCarta.Hide();
                lblWinner.Show();
                lblWinner.Text = "Vencedor: Casa";
                this.btnReiniciar.Visible = true;
                this.lblPontosCasa.Visible = true;
                this.lblPontosJogador.Visible = true;
                MostrarCartasCompletasCasa();
            }
            if(Game.pontosCasa > 17 && Game.pontosCasa < 21)
            {
                if(Game.pontosCasa > Game.pontosPlayer)
                {
                    btnEncerrarJogada.Hide();
                    btnPedirCarta.Hide();
                    lblWinner.Show();
                    lblWinner.Text = "Vencedor: Casa";
                    this.btnReiniciar.Visible = true;
                    this.lblPontosCasa.Visible = true;
                    this.lblPontosJogador.Visible = true;
                    MostrarCartasCompletasCasa();
                }
                else if(Game.pontosPlayer < Game.pontosCasa)
                {
                    btnEncerrarJogada.Hide();
                    btnPedirCarta.Hide();
                    lblWinner.Show();
                    lblWinner.Text = "Vencedor: Jogador";
                    this.btnReiniciar.Visible = true;
                    this.lblPontosCasa.Visible = true;
                    this.lblPontosJogador.Visible = true;
                    MostrarCartasCompletasCasa();
                } 
            }
            while (i != 7 && Game.pontosCasa < 17)
            {
                i = mesaCasa.Controls.Count;
                CriaCartaCasa();
                if (Game.pontosCasa >= 17 && Game.pontosCasa > Game.pontosPlayer)
                {
                    lblWinner.Text = "Vencedor: Casa";
                    btnEncerrarJogada.Hide();
                    btnPedirCarta.Hide();
                    lblWinner.Show();
                    this.btnReiniciar.Visible = true;
                    this.lblPontosCasa.Visible = true;
                    this.lblPontosJogador.Visible = true;
                    MostrarCartasCompletasCasa();
                    break;
                }
            }
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Encerrar o aplicativo e reiniciar a partir da segunda tela
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
        private void MostrarCartasCompletasCasa()
        {
            mesaCasa.Controls.Clear();
            foreach (Carta obj in cartaListCasa)
            {
                Guna2PictureBox Carta = new Guna2PictureBox();
                int i = mesaCasa.Controls.Count;
                Carta.Size = new Size(200, 300);
                Carta.SizeMode = PictureBoxSizeMode.Zoom;
                Carta.ImageLocation = obj.CaminhoImagem;
                Carta.Location = new Point(i * 200, 0);
                mesaCasa.Controls.Add(Carta);
            }
        }
        //Adiciona a parte grafica da imagem da carta do jogador
        private void AdicionarCartaJogador(Carta carta)
        {
            Guna2PictureBox Carta = new Guna2PictureBox();
            int i = mesaJogador.Controls.Count;
            Carta.Width = 200;
            Carta.Height = 300;
            Carta.SizeMode = PictureBoxSizeMode.Zoom;
            Carta.ImageLocation = carta.CaminhoImagem;
            Carta.Location = new Point(i * 200, 0);
            mesaJogador.Controls.Add(Carta);
        }

        //Adiciona a parte grafica da imagem da carta da Casa
        private void AdicionarCartaCasa(Carta carta)
        {
            Guna2PictureBox Carta = new Guna2PictureBox();
            int i = mesaCasa.Controls.Count;
            Carta.Width = 200;
            Carta.Height = 300;
            Carta.SizeMode = PictureBoxSizeMode.Zoom;
            if (PrimeiraCartaCasa)
            {
                Carta.ImageLocation = "C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho\\ParteDeTras.png";
                PrimeiraCartaCasa = false;
            }
            else
            {
                Carta.ImageLocation = carta.CaminhoImagem;
            }
            Carta.Location = new Point(i * Carta.Width, 0);
            mesaCasa.Controls.Add(Carta);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }


    public class Deck
    {
        public static List<Carta> deck = new List<Carta>();
        public static List<Carta> DeckCreate()
        {
            //Detecta a pasta onde a solução SLN está
            DTE dte = (DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            Solution solution = dte.Solution;

            string caminhoSln = solution.FileName;
            string diretorioSln = Path.GetDirectoryName(caminhoSln) + @"\Assets\Baralho\";
            //Armazena os objetos na lista do tipo Carta
            foreach (string naipe in Naipes())
            {
                foreach (string valor in ValorCarta())
                {
                    string nomeImagem = $"{valor.ToString().ToLower()}_de_{naipe.ToString().ToLower()}.png";
                    string caminhoImagem = Path.Combine(diretorioSln, nomeImagem);
                    deck.Add(new Carta(naipe, valor, caminhoImagem));
                }
            }
            Embaralhar(ref deck);
            //Retorna o baralho
            return deck;
        }

        private static void Embaralhar<T>(ref List<T> deck)
        {
            ///<summary>
            ///Este metódo embaralha a lista (sempre Deck) passada como referencia.
            ///Utiliza o algoritimo Fisher-Yates para aleatorizar os elementos da lista.
            ///Para obter mais informações, consulte https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
            ///</summary>

            Random rnd = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }


        private static string[] Naipes()
        {
            string[] Naipe = { "paus", "copas", "espadas", "ouros" };
            return Naipe;
        }


        private static string[] ValorCarta()
        {
            string[] ValorCarta = { "ás", "2", "3", "4", "5", "6", "7", "8", "9", "10", "valete", "dama", "rei" };
            return ValorCarta;
        }


        public sealed class Carta
        {
            //Propriedades da classe
            public string Naipe { get; private set; }


            public int Valor { get; set; }


            public string CaminhoImagem { get; private set; }
            //Contrutor da classe Carta 


            public Carta(string naipe, string valor, string caminhoImagem)
            {
                Naipe = naipe;
                if (valor == "ás")
                {
                    Valor = 11;
                }
                else if (valor == "valete")
                {
                    Valor = 10;
                }
                else if (valor == "dama")
                {
                    Valor = 10;
                }
                else if (valor == "rei")
                {
                    Valor = 10;
                }
                else
                {
                    Valor = Convert.ToInt32(valor);
                }
                CaminhoImagem = caminhoImagem;
            }

        }
    }


    public sealed class Game : Main
    {
        public static int pontosPlayer = 0;
        public static int pontosCasa = 0;

        //Retira a carta do baralho e retorna-a para o metódo que requisitou(Player)
        public static Carta PegarCartaJogador(ref List<Carta> deck, Guna2HtmlLabel lbl, Guna2HtmlLabel lblEx)
        {
            Random rnd = new Random();
            int indexAleatorio = rnd.Next(deck.Count);
            Carta carta = deck[indexAleatorio];
            deck.RemoveAt(indexAleatorio);
            pontosPlayer += carta.Valor;
            lbl.Text = $"Pontos do jogador: {pontosPlayer}";
            return carta;
        }

        //Retira a carta do baralho e retorna-a para o metódo que requisitou(Casa)
        public static Carta PegarCartaCasa(ref List<Carta> deck, Guna2HtmlLabel lbl, Guna2HtmlLabel lblEx)
        {
            Random rnd = new Random();
            int indexAleatorio = rnd.Next(deck.Count);
            Carta carta = deck[indexAleatorio];
            deck.RemoveAt(indexAleatorio);
            pontosCasa += carta.Valor;
            lbl.Text = $"Pontos da casa: {pontosCasa}";
            return carta;
        }


    }
}
