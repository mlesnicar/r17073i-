﻿namespace Informaticka_oprema
{
    partial class Prijava
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
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(120, 39);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnicko.TabIndex = 0;
            this.txtKorisnicko.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(120, 75);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 1;
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.Location = new System.Drawing.Point(29, 46);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnicko.TabIndex = 2;
            this.lblKorisnicko.Text = "Korisničko ime";
            this.lblKorisnicko.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(29, 82);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(43, 161);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(145, 161);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(75, 23);
            this.btnRegistracija.TabIndex = 5;
            this.btnRegistracija.Text = "Registriraj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnicko);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnicko);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblKorisnicko;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
    }
}