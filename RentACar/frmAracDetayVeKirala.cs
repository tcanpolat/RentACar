using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmAracDetayVeKirala : Form
    {
        public string kid;
        public int id;
        public int gun;
        DataContext _context = new DataContext();
        public frmAracDetayVeKirala()
        {
            InitializeComponent();
        }

        private void frmAracDetayVeKirala_Load(object sender, EventArgs e)
        {
            Araba araba = _context.Arabalar.Where(a => a.ID == id).First();

            lbl_aracTipi.Text = araba.AracTipi;
            lbl_gunlukFiyat.Text = araba.Fiyat.ToString();
            lbl_marka.Text = araba.Marka;
            lbl_vitesTuru.Text = araba.Vites;    
            lbl_plaka.Text = araba.Plaka;
            lbl_YakitTipi.Text = araba.YakitTipi;
            pictureBox_arac.Image = ConvertBase64ToImage(araba.ImageUrl);
            
        }

        private Image ConvertBase64ToImage(string imageUrl)
        {
            byte[] imageBytes = Convert.FromBase64String(imageUrl);
            using (MemoryStream ms = new MemoryStream(imageBytes,0,imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms,true);
            }
        }

        private void dtp_alisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimTarihi.Enabled = true;
        }

        private void dtp_teslimTarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan GunFarki = dtp_teslimTarihi.Value.Subtract(dtp_alisTarihi.Value);
            gun = GunFarki.Days;

            if(gun < 1)
            {
                MessageBox.Show("Teslim Tarihi Alış Tarihinden önce veya aynı gün olamaz!");
                lbl_gunSayisi.Text = null;
                lbl_FaturaTutari.Text = null;
            }
            else
            {
                lbl_gunSayisi.Text = gun.ToString();
                double faturaTutari = gun * Convert.ToDouble(lbl_gunlukFiyat.Text);
                lbl_FaturaTutari.Text = faturaTutari.ToString();
            }
        }
    }
}
