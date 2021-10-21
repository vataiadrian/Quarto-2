namespace Quarto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newgameBTTN = new System.Windows.Forms.Button();
            this.jatekos1 = new System.Windows.Forms.TextBox();
            this.jatekos2 = new System.Windows.Forms.TextBox();
            this.menupanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.keszitokpnl = new System.Windows.Forms.Panel();
            this.boroslbl = new System.Windows.Forms.Label();
            this.vatailbl = new System.Windows.Forms.Label();
            this.szevaldlbl = new System.Windows.Forms.Label();
            this.keszitlbl = new System.Windows.Forms.Label();
            this.kilepesbtn = new System.Windows.Forms.Button();
            this.keszitbttn = new System.Windows.Forms.Button();
            this.folytatasbtn = new System.Windows.Forms.Button();
            this.visszabtn = new System.Windows.Forms.Button();
            this.menupanel.SuspendLayout();
            this.keszitokpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // newgameBTTN
            // 
            this.newgameBTTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newgameBTTN.BackColor = System.Drawing.Color.Transparent;
            this.newgameBTTN.FlatAppearance.BorderSize = 3;
            this.newgameBTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newgameBTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newgameBTTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.newgameBTTN.Location = new System.Drawing.Point(378, 149);
            this.newgameBTTN.Name = "newgameBTTN";
            this.newgameBTTN.Size = new System.Drawing.Size(296, 67);
            this.newgameBTTN.TabIndex = 0;
            this.newgameBTTN.Text = "Játék indítása";
            this.newgameBTTN.UseVisualStyleBackColor = false;
            this.newgameBTTN.Click += new System.EventHandler(this.newgameBTTN_Click);
            // 
            // jatekos1
            // 
            this.jatekos1.Location = new System.Drawing.Point(134, 312);
            this.jatekos1.Name = "jatekos1";
            this.jatekos1.Size = new System.Drawing.Size(100, 20);
            this.jatekos1.TabIndex = 1;
            this.jatekos1.Text = "boros";
            this.jatekos1.Visible = false;
            // 
            // jatekos2
            // 
            this.jatekos2.Location = new System.Drawing.Point(134, 338);
            this.jatekos2.Name = "jatekos2";
            this.jatekos2.Size = new System.Drawing.Size(100, 20);
            this.jatekos2.TabIndex = 2;
            this.jatekos2.Text = "miklos";
            this.jatekos2.Visible = false;
            // 
            // menupanel
            // 
            this.menupanel.Controls.Add(this.keszitokpnl);
            this.menupanel.Controls.Add(this.visszabtn);
            this.menupanel.Controls.Add(this.kilepesbtn);
            this.menupanel.Controls.Add(this.newgameBTTN);
            this.menupanel.Controls.Add(this.jatekos2);
            this.menupanel.Controls.Add(this.keszitbttn);
            this.menupanel.Controls.Add(this.jatekos1);
            this.menupanel.Controls.Add(this.folytatasbtn);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menupanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(113)))));
            this.menupanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(245)))));
            this.menupanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(111)))));
            this.menupanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.menupanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Quality = 2;
            this.menupanel.ShadowDecoration.Parent = this.menupanel;
            this.menupanel.Size = new System.Drawing.Size(1053, 666);
            this.menupanel.TabIndex = 19;
            // 
            // keszitokpnl
            // 
            this.keszitokpnl.BackColor = System.Drawing.Color.Transparent;
            this.keszitokpnl.Controls.Add(this.boroslbl);
            this.keszitokpnl.Controls.Add(this.vatailbl);
            this.keszitokpnl.Controls.Add(this.szevaldlbl);
            this.keszitokpnl.Controls.Add(this.keszitlbl);
            this.keszitokpnl.Location = new System.Drawing.Point(378, 149);
            this.keszitokpnl.Name = "keszitokpnl";
            this.keszitokpnl.Size = new System.Drawing.Size(296, 333);
            this.keszitokpnl.TabIndex = 18;
            this.keszitokpnl.Visible = false;
            // 
            // boroslbl
            // 
            this.boroslbl.AutoSize = true;
            this.boroslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boroslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.boroslbl.Location = new System.Drawing.Point(47, 238);
            this.boroslbl.Name = "boroslbl";
            this.boroslbl.Size = new System.Drawing.Size(222, 31);
            this.boroslbl.TabIndex = 3;
            this.boroslbl.Text = "Boros Barnabás";
            this.boroslbl.Visible = false;
            // 
            // vatailbl
            // 
            this.vatailbl.AutoSize = true;
            this.vatailbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vatailbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.vatailbl.Location = new System.Drawing.Point(47, 166);
            this.vatailbl.Name = "vatailbl";
            this.vatailbl.Size = new System.Drawing.Size(173, 31);
            this.vatailbl.TabIndex = 2;
            this.vatailbl.Text = "Vatai Adrián";
            this.vatailbl.Visible = false;
            // 
            // szevaldlbl
            // 
            this.szevaldlbl.AutoSize = true;
            this.szevaldlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szevaldlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.szevaldlbl.Location = new System.Drawing.Point(47, 96);
            this.szevaldlbl.Name = "szevaldlbl";
            this.szevaldlbl.Size = new System.Drawing.Size(209, 31);
            this.szevaldlbl.TabIndex = 1;
            this.szevaldlbl.Text = "Szévald Miklós";
            this.szevaldlbl.Visible = false;
            // 
            // keszitlbl
            // 
            this.keszitlbl.AutoSize = true;
            this.keszitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keszitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.keszitlbl.Location = new System.Drawing.Point(28, 31);
            this.keszitlbl.Name = "keszitlbl";
            this.keszitlbl.Size = new System.Drawing.Size(211, 39);
            this.keszitlbl.TabIndex = 0;
            this.keszitlbl.Text = "Készítették:";
            this.keszitlbl.Visible = false;
            // 
            // kilepesbtn
            // 
            this.kilepesbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kilepesbtn.BackColor = System.Drawing.Color.Transparent;
            this.kilepesbtn.FlatAppearance.BorderSize = 3;
            this.kilepesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kilepesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kilepesbtn.Location = new System.Drawing.Point(378, 415);
            this.kilepesbtn.Name = "kilepesbtn";
            this.kilepesbtn.Size = new System.Drawing.Size(296, 67);
            this.kilepesbtn.TabIndex = 4;
            this.kilepesbtn.Text = "Kilépés";
            this.kilepesbtn.UseVisualStyleBackColor = false;
            this.kilepesbtn.Click += new System.EventHandler(this.kilepesbtn_Click);
            // 
            // keszitbttn
            // 
            this.keszitbttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keszitbttn.BackColor = System.Drawing.Color.Transparent;
            this.keszitbttn.FlatAppearance.BorderSize = 3;
            this.keszitbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keszitbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keszitbttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.keszitbttn.Location = new System.Drawing.Point(378, 327);
            this.keszitbttn.Name = "keszitbttn";
            this.keszitbttn.Size = new System.Drawing.Size(296, 67);
            this.keszitbttn.TabIndex = 3;
            this.keszitbttn.Text = "Készítették";
            this.keszitbttn.UseVisualStyleBackColor = false;
            this.keszitbttn.Click += new System.EventHandler(this.keszitbttn_Click);
            // 
            // folytatasbtn
            // 
            this.folytatasbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.folytatasbtn.BackColor = System.Drawing.Color.Transparent;
            this.folytatasbtn.FlatAppearance.BorderSize = 3;
            this.folytatasbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folytatasbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.folytatasbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.folytatasbtn.Location = new System.Drawing.Point(378, 239);
            this.folytatasbtn.Name = "folytatasbtn";
            this.folytatasbtn.Size = new System.Drawing.Size(296, 67);
            this.folytatasbtn.TabIndex = 2;
            this.folytatasbtn.Text = "Név megadása";
            this.folytatasbtn.UseVisualStyleBackColor = false;
            this.folytatasbtn.Click += new System.EventHandler(this.folytatasbtn_Click);
            // 
            // visszabtn
            // 
            this.visszabtn.BackColor = System.Drawing.Color.Transparent;
            this.visszabtn.FlatAppearance.BorderSize = 3;
            this.visszabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visszabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visszabtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.visszabtn.Location = new System.Drawing.Point(454, 605);
            this.visszabtn.Name = "visszabtn";
            this.visszabtn.Size = new System.Drawing.Size(154, 49);
            this.visszabtn.TabIndex = 19;
            this.visszabtn.Text = "Vissza";
            this.visszabtn.UseVisualStyleBackColor = false;
            this.visszabtn.Visible = false;
            this.visszabtn.Click += new System.EventHandler(this.visszabtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 666);
            this.Controls.Add(this.menupanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.keszitokpnl.ResumeLayout(false);
            this.keszitokpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newgameBTTN;
        private System.Windows.Forms.TextBox jatekos1;
        private System.Windows.Forms.TextBox jatekos2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel menupanel;
        private System.Windows.Forms.Button kilepesbtn;
        private System.Windows.Forms.Button keszitbttn;
        private System.Windows.Forms.Button folytatasbtn;
        private System.Windows.Forms.Panel keszitokpnl;
        private System.Windows.Forms.Label boroslbl;
        private System.Windows.Forms.Label vatailbl;
        private System.Windows.Forms.Label szevaldlbl;
        private System.Windows.Forms.Label keszitlbl;
        private System.Windows.Forms.Button visszabtn;
    }
}

