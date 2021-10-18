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
        //static bool elso = true;
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
                        guna2Button1.SendToBack();
                        guna2Button2.SendToBack();
                        guna2Button3.SendToBack();
                        guna2Button4.SendToBack();
                        guna2Button5.SendToBack();
                        guna2Button6.SendToBack();
                        guna2Button7.SendToBack();
                        guna2Button8.SendToBack();
                        guna2Button9.SendToBack();
                        guna2Button10.SendToBack();
                        guna2Button11.SendToBack();
                        guna2Button12.SendToBack();
                        guna2Button13.SendToBack();
                        guna2Button14.SendToBack();
                        guna2Button15.SendToBack();
                        guna2Button16.SendToBack();
                        
                        esc = true;
                    }
                    else
                    {
                        guna2Button1.BringToFront();
                        guna2Button2.BringToFront();
                        guna2Button3.BringToFront();
                        guna2Button4.BringToFront();
                        guna2Button5.BringToFront();
                        guna2Button6.BringToFront();
                        guna2Button7.BringToFront();
                        guna2Button8.BringToFront();
                        guna2Button9.BringToFront();
                        guna2Button10.BringToFront();
                        guna2Button11.BringToFront();
                        guna2Button12.BringToFront();
                        guna2Button13.BringToFront();
                        guna2Button14.BringToFront();
                        guna2Button15.BringToFront();
                        guna2Button16.BringToFront();
                        kilepesbtn.SendToBack();
                        ujjatekbtn.SendToBack();
                        folytatasbtn.SendToBack();
                        menubtn.SendToBack();
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

