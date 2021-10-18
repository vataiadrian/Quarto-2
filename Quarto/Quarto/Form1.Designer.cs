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
            this.SuspendLayout();
            // 
            // newgameBTTN
            // 
            this.newgameBTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newgameBTTN.Location = new System.Drawing.Point(628, 12);
            this.newgameBTTN.Name = "newgameBTTN";
            this.newgameBTTN.Size = new System.Drawing.Size(160, 135);
            this.newgameBTTN.TabIndex = 0;
            this.newgameBTTN.Text = "New Game";
            this.newgameBTTN.UseVisualStyleBackColor = true;
            this.newgameBTTN.Click += new System.EventHandler(this.newgameBTTN_Click);
            // 
            // jatekos1
            // 
            this.jatekos1.Location = new System.Drawing.Point(290, 266);
            this.jatekos1.Name = "jatekos1";
            this.jatekos1.Size = new System.Drawing.Size(100, 20);
            this.jatekos1.TabIndex = 1;
            // 
            // jatekos2
            // 
            this.jatekos2.Location = new System.Drawing.Point(290, 292);
            this.jatekos2.Name = "jatekos2";
            this.jatekos2.Size = new System.Drawing.Size(100, 20);
            this.jatekos2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jatekos2);
            this.Controls.Add(this.jatekos1);
            this.Controls.Add(this.newgameBTTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newgameBTTN;
        private System.Windows.Forms.TextBox jatekos1;
        private System.Windows.Forms.TextBox jatekos2;
    }
}

