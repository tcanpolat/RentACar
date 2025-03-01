namespace RentACar
{
    partial class frmKiralamaYonet
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_alistarihi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_teslimtarihi = new System.Windows.Forms.Label();
            this.chck_kiradami = new System.Windows.Forms.CheckBox();
            this.btn_kiralama_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alış Tarihi";
            // 
            // lbl_alistarihi
            // 
            this.lbl_alistarihi.AutoSize = true;
            this.lbl_alistarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alistarihi.Location = new System.Drawing.Point(28, 44);
            this.lbl_alistarihi.Name = "lbl_alistarihi";
            this.lbl_alistarihi.Size = new System.Drawing.Size(51, 20);
            this.lbl_alistarihi.TabIndex = 0;
            this.lbl_alistarihi.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teslim Tarihi";
            // 
            // lbl_teslimtarihi
            // 
            this.lbl_teslimtarihi.AutoSize = true;
            this.lbl_teslimtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_teslimtarihi.Location = new System.Drawing.Point(28, 109);
            this.lbl_teslimtarihi.Name = "lbl_teslimtarihi";
            this.lbl_teslimtarihi.Size = new System.Drawing.Size(51, 20);
            this.lbl_teslimtarihi.TabIndex = 0;
            this.lbl_teslimtarihi.Text = "label1";
            // 
            // chck_kiradami
            // 
            this.chck_kiradami.AutoSize = true;
            this.chck_kiradami.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chck_kiradami.Location = new System.Drawing.Point(208, 21);
            this.chck_kiradami.Name = "chck_kiradami";
            this.chck_kiradami.Size = new System.Drawing.Size(156, 26);
            this.chck_kiradami.TabIndex = 1;
            this.chck_kiradami.Text = "Araç Kirada mı?";
            this.chck_kiradami.UseVisualStyleBackColor = true;
            // 
            // btn_kiralama_guncelle
            // 
            this.btn_kiralama_guncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btn_kiralama_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kiralama_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_kiralama_guncelle.Location = new System.Drawing.Point(43, 210);
            this.btn_kiralama_guncelle.Name = "btn_kiralama_guncelle";
            this.btn_kiralama_guncelle.Size = new System.Drawing.Size(473, 62);
            this.btn_kiralama_guncelle.TabIndex = 2;
            this.btn_kiralama_guncelle.Text = "Kiralamayı Güncelle";
            this.btn_kiralama_guncelle.UseVisualStyleBackColor = false;
            this.btn_kiralama_guncelle.Click += new System.EventHandler(this.btn_kiralama_guncelle_Click);
            // 
            // frmKiralamaYonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 301);
            this.Controls.Add(this.btn_kiralama_guncelle);
            this.Controls.Add(this.chck_kiradami);
            this.Controls.Add(this.lbl_teslimtarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_alistarihi);
            this.Controls.Add(this.label1);
            this.Name = "frmKiralamaYonet";
            this.Text = "Kiralama Yonet";
            this.Load += new System.EventHandler(this.frmKiralamaYonet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_alistarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_teslimtarihi;
        private System.Windows.Forms.CheckBox chck_kiradami;
        private System.Windows.Forms.Button btn_kiralama_guncelle;
    }
}