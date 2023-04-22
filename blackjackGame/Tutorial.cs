using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjackGame
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }
        public static void CallTutorial()
        {
            Tutorial fTutorial = new Tutorial();
            fTutorial.Show();
            fTutorial.FormBorderStyle = FormBorderStyle.None;
            fTutorial.WindowState = FormWindowState.Maximized;
            fTutorial.MinimizeBox = false;
            fTutorial.BackColor = Color.Black;
            //Configura algumas propriedades do texto tutorial
            fTutorial.textTutorial.Width = (fTutorial.Width / 2) - 10;
            fTutorial.textTutorial.BorderThickness = 5;
            fTutorial.textTutorial.ReadOnly = true;
        }
        //configura o botão voltar para a tela Principal
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            this.Close();
            newMenu.Show();
        }
    }
}
