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
    public partial class Form2 : Form
    {
        static bool elso = true;
        public Form2()
        {
            InitializeComponent();
            GoFullscreen(true);
            MenuBehozas();
            NevekRandom();
        }

        //design

        private void GoFullscreen(bool fullscreen)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void MenuBehozas()
        {
            bool esc = true;
            this.KeyPreview = true;
            this.KeyPress += (ss, ee) =>
            {
                if (ee.KeyChar == 27)
                {
                    if (!esc)
                    {
                        menupanel.Visible = true;
                        esc = true;
                    }
                    else
                    {
                        menupanel.Visible = false;
                        esc = false;
                    }
                }
            };
        }

        private void kilepesbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog(this);
        }

        //jatek

        private void NevekRandom()
        {
            Random r = new Random();
            if (r.Next(0, 6) > 3)
            {
                player1label.Text = global.player1;
                player2label.Text = global.player2;
            }
            else
            {
                player1label.Text = global.player2;
                player2label.Text = global.player1;
            }
            if (r.Next(0, 6) > 3)
            {
                elso = false;
                nextplayertbx.Font = new Font("Arial", 24);
                nextplayertbx.Text = player2label.Text;
            }
            else
            {
                elso = true;
                nextplayertbx.Font = new Font("Arial", 24);
                nextplayertbx.Text = player2label.Text;

            }
            
        }
    }
}

