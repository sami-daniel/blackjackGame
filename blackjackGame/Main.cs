﻿using Guna.UI2.WinForms;
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
using System.IO;

namespace blackjackGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Deck deck = new Deck();
            deck.CriarDeck();
        }

    }
    public class Deck
    {
        public List<Carta> CriarDeck()
        {
            List<Carta> deck = new List<Carta>();
            string pastaImagem = "C:\\Users\\Sami\\Projetos\\blackjackGame\\blackjackGame\\Assets\\Baralho";
            foreach (string naipe in Naipes())
            {
                foreach (string valor in ValorCarta())
                {
                    string nomeImagem = $"{valor.ToString().ToLower()}_de_{naipe.ToString().ToLower()}.png";
                    string caminhoImagem = Path.Combine(pastaImagem, nomeImagem);

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
            string[] Naipe = { "Paus", "Copas", "Espadas", "Ouros" };
    
            return Naipe;
        }
        private string[] ValorCarta()
        {
            string[] ValorCarta = { "Ás", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei" };
            return ValorCarta;
        }
        public class Carta : Deck
        {
            public string Naipe { get; private set; }
            public int Valor { get; private set; }
            public string CaminhoImagem { get; private set; }
            public Carta(string naipe, string valor, string caminhoImagem)
            {
                Naipe = naipe;
                if (valor == "Ás")
                {
                    Valor = 1;
                }
                else if (valor == "Valete")
                {
                    Valor = 10;
                }
                else if (valor == "Dama")
                {
                    Valor = 10;
                }
                else if (valor == "Rei")
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
}
