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
        static Image[] sotetkepek = new Image[8];
        static PictureBox[,] nagypicture = new PictureBox[4, 4];
        static PictureBox[,] vilagospictur = new PictureBox[4, 2];
        static PictureBox[,] sotetpictur = new PictureBox[4, 2];

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
            for (int i = 0; i < 8; i++)
            {
                sotetkepek[i]=Image.FromFile()

            }

            int yrajz = 0;
            int xrajz = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    nagypicture[i, j] = new PictureBox();
                    nagypicture[i, j].Size = new Size(100, 100);
                    nagypicture[i, j].BackColor = Color.FromArgb(127, 127, 127);
                    nagypicture[i, j].Name = i + ";" + j;


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
                    nagypicture[i, j].Anchor = AnchorStyles.None;
                    
                    nagypicture[i, j].Location = new System.Drawing.Point(yrajz, xrajz);
                   // nagypicture[i, j].Click += new System.EventHandler(this.odakatt);
                    
                    
                    Controls.Add(nagypicture[i, j]);
                    nagypicture[i, j].BringToFront();
                }
            }
            


                yrajz = 0;
                xrajz = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        vilagospictur[j, i] = new PictureBox();
                        vilagospictur[j, i].Size = new Size(50, 50);
                       vilagospictur[j, i].BackColor = Color.FromArgb(127, 127, 127);
                        vilagospictur[j, i].Name = i + ";" + j;

                       


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
                        
                        

                        
                        vilagospictur[j, i].Anchor = AnchorStyles.None;

                        vilagospictur[j, i].Location = new System.Drawing.Point(xrajz, yrajz);
                      
                        vilagospictur[j, i].Font = new Font("Arial", 32);
                      
                        Controls.Add(vilagospictur[j, i]);
                        vilagospictur[j, i].BringToFront();
                   // kepbeileszt(i,j);
                    }
                }

            yrajz = 0;
            xrajz = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sotetpictur[j, i] = new PictureBox();
                    sotetpictur[j, i].Size = new Size(50, 50);
                    sotetpictur[j, i].BackColor = Color.FromArgb(127, 127, 127);

                    sotetpictur[j, i].BackgroundImage = Image.FromFile("sotet1.png");
                    sotetpictur[j, i].Name = i + ";" + j;




                    


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


                    sotetpictur[j, i].Anchor = AnchorStyles.None;

                   sotetpictur[j, i].Location = new System.Drawing.Point(xrajz, yrajz);

                    sotetpictur[j, i].Font = new Font("Arial", 32);

                    Controls.Add(sotetpictur[j, i]);
                    sotetpictur[j, i].BringToFront();
                  //  kepbeileszt(i,j);
                }
            }



        }

        private void kepbeileszt(int i,int j)
        {
            throw new NotImplementedException();
        }

        private void idekatt(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}

