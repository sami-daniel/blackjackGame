using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using EnvDTE;

namespace blackjackGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Deck();
        }
    }
    public class Deck
    {
        public List<Carta> CriarDeck()
        {
            List<Carta> deck = new List<Carta>();
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
            while(n > 1)
            {
                n--;
                int k = rnd.Next(n+1);
                T value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        private string[] Naipes()
        {
            string[] Naipe = { "paus", "copas", "espadas", "ouros" };
            return Naipe;
        }
        private string[] ValorCarta()
        {
            string[] ValorCarta = { "ás", "2", "3", "4", "5", "6", "7", "8", "9", "10", "valete", "dama", "rei" };
            return ValorCarta;
        }
        public sealed class Carta
        {
            //Propriedades da classe
            public string Naipe { get; private set; }
            public int Valor { get; private set; }
            public string CaminhoImagem { get; private set; }
            //Contrutor da classe Carta 
            public Carta(string naipe, string valor, string caminhoImagem)
            {
                Naipe = naipe;
                if (valor == "ás")
                {
                    Valor = 1;
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
    sealed class Game : Deck
    {   
        public void Deck()
        {
            CriarDeck();
        }
    }
}
