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
            this.kilepesbtn = new System.Windows.Forms.Button();
            this.menubtn = new System.Windows.Forms.Button();
            this.folytatasbtn = new System.Windows.Forms.Button();
            this.menupanel.SuspendLayout();
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
            this.jatekos1.Location = new System.Drawing.Point(350, 562);
            this.jatekos1.Name = "jatekos1";
            this.jatekos1.Size = new System.Drawing.Size(100, 20);
            this.jatekos1.TabIndex = 1;
            this.jatekos1.Text = "boros";
            // 
            // jatekos2
            // 
            this.jatekos2.Location = new System.Drawing.Point(597, 562);
            this.jatekos2.Name = "jatekos2";
            this.jatekos2.Size = new System.Drawing.Size(100, 20);
            this.jatekos2.TabIndex = 2;
            this.jatekos2.Text = "miklos";
            // 
            // menupanel
            // 
            this.menupanel.Controls.Add(this.kilepesbtn);
            this.menupanel.Controls.Add(this.newgameBTTN);
            this.menupanel.Controls.Add(this.jatekos2);
            this.menupanel.Controls.Add(this.menubtn);
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
            // menubtn
            // 
            this.menubtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menubtn.BackColor = System.Drawing.Color.Transparent;
            this.menubtn.FlatAppearance.BorderSize = 3;
            this.menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menubtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menubtn.Location = new System.Drawing.Point(378, 327);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(296, 67);
            this.menubtn.TabIndex = 3;
            this.menubtn.Text = "Készítették";
            this.menubtn.UseVisualStyleBackColor = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newgameBTTN;
        private System.Windows.Forms.TextBox jatekos1;
        private System.Windows.Forms.TextBox jatekos2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel menupanel;
        private System.Windows.Forms.Button kilepesbtn;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Button folytatasbtn;
    }
}

