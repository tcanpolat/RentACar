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
    public partial class frmAracEkle : Form
    {
        DataContext _context = new DataContext();
        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void btn_fileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_arac.Image = new Bitmap(ofd.FileName);
                fileName.Text = ofd.FileName;
            }
        }

        private void btn_aracEkle_Click(object sender, EventArgs e)
        {
            string base64;
            // Dispose
            using (Image image = pictureBox_arac.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }

            if (pictureBox_arac.Image == null)
            {
                MessageBox.Show("Lütfen bir resim seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (IsNull(txt_plaka.Text) || IsNull(txt_model.Text) || IsNull(txt_marka.Text) || IsNull(txt_gunlukFiyat.Text) || IsNull(cmb_aracTipi.Text) || IsNull(cmb_vitestur.Text) || IsNull(cmb_yakitTipi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!double.TryParse(txt_gunlukFiyat.Text, out double result))
            {
                MessageBox.Show("Fiyat alanı sayısal olmalıdır!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Araba araba = new Araba()
            {
                Plaka = txt_plaka.Text,
                Marka = txt_marka.Text,
                Model = txt_model.Text,
                Vites = cmb_vitestur.Text,
                YakitTipi = cmb_yakitTipi.Text,
                AracTipi = cmb_aracTipi.Text,
                Fiyat = Convert.ToDouble(txt_gunlukFiyat.Text),
                AktifMi = true,
                AddDate = DateTime.Now,
                ImageUrl = base64

            };

            _context.Arabalar.Add(araba);
            _context.SaveChanges();
            MessageBox.Show("Araç başarıyla kaydedildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }
        private bool IsNull(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true; // nullsa true döner.
            }
            return false;
        }

        private string ConvertImageToBase64(Image image)
        {
            // Image'i base64 string'e çevir.
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
