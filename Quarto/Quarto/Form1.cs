﻿using System;
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
            GoFullscreen(true);


        }

        //design
        private void GoFullscreen(bool fullscreen)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void kilepesbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newgameBTTN_Click(object sender, EventArgs e)
        {
            player1 = jatekos1.Text;
            player2 = jatekos2.Text;

            if (player1 == "" || player2 == "")
            {
                MessageBox.Show("Kérem adja meg a nevét!", "Hiányzó név", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (player1 == player2)
                {
                    MessageBox.Show("Kérem adjon meg különböző neveket!", "Megegyező név", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    global.player1 = player1;
                    global.player2 = player2;
                    Form2 jatekter = new Form2();
                    this.Hide();
                    jatekter.ShowDialog(this);
                }
            }
        }

        private void keszitbttn_Click(object sender, EventArgs e)
        {
            keszitokpnl.Visible = true;
            keszitlbl.Visible = true;
            szevaldlbl.Visible = true;
            boroslbl.Visible = true;
            vatailbl.Visible = true;
            visszabtn.Visible = true;
        }

        private void visszabtn_Click(object sender, EventArgs e)
        {
            keszitokpnl.Visible = false;
            keszitlbl.Visible = false;
            szevaldlbl.Visible = false;
            boroslbl.Visible = false;
            vatailbl.Visible = false;
            visszabtn.Visible = false;
            folytatasbtn.Visible = true;
            keszitbttn.Visible = true;
            kilepesbtn.Visible = true;
            newgameBTTN.Visible = true;

        }

        private void folytatasbtn_Click(object sender, EventArgs e)
        {
            visszabtn.Visible = true;
            nev1lbl.Visible = true;
            nev2lbl.Visible = true;
            jatekos1.Visible = true;
            jatekos2.Visible = true;
            folytatasbtn.Visible = false;
            keszitbttn.Visible = false;
            kilepesbtn.Visible = false;
            newgameBTTN.Visible = false;
        }
    }
}
