namespace RentACar
{
    partial class frmAracListesi
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
            this.dgv_aracListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aracListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_aracListesi
            // 
            this.dgv_aracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aracListesi.Location = new System.Drawing.Point(1, 1);
            this.dgv_aracListesi.Name = "dgv_aracListesi";
            this.dgv_aracListesi.Size = new System.Drawing.Size(957, 287);
            this.dgv_aracListesi.TabIndex = 0;
            this.dgv_aracListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_aracListesi_CellMouseClick);
            // 
            // frmAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 288);
            this.Controls.Add(this.dgv_aracListesi);
            this.Name = "frmAracListesi";
            this.Text = "Araç Listesi";
            this.Load += new System.EventHandler(this.frmAracListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aracListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_aracListesi;
    }
}