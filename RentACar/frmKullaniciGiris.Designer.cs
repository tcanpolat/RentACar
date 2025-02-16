namespace RentACar
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
            this.label_tc = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label_parola = new System.Windows.Forms.Label();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.linklbl_kayitform = new System.Windows.Forms.LinkLabel();
            this.label_tc_error = new System.Windows.Forms.Label();
            this.label_parola_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.IndianRed;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.Transparent;
            this.btn_giris.Location = new System.Drawing.Point(84, 222);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(159, 51);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tc.ForeColor = System.Drawing.Color.IndianRed;
            this.label_tc.Location = new System.Drawing.Point(81, 65);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(108, 18);
            this.label_tc.TabIndex = 1;
            this.label_tc.Text = "TC Kimlik No";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(84, 86);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(159, 20);
            this.txt_tc.TabIndex = 0;
            this.txt_tc.TextChanged += new System.EventHandler(this.txt_tc_TextChanged);
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_parola.ForeColor = System.Drawing.Color.IndianRed;
            this.label_parola.Location = new System.Drawing.Point(81, 141);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(57, 18);
            this.label_parola.TabIndex = 1;
            this.label_parola.Text = "Parola";
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(84, 162);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(159, 20);
            this.txt_parola.TabIndex = 1;
            this.txt_parola.UseSystemPasswordChar = true;
            this.txt_parola.TextChanged += new System.EventHandler(this.txt_parola_TextChanged);
            // 
            // linklbl_kayitform
            // 
            this.linklbl_kayitform.AutoSize = true;
            this.linklbl_kayitform.LinkColor = System.Drawing.Color.IndianRed;
            this.linklbl_kayitform.Location = new System.Drawing.Point(141, 287);
            this.linklbl_kayitform.Name = "linklbl_kayitform";
            this.linklbl_kayitform.Size = new System.Drawing.Size(43, 13);
            this.linklbl_kayitform.TabIndex = 3;
            this.linklbl_kayitform.TabStop = true;
            this.linklbl_kayitform.Text = "Kayıt Ol";
            this.linklbl_kayitform.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_kayitform_LinkClicked);
            // 
            // label_tc_error
            // 
            this.label_tc_error.AutoSize = true;
            this.label_tc_error.ForeColor = System.Drawing.Color.Maroon;
            this.label_tc_error.Location = new System.Drawing.Point(81, 109);
            this.label_tc_error.Name = "label_tc_error";
            this.label_tc_error.Size = new System.Drawing.Size(0, 13);
            this.label_tc_error.TabIndex = 4;
            // 
            // label_parola_error
            // 
            this.label_parola_error.AutoSize = true;
            this.label_parola_error.ForeColor = System.Drawing.Color.Maroon;
            this.label_parola_error.Location = new System.Drawing.Point(81, 185);
            this.label_parola_error.Name = "label_parola_error";
            this.label_parola_error.Size = new System.Drawing.Size(0, 13);
            this.label_parola_error.TabIndex = 4;
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 340);
            this.Controls.Add(this.label_parola_error);
            this.Controls.Add(this.label_tc_error);
            this.Controls.Add(this.linklbl_kayitform);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label_tc);
            this.Controls.Add(this.btn_giris);
            this.Name = "frmKullaniciGiris";
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.frmKullaniciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.LinkLabel linklbl_kayitform;
        private System.Windows.Forms.Label label_tc_error;
        private System.Windows.Forms.Label label_parola_error;
    }
}

