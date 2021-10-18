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
                        esc = true;
                    }
                    else
                    {
                        esc = false;
                    }
                }
            };
        }

        //jatek

        private void NevekRandom()
        {
            /*Random r = new Random();
            if (r.Next(0, 6) > 3)
            {
                labelO.Text = global.player1;
                labelX.Text = global.player2;
            }
            else
            {
                labelO.Text = global.player2;
                labelX.Text = global.player1;
            }
            if (r.Next(0, 6) > 3)
            {
                elso = false;
                kezdojatekostbx.Font = new Font("Arial", 24);
                kezdojatekostbx.Text = labelX.Text;
            }
            else
            {
                elso = true;
                kezdojatekostbx.Font = new Font("Arial", 24);
                kezdojatekostbx.Text = labelO.Text;

            }
            kezdonevlbl.Text = "";*/
        }
    }
}

