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

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_arac.Image = new Bitmap(ofd.FileName);
                fileName.Text = ofd.FileName;
            }
        }

        private void btn_aracEkle_Click(object sender, EventArgs e)
        {
            string base64;
           if(!NullControl()) { return; }
            // Dispose
            using (Image image = pictureBox_arac.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }

            // Ödev.
            // Araç ile ilgili kontroller yapılacak. Örneğin fiyatın string olmaması

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
            MessageBox.Show("Araç başarıyla kaydedildi.");
            this.Hide();
           
        }
        public bool NullControl()
        {
            if (pictureBox_arac.Image == null)
            {
                label_resimError.Text = "Bir araç resmi yükleyiniz!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_gunlukFiyat.Text))
            {
                label_fiyatError.Text = "Bir fiyat değeri giriniz!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_marka.Text))
            {
                label_MarkaError.Text = "Bir marka değeri giriniz!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_model.Text))
            {
                label_modelError.Text = "Bir model değeri giriniz!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_plaka.Text))
            {
                label_PlakaError.Text = "Bir plaka değeri giriniz!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmb_aracTipi.Text))
            {
                label_AracTipiError.Text = "Bir araç tipi seçiniz!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmb_vitestur.Text))
            {
                label_vitesError.Text = "Bir vites türü seçiniz!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(cmb_yakitTipi.Text))
            {
                label_YakıtError.Text = "Bir yakıt türü seçiniz!";
                return false;
            }
            return true;
        }

        private string ConvertImageToBase64(Image image)
        {
            // Image i base64 string e çevir
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void txt_plaka_TextChanged(object sender, EventArgs e)
        {
            label_PlakaError.Text = "";
        }

        private void txt_marka_TextChanged(object sender, EventArgs e)
        {
            label_MarkaError.Text = "";
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {
            label_modelError.Text = "";
        }

        private void cmb_aracTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_AracTipiError.Text = "";
        }

        private void cmb_vitestur_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_vitesError.Text = "";
        }

        private void cmb_yakitTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_YakıtError.Text = "";
        }

        private void txt_gunlukFiyat_TextChanged(object sender, EventArgs e)
        {
            label_fiyatError.Text = "";
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {
            label_resimError.Text = "";
        }
    }
}
