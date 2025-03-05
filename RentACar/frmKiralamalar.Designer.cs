namespace RentACar
{
    partial class frmKiralamalar
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
            this.dgv_kiralamalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiralamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kiralamalar
            // 
            this.dgv_kiralamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kiralamalar.Location = new System.Drawing.Point(0, -2);
            this.dgv_kiralamalar.Name = "dgv_kiralamalar";
            this.dgv_kiralamalar.Size = new System.Drawing.Size(878, 286);
            this.dgv_kiralamalar.TabIndex = 0;
            this.dgv_kiralamalar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_kiralamalar_CellMouseClick);
            // 
            // frmKiralamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 284);
            this.Controls.Add(this.dgv_kiralamalar);
            this.Name = "frmKiralamalar";
            this.Text = "Kiralamalar";
            this.Load += new System.EventHandler(this.frmKiralamalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiralamalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kiralamalar;
    }
}