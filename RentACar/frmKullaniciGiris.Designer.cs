﻿namespace RentACar
{
    partial class frmKullaniciGiris
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.linklbl_kayitform = new System.Windows.Forms.LinkLabel();
            this.lbl_tcError = new System.Windows.Forms.Label();
            this.lbl_parolaError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.IndianRed;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.Transparent;
            this.btn_giris.Location = new System.Drawing.Point(84, 211);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(159, 51);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(81, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(84, 86);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(159, 20);
            this.txt_tc.TabIndex = 2;
            this.txt_tc.TextChanged += new System.EventHandler(this.txt_tc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(81, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(84, 158);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(159, 20);
            this.txt_parola.TabIndex = 2;
            this.txt_parola.UseSystemPasswordChar = true;
            this.txt_parola.TextChanged += new System.EventHandler(this.txt_parola_TextChanged);
            // 
            // linklbl_kayitform
            // 
            this.linklbl_kayitform.AutoSize = true;
            this.linklbl_kayitform.LinkColor = System.Drawing.Color.IndianRed;
            this.linklbl_kayitform.Location = new System.Drawing.Point(141, 276);
            this.linklbl_kayitform.Name = "linklbl_kayitform";
            this.linklbl_kayitform.Size = new System.Drawing.Size(43, 13);
            this.linklbl_kayitform.TabIndex = 3;
            this.linklbl_kayitform.TabStop = true;
            this.linklbl_kayitform.Text = "Kayıt Ol";
            this.linklbl_kayitform.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_kayitform_LinkClicked);
            // 
            // lbl_tcError
            // 
            this.lbl_tcError.AutoSize = true;
            this.lbl_tcError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_tcError.Location = new System.Drawing.Point(81, 109);
            this.lbl_tcError.Name = "lbl_tcError";
            this.lbl_tcError.Size = new System.Drawing.Size(0, 13);
            this.lbl_tcError.TabIndex = 4;
            // 
            // lbl_parolaError
            // 
            this.lbl_parolaError.AutoSize = true;
            this.lbl_parolaError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_parolaError.Location = new System.Drawing.Point(81, 181);
            this.lbl_parolaError.Name = "lbl_parolaError";
            this.lbl_parolaError.Size = new System.Drawing.Size(0, 13);
            this.lbl_parolaError.TabIndex = 4;
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 340);
            this.Controls.Add(this.lbl_parolaError);
            this.Controls.Add(this.lbl_tcError);
            this.Controls.Add(this.linklbl_kayitform);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Name = "frmKullaniciGiris";
            this.Text = "Kullanıcı Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.LinkLabel linklbl_kayitform;
        private System.Windows.Forms.Label lbl_tcError;
        private System.Windows.Forms.Label lbl_parolaError;
    }
}

