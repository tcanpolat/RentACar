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
            if(araba == null) { MessageBox.Show("Araba bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); return; }

            lbl_aracTipi.Text = araba.AracTipi;
            lbl_gunlukFiyat.Text = araba.Fiyat.ToString();
            lbl_marka.Text = araba.Marka;
            lbl_vitesTuru.Text = araba.Vites;    
            lbl_plaka.Text = araba.Plaka;
            lbl_YakitTipi.Text = araba.YakitTipi;
            pictureBox_arac.Image = ConvertBase64ToImage(araba.ImageUrl);

            dtp_alisTarihi.MinDate = DateTime.Now;
            
        }

        private Image ConvertBase64ToImage(string imageUrl)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(imageUrl);
                using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    return Image.FromStream(ms, true);
                }
            }
            catch { return null; }
        }

        private void dtp_alisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimTarihi.Enabled = true;
            dtp_teslimTarihi.MinDate = dtp_alisTarihi.Value.AddDays(1);
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

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Araba arabaKiralikMi = _context.Arabalar.Where(a => a.ID == id && a.AktifMi == false).FirstOrDefault();
            Araba araba = _context.Arabalar.Where(a => a.ID == id).FirstOrDefault();

            if (arabaKiralikMi != null)
            {
                MessageBox.Show("Seçtiğinz Araç Şu an kirada");
            }
            else
            {
                Kiralama kiralama = new Kiralama()
                {
                    ArabaID = id,
                    YoneticiID = int.Parse(kid),
                    AlisTarihi  = dtp_alisTarihi.Value,
                    TeslimTarihi = dtp_teslimTarihi.Value,
                    KiralamaSuresi = gun,
                    FaturaTutari = Convert.ToDouble(lbl_FaturaTutari.Text),
                    AddDate = DateTime.Now,
                    AktifMi = true
                };

                araba.AktifMi = false;
                _context.Kiralamalar.Add(kiralama);
                _context.SaveChanges();
                MessageBox.Show("Araç Kiralandı", "Başarılı işlem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();                
            }
        }
    }
}
