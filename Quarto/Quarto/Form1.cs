using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarto
{
    public partial class Form1 : Form
    {
        static string player1 = "";
        static string player2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void newgameBTTN_Click(object sender, EventArgs e)
        {
            player1 = jatekos1.Text;
            player2 = jatekos2.Text;




            if (player1 != "" && player2 != "")
            {
                global.player1 = player1;
                global.player1 = player2;
                Form2 jatekter = new Form2();
                this.Hide();
                jatekter.ShowDialog(this);
            }
            else if (player1 == player2)
            {
                MessageBox.Show("Kérem két különböző nevet adjon meg!", "Megegyező név", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Kérem adja meg a nevét!", "Hiányzó név", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
