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
            InputsValidationControl();
            string base64;
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
            this.Close();
           
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
        public bool StringIsNullOrWhiteSpaceControl(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        private bool InputsValidationControl()
        {
            bool isStatus = true;

            if (StringIsNullOrWhiteSpaceControl(txt_marka.Text))
            {
                label_MarkaError.Text = "Marka alanı boş girilemez!";
                isStatus = false;
            }
            else if (txt_marka.Text.Length < 3)
            {
                label_MarkaError.Text = "Marka alanı 3 karakterden az olamaz!";
                isStatus = false;
            }

            if (StringIsNullOrWhiteSpaceControl(txt_model.Text))
            {
                label_ModelError.Text = "Model alanı boş girilemez!";
                isStatus = false;
            }
            else if (txt_model.Text.Length < 2)
            {
                label_ModelError.Text = "Model alanı 2 karakterden az olamaz!";
                isStatus = false;
            }

            if (StringIsNullOrWhiteSpaceControl(txt_plaka.Text))
            {
                label_PlakaError.Text = "Plaka alanı boş girilemez!";
                isStatus = false;
            }

            if (StringIsNullOrWhiteSpaceControl(txt_gunlukFiyat.Text))
            {
                label_FiyattypeError.Text = "Fiyat alanı boş girilemez!";
                isStatus = false;
            }
            else if (!decimal.TryParse(txt_gunlukFiyat.Text, out decimal result))
            {
                label_FiyattypeError.Text = "Fiyat alanı bir sayı olmalıdır!";
                isStatus = false;
            }
            else if (txt_gunlukFiyat.Text.Length < 3)
            {
                label_FiyattypeError.Text = "Fiyat alanı 3 karakterden az olamaz!";
                isStatus = false;
            }

            if (cmb_aracTipi.SelectedItem == null)
            {
                label_AracTipiError.Text = "Araç tipi seçiniz!";
                isStatus = false;
            }

            if (cmb_vitestur.SelectedItem == null)
            {
                label_VitesError.Text = "Bir vites türü seçiniz!";
                isStatus = false;
            }
            
            if(cmb_yakitTipi.SelectedItem == null)
            {
                label_yakıttipi.Text = "Bir yakıt tipi seçiniz!";
                isStatus = false;
            }
            return isStatus;

        }

        private void frmAracEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
