namespace RentACar
{
    partial class frmAracEkle
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
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gunlukFiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.cmb_aracTipi = new System.Windows.Forms.ComboBox();
            this.cmb_vitestur = new System.Windows.Forms.ComboBox();
            this.cmb_yakitTipi = new System.Windows.Forms.ComboBox();
            this.btn_fileDialog = new System.Windows.Forms.Button();
            this.pictureBox_arac = new System.Windows.Forms.PictureBox();
            this.btn_aracEkle = new System.Windows.Forms.Button();
            this.label_fiyatError = new System.Windows.Forms.Label();
            this.label_resimError = new System.Windows.Forms.Label();
            this.label_YakıtError = new System.Windows.Forms.Label();
            this.label_AracTipiError = new System.Windows.Forms.Label();
            this.label_MarkaError = new System.Windows.Forms.Label();
            this.label_PlakaError = new System.Windows.Forms.Label();
            this.label_modelError = new System.Windows.Forms.Label();
            this.label_vitesError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_arac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(346, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(349, 64);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(143, 20);
            this.txt_plaka.TabIndex = 1;
            this.txt_plaka.TextChanged += new System.EventHandler(this.txt_plaka_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(532, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(535, 64);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(143, 20);
            this.txt_marka.TabIndex = 1;
            this.txt_marka.TextChanged += new System.EventHandler(this.txt_marka_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(346, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model";
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(349, 131);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(143, 20);
            this.txt_model.TabIndex = 1;
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(532, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Araç Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(346, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(532, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yakıt Tipi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(346, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Günlük Fiyat";
            // 
            // txt_gunlukFiyat
            // 
            this.txt_gunlukFiyat.Location = new System.Drawing.Point(349, 266);
            this.txt_gunlukFiyat.Name = "txt_gunlukFiyat";
            this.txt_gunlukFiyat.Size = new System.Drawing.Size(143, 20);
            this.txt_gunlukFiyat.TabIndex = 1;
            this.txt_gunlukFiyat.TextChanged += new System.EventHandler(this.txt_gunlukFiyat_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(532, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Araç Resmi";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(535, 266);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(136, 20);
            this.fileName.TabIndex = 1;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // cmb_aracTipi
            // 
            this.cmb_aracTipi.FormattingEnabled = true;
            this.cmb_aracTipi.Items.AddRange(new object[] {
            "Hatchback",
            "Sedan",
            "SUV"});
            this.cmb_aracTipi.Location = new System.Drawing.Point(535, 129);
            this.cmb_aracTipi.Name = "cmb_aracTipi";
            this.cmb_aracTipi.Size = new System.Drawing.Size(143, 21);
            this.cmb_aracTipi.TabIndex = 2;
            this.cmb_aracTipi.SelectedIndexChanged += new System.EventHandler(this.cmb_aracTipi_SelectedIndexChanged);
            // 
            // cmb_vitestur
            // 
            this.cmb_vitestur.FormattingEnabled = true;
            this.cmb_vitestur.Items.AddRange(new object[] {
            "Düz",
            "Otomatik",
            "Yarı Otomatik"});
            this.cmb_vitestur.Location = new System.Drawing.Point(349, 197);
            this.cmb_vitestur.Name = "cmb_vitestur";
            this.cmb_vitestur.Size = new System.Drawing.Size(143, 21);
            this.cmb_vitestur.TabIndex = 2;
            this.cmb_vitestur.SelectedIndexChanged += new System.EventHandler(this.cmb_vitestur_SelectedIndexChanged);
            // 
            // cmb_yakitTipi
            // 
            this.cmb_yakitTipi.FormattingEnabled = true;
            this.cmb_yakitTipi.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Elektrik",
            "Hibrit",
            "Benzin + LPG"});
            this.cmb_yakitTipi.Location = new System.Drawing.Point(535, 197);
            this.cmb_yakitTipi.Name = "cmb_yakitTipi";
            this.cmb_yakitTipi.Size = new System.Drawing.Size(143, 21);
            this.cmb_yakitTipi.TabIndex = 2;
            this.cmb_yakitTipi.SelectedIndexChanged += new System.EventHandler(this.cmb_yakitTipi_SelectedIndexChanged);
            // 
            // btn_fileDialog
            // 
            this.btn_fileDialog.BackColor = System.Drawing.Color.IndianRed;
            this.btn_fileDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_fileDialog.Location = new System.Drawing.Point(677, 265);
            this.btn_fileDialog.Name = "btn_fileDialog";
            this.btn_fileDialog.Size = new System.Drawing.Size(67, 23);
            this.btn_fileDialog.TabIndex = 3;
            this.btn_fileDialog.Text = "Yükle";
            this.btn_fileDialog.UseVisualStyleBackColor = false;
            this.btn_fileDialog.Click += new System.EventHandler(this.btn_fileDialog_Click);
            // 
            // pictureBox_arac
            // 
            this.pictureBox_arac.Location = new System.Drawing.Point(23, 54);
            this.pictureBox_arac.Name = "pictureBox_arac";
            this.pictureBox_arac.Size = new System.Drawing.Size(291, 234);
            this.pictureBox_arac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_arac.TabIndex = 4;
            this.pictureBox_arac.TabStop = false;
            // 
            // btn_aracEkle
            // 
            this.btn_aracEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btn_aracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aracEkle.ForeColor = System.Drawing.Color.White;
            this.btn_aracEkle.Location = new System.Drawing.Point(349, 329);
            this.btn_aracEkle.Name = "btn_aracEkle";
            this.btn_aracEkle.Size = new System.Drawing.Size(395, 65);
            this.btn_aracEkle.TabIndex = 5;
            this.btn_aracEkle.Text = "Araç Ekle";
            this.btn_aracEkle.UseVisualStyleBackColor = false;
            this.btn_aracEkle.Click += new System.EventHandler(this.btn_aracEkle_Click);
            // 
            // label_fiyatError
            // 
            this.label_fiyatError.AutoSize = true;
            this.label_fiyatError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_fiyatError.Location = new System.Drawing.Point(346, 289);
            this.label_fiyatError.Name = "label_fiyatError";
            this.label_fiyatError.Size = new System.Drawing.Size(0, 13);
            this.label_fiyatError.TabIndex = 6;
            // 
            // label_resimError
            // 
            this.label_resimError.AutoSize = true;
            this.label_resimError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_resimError.Location = new System.Drawing.Point(532, 289);
            this.label_resimError.Name = "label_resimError";
            this.label_resimError.Size = new System.Drawing.Size(0, 13);
            this.label_resimError.TabIndex = 7;
            // 
            // label_YakıtError
            // 
            this.label_YakıtError.AutoSize = true;
            this.label_YakıtError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_YakıtError.Location = new System.Drawing.Point(532, 221);
            this.label_YakıtError.Name = "label_YakıtError";
            this.label_YakıtError.Size = new System.Drawing.Size(0, 13);
            this.label_YakıtError.TabIndex = 7;
            // 
            // label_AracTipiError
            // 
            this.label_AracTipiError.AutoSize = true;
            this.label_AracTipiError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_AracTipiError.Location = new System.Drawing.Point(532, 153);
            this.label_AracTipiError.Name = "label_AracTipiError";
            this.label_AracTipiError.Size = new System.Drawing.Size(0, 13);
            this.label_AracTipiError.TabIndex = 7;
            // 
            // label_MarkaError
            // 
            this.label_MarkaError.AutoSize = true;
            this.label_MarkaError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_MarkaError.Location = new System.Drawing.Point(532, 87);
            this.label_MarkaError.Name = "label_MarkaError";
            this.label_MarkaError.Size = new System.Drawing.Size(0, 13);
            this.label_MarkaError.TabIndex = 7;
            // 
            // label_PlakaError
            // 
            this.label_PlakaError.AutoSize = true;
            this.label_PlakaError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_PlakaError.Location = new System.Drawing.Point(346, 87);
            this.label_PlakaError.Name = "label_PlakaError";
            this.label_PlakaError.Size = new System.Drawing.Size(0, 13);
            this.label_PlakaError.TabIndex = 7;
            // 
            // label_modelError
            // 
            this.label_modelError.AutoSize = true;
            this.label_modelError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_modelError.Location = new System.Drawing.Point(346, 153);
            this.label_modelError.Name = "label_modelError";
            this.label_modelError.Size = new System.Drawing.Size(0, 13);
            this.label_modelError.TabIndex = 7;
            // 
            // label_vitesError
            // 
            this.label_vitesError.AutoSize = true;
            this.label_vitesError.ForeColor = System.Drawing.Color.IndianRed;
            this.label_vitesError.Location = new System.Drawing.Point(346, 221);
            this.label_vitesError.Name = "label_vitesError";
            this.label_vitesError.Size = new System.Drawing.Size(0, 13);
            this.label_vitesError.TabIndex = 7;
            // 
            // frmAracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 415);
            this.Controls.Add(this.label_vitesError);
            this.Controls.Add(this.label_modelError);
            this.Controls.Add(this.label_PlakaError);
            this.Controls.Add(this.label_MarkaError);
            this.Controls.Add(this.label_AracTipiError);
            this.Controls.Add(this.label_YakıtError);
            this.Controls.Add(this.label_resimError);
            this.Controls.Add(this.label_fiyatError);
            this.Controls.Add(this.btn_aracEkle);
            this.Controls.Add(this.pictureBox_arac);
            this.Controls.Add(this.btn_fileDialog);
            this.Controls.Add(this.cmb_yakitTipi);
            this.Controls.Add(this.cmb_vitestur);
            this.Controls.Add(this.cmb_aracTipi);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_gunlukFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.label1);
            this.Name = "frmAracEkle";
            this.Text = "Araç Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_arac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gunlukFiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.ComboBox cmb_aracTipi;
        private System.Windows.Forms.ComboBox cmb_vitestur;
        private System.Windows.Forms.ComboBox cmb_yakitTipi;
        private System.Windows.Forms.Button btn_fileDialog;
        private System.Windows.Forms.PictureBox pictureBox_arac;
        private System.Windows.Forms.Button btn_aracEkle;
        private System.Windows.Forms.Label label_fiyatError;
        private System.Windows.Forms.Label label_resimError;
        private System.Windows.Forms.Label label_YakıtError;
        private System.Windows.Forms.Label label_AracTipiError;
        private System.Windows.Forms.Label label_MarkaError;
        private System.Windows.Forms.Label label_PlakaError;
        private System.Windows.Forms.Label label_modelError;
        private System.Windows.Forms.Label label_vitesError;
    }
}