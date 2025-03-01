namespace RentACar
{
    partial class frmYoneticiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_kiralamalar = new System.Windows.Forms.ToolStripButton();
            this.tsl_kiralamalar = new System.Windows.Forms.ToolStripLabel();
            this.tsb_aracekle = new System.Windows.Forms.ToolStripButton();
            this.tsl_aracekle = new System.Windows.Forms.ToolStripLabel();
            this.tsb_araclistesi = new System.Windows.Forms.ToolStripButton();
            this.tsl_araclistesi = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(235, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "UBY RENT A CAR";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_kiralamalar,
            this.tsl_kiralamalar,
            this.tsb_aracekle,
            this.tsl_aracekle,
            this.tsb_araclistesi,
            this.tsl_araclistesi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_kiralamalar
            // 
            this.tsb_kiralamalar.AutoSize = false;
            this.tsb_kiralamalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsb_kiralamalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_kiralamalar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsb_kiralamalar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_kiralamalar.Image")));
            this.tsb_kiralamalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_kiralamalar.Name = "tsb_kiralamalar";
            this.tsb_kiralamalar.Size = new System.Drawing.Size(30, 30);
            this.tsb_kiralamalar.Text = "Kiralamalar";
            this.tsb_kiralamalar.Click += new System.EventHandler(this.tsb_kiralamalar_Click);
            this.tsb_kiralamalar.MouseLeave += new System.EventHandler(this.tsb_kiralamalar_MouseLeave);
            this.tsb_kiralamalar.MouseHover += new System.EventHandler(this.tsb_kiralamalar_MouseHover);
            // 
            // tsl_kiralamalar
            // 
            this.tsl_kiralamalar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsl_kiralamalar.Name = "tsl_kiralamalar";
            this.tsl_kiralamalar.Size = new System.Drawing.Size(89, 30);
            this.tsl_kiralamalar.Text = "Kiralamalar";
            this.tsl_kiralamalar.Visible = false;
            // 
            // tsb_aracekle
            // 
            this.tsb_aracekle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_aracekle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsb_aracekle.Image = ((System.Drawing.Image)(resources.GetObject("tsb_aracekle.Image")));
            this.tsb_aracekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_aracekle.Name = "tsb_aracekle";
            this.tsb_aracekle.Size = new System.Drawing.Size(23, 30);
            this.tsb_aracekle.Text = "Araç Ekle";
            this.tsb_aracekle.Click += new System.EventHandler(this.tsb_aracekle_Click);
            this.tsb_aracekle.MouseLeave += new System.EventHandler(this.tsb_aracekle_MouseLeave);
            this.tsb_aracekle.MouseHover += new System.EventHandler(this.tsb_aracekle_MouseHover);
            // 
            // tsl_aracekle
            // 
            this.tsl_aracekle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsl_aracekle.Name = "tsl_aracekle";
            this.tsl_aracekle.Size = new System.Drawing.Size(73, 30);
            this.tsl_aracekle.Text = "Araç Ekle";
            this.tsl_aracekle.Visible = false;
            // 
            // tsb_araclistesi
            // 
            this.tsb_araclistesi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_araclistesi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsb_araclistesi.Image = ((System.Drawing.Image)(resources.GetObject("tsb_araclistesi.Image")));
            this.tsb_araclistesi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_araclistesi.Name = "tsb_araclistesi";
            this.tsb_araclistesi.Size = new System.Drawing.Size(23, 30);
            this.tsb_araclistesi.Text = "Araç Listesi";
            this.tsb_araclistesi.Click += new System.EventHandler(this.tsb_araclistesi_Click);
            this.tsb_araclistesi.MouseLeave += new System.EventHandler(this.tsb_araclistesi_MouseLeave);
            this.tsb_araclistesi.MouseHover += new System.EventHandler(this.tsb_araclistesi_MouseHover);
            // 
            // tsl_araclistesi
            // 
            this.tsl_araclistesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsl_araclistesi.Name = "tsl_araclistesi";
            this.tsl_araclistesi.Size = new System.Drawing.Size(89, 30);
            this.tsl_araclistesi.Text = "Araç Listesi";
            this.tsl_araclistesi.Visible = false;
            // 
            // frmYoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 318);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmYoneticiPanel";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.frmYoneticiPanel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_kiralamalar;
        private System.Windows.Forms.ToolStripLabel tsl_kiralamalar;
        private System.Windows.Forms.ToolStripButton tsb_aracekle;
        private System.Windows.Forms.ToolStripLabel tsl_aracekle;
        private System.Windows.Forms.ToolStripButton tsb_araclistesi;
        private System.Windows.Forms.ToolStripLabel tsl_araclistesi;
    }
}