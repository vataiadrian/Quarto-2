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
        static Label[,] labelok = new Label[4, 4];
        static Label[,] labelokvilagos = new Label[4, 2];
        static Label[,] labeloksotet = new Label[4, 2];
        public Form2()
        {
            InitializeComponent();
            GoFullscreen(true);
            MenuBehozas();
            NevekRandom();
            generalas();
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
                nextplayerlbl.Font = new Font("Arial", 24);
                nextplayerlbl.Text = player2label.Text;
            }
            else
            {
                elso = true;
                nextplayerlbl.Font = new Font("Arial", 24);
                nextplayerlbl.Text = player2label.Text;

            }
            
        }

        private void generalas()
        {

            int yrajz = 0;
            int xrajz = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    labelok[i, j] = new Label();
                    labelok[i, j].Size = new Size(100, 100);
                    labelok[i, j].BackColor = Color.FromArgb(127, 127, 127);
                    labelok[i, j].Name = i + ";" + j;


                    switch (i)
                    {
                        case 0:
                            xrajz = 294;
                            break;
                        case 1:
                            xrajz = 400;
                            break;
                        case 2:
                            xrajz = 506;
                            break;
                        case 3:
                            xrajz = 612;
                            break;
                        
                      
                    }
                    switch (j)
                    {
                        case 0:
                            yrajz = 753;
                            break;
                        case 1:
                            yrajz = 859;
                            break;
                        case 2:
                            yrajz = 965;
                            break;
                        case 3:
                            yrajz = 1071;
                            break;
                        
                       
                    }
                    labelok[i, j].Anchor = AnchorStyles.None;
                    
                    labelok[i, j].Location = new System.Drawing.Point(yrajz, xrajz);
                    labelok[i, j].Click += new System.EventHandler(this.odakatt);
                    labelok[i, j].Font = new Font("Arial", 32);
                    labelok[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    Controls.Add(labelok[i, j]);
                    labelok[i, j].BringToFront();
                }
            }
            for (int k = 0; k < 2; k++)
            {


                yrajz = 0;
                xrajz = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        labelok[i, j] = new Label();
                        labelok[i, j].Size = new Size(50, 50);
                        labelok[i, j].BackColor = Color.FromArgb(127, 127, 127);
                        labelok[i, j].Name = i + ";" + j;

                        if (k ==0)
                        {


                            switch (i)
                            {
                                case 0:
                                    xrajz = 602;
                                    break;
                                case 1:
                                    xrajz = 670;
                                    break;
                              
                                

                            }
                            switch (j)
                            {
                                case 0:
                                    yrajz = 370;
                                    break;
                                case 1:
                                    yrajz = 426;
                                    break;
                                case 2:
                                    yrajz = 482;
                                    break;
                                case 3:
                                    yrajz = 538;
                                    break;
                                

                            }
                        }
                        if (k == 1)
                        {
                            switch (i)
                            {
                                case 0:
                                    xrajz = 1202;
                                    break;
                                case 1:
                                    xrajz = 1271;
                                    break;
                               
                                

                            }
                            switch (j)
                            {
                                case 0:
                                    yrajz = 370;
                                    break;
                                case 1:
                                    yrajz = 426;
                                    break;
                                case 2:
                                    yrajz = 482;
                                    break;
                                case 3:
                                    yrajz = 538;
                                    break;
                                

                            }

                        }
                        labelok[i, j].Anchor = AnchorStyles.None;

                        labelok[i, j].Location = new System.Drawing.Point(xrajz, yrajz);
                       // labelok[i, j].Click += new System.EventHandler(this.idekatt);
                        labelok[i, j].Font = new Font("Arial", 32);
                        labelok[i, j].TextAlign = ContentAlignment.MiddleCenter;
                        Controls.Add(labelok[i, j]);
                        labelok[i, j].BringToFront();
                    }
                }
            }


        }

        private void idekatt(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void odakatt(object sender, EventArgs e)
        {
            Label kattintott = sender as Label;
            int y = Convert.ToInt32(kattintott.Name.Split(';')[0]);
            int x = Convert.ToInt32(kattintott.Name.Split(';')[1]);
            if (labelok[y, x].Text == "")
            {
                if (elso)
                {

                    labelok[y, x].Text = "O";
                    labelok[y, x].ForeColor = System.Drawing.Color.Red;
                    nextplayerlbl.Font = new Font("Arial", 24);
                    nextplayerlbl.Text =player2label.Text;
                    elso = false;
                }
                else
                {
                    labelok[y, x].Text = "X";
                    labelok[y, x].ForeColor = System.Drawing.Color.Blue;
                    nextplayerlbl.Font = new Font("Arial", 24);
                    nextplayerlbl.Text = player1label.Text;
                    elso = true;
                }
               // ellenorzes();
            }
            else
            {
               // kezdonevlbl.Text = "Ne csaljál kis k*cs*g!";

            }
        }
    }
}

