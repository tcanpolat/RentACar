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
            //Eğer boş alanlar varsa, bu alanlar için hata göstersin. Doğruysa kayıt işlemi yapılsın.
            if (!InputsValidationControl())
            {
                return;
            }
            //Araç resmi seçilmezse uyarı verilsin.
            if (pictureBox_arac.Image == null)
            {
                MessageBox.Show("Lütfen bir araç resmi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        public bool InputsValidationControl()
        {
            bool isStatus = true;

            if (StringIsNullOrWhiteSpaceControl(txt_marka.Text))
            {
                label_MarkaError.Text = "Marka alanı boş girilemez!";
                if (!label_marka.Text.Contains("*"))
                {
                    label_marka.Text += "*";
                }
                isStatus = false;
            }
            else if (txt_marka.Text.Length < 3)
            {
                label_MarkaError.Text = "Marka alanı 3 karakterden az olamaz!";
                isStatus = false;
            }
            else
            { label_MarkaError.Text = ""; }

            if (StringIsNullOrWhiteSpaceControl(txt_model.Text))
            {
                label_ModelError.Text = "Model alanı boş girilemez!";
                if (!label_model.Text.Contains("*"))
                {
                    label_model.Text += "*";
                }
                isStatus = false;
            }
            else if (txt_model.Text.Length < 2)
            {
                label_ModelError.Text = "Model alanı 2 karakterden az olamaz!";
                isStatus = false;
            }
            else { label_ModelError.Text = ""; }

            if (StringIsNullOrWhiteSpaceControl(txt_plaka.Text))
            {
                label_PlakaError.Text = "Plaka alanı boş girilemez!";
                if (!label_plaka.Text.Contains("*"))
                {
                    label_plaka.Text += "*";
                }
                isStatus = false;
            }
            else { label_PlakaError.Text = ""; }

            if (StringIsNullOrWhiteSpaceControl(txt_gunlukFiyat.Text))
            {
                label_FiyattypeError.Text = "Fiyat alanı boş girilemez!";
                if (!label_günlükfiyat.Text.Contains("*"))
                {
                    label_günlükfiyat.Text += "*";
                }
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
            else { label_FiyattypeError.Text = ""; }

            if (cmb_aracTipi.SelectedItem == null)
            {
                label_AracTipiError.Text = "Araç tipi seçiniz!";
                if (!label_aractipi.Text.Contains("*"))
                {
                    label_aractipi.Text += "*";
                }
                isStatus = false;
            }
            else { label_AracTipiError.Text = ""; }

            if (cmb_vitestur.SelectedItem == null)
            {
                label_VitesError.Text = "Bir vites türü seçiniz!";
                if (!label_vites.Text.Contains("*"))
                {
                    label_vites.Text += "*";
                }
                isStatus = false;
            }
            else { label_VitesError.Text = ""; }

            if (cmb_yakitTipi.SelectedItem == null)
            {
                label_YakıtTypeError.Text = "Bir yakıt tipi seçiniz!";
                if (!label_yakıttipi.Text.Contains("*"))
                {
                    label_yakıttipi.Text += "*";
                }
                isStatus = false;
            }
            else { label_YakıtTypeError.Text = ""; }

            if (StringIsNullOrWhiteSpaceControl(fileName.Text))
            {
                label_AracResmiError.Text = "Bir resim seçiniz!";
                if (!label_aracresmi.Text.Contains("*"))
                {
                    label_aracresmi.Text += "*";
                }
                isStatus = false;
            }
            else { label_AracResmiError.Text = ""; }

            return isStatus;

        }

        private void frmAracEkle_Load(object sender, EventArgs e)
        {

        }

        private void txt_plaka_TextChanged(object sender, EventArgs e)
        {
            label_PlakaError.Text = "";
            if (label_plaka.Text.EndsWith("*"))
            {
                label_plaka.Text = label_plaka.Text.Remove(label_plaka.Text.Length - 1);
            }
        }

        private void txt_marka_TextChanged(object sender, EventArgs e)
        {
            label_MarkaError.Text = "";
            if( label_marka.Text.EndsWith("*"))
            {
                label_marka.Text = label_marka.Text.Remove(label_marka.Text.Length - 1);
            }
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {
            label_ModelError.Text = "";
            if(label_model.Text.EndsWith("*"))
            {
                label_model.Text = label_model.Text.Remove(label_model.Text.Length - 1);
            }
        }

        private void cmb_aracTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_AracTipiError.Text = "";
            if(label_aractipi.Text.EndsWith("*"))
            {
                label_aractipi.Text = label_aractipi.Text.Remove(label_aractipi.Text.Length - 1);
            }
        }

        private void cmb_vitestur_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_VitesError.Text = "";
            if(label_vites.Text.EndsWith("*"))
            {
                label_vites.Text = label_vites.Text.Remove(label_vites.Text.Length - 1);
            }
        }

        private void cmb_yakitTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_YakıtTypeError.Text = "";
            if(label_yakıttipi.Text.EndsWith("*"))
            {
                label_yakıttipi.Text = label_yakıttipi.Text.Remove(label_yakıttipi.Text.Length - 1);
            }
        }

        private void txt_gunlukFiyat_TextChanged(object sender, EventArgs e)
        {
            label_FiyattypeError.Text = "";
            if(label_günlükfiyat.Text.EndsWith("*"))
            {
                label_günlükfiyat.Text = label_günlükfiyat.Text.Remove(label_günlükfiyat.Text.Length - 1);
            }
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {
            label_AracResmiError.Text = "";
            if(label_aracresmi.Text.EndsWith("*"))
            {
                label_aracresmi.Text = label_aracresmi.Text.Remove(label_aracresmi.Text.Length - 1);
            }
        }
    }
}
