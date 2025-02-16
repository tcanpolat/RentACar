using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmKullaniciKayit : Form
    {
        DataContext _context = new DataContext();
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            if (!AllValidationOperations())
            {
                return;
            }

        }
        public bool AllValidationOperations()
        {
            try
            {
                //Input validation diye oluşturduğum metot, içinde StringNullOrWhiteSpace diye oluşturduğum metotları kullanarak kontrolleri yapacak ardından çalışacak. 
                //Eğer Input Validation false dönerse, tüm doğrulama operasyonları da false dönsün. 
                if (!InputValidation())
                {
                    return false;
                }

                List<Yonetici> ynt = new List<Yonetici>();
                ynt = _context.Yoneticiler.ToList();
                bool kullaniciVar = false;

                foreach (var yonetici in ynt)
                {
                    if (yonetici.TC == txt_tc.Text)
                    {
                        kullaniciVar = true;
                    }
                }

                if (kullaniciVar)
                {
                    MessageBox.Show("Bu Tc ile daha önce kayıtlı bir yönetici mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // ÖDEV
                    // TC - Şifre - Telefon - EhliyetNo zorunlu alanlar olacak.
                    // ORM => Object Relational Mapping
                    Yonetici yonetici = new Yonetici()
                    {
                        Adi = txt_ad.Text,
                        Soyadi = txt_soyad.Text,
                        EhliyetNo = txt_ehliyetno.Text,
                        TC = txt_tc.Text,
                        Sifre = txt_parola.Text,
                        Adres = txt_adres.Text,
                        Email = txt_email.Text,
                        Telefon = txt_telefon.Text,
                        AktifMi = true,
                        AddDate = DateTime.Now

                    };

                    _context.Yoneticiler.Add(yonetici);
                    _context.SaveChanges();
                    MessageBox.Show("Kayıt oluşturuldu.");
                    this.Hide();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu! {ex.Message}","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool StringNullOrWhiteSpaceControl(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }
        public bool InputValidation()
        {
            bool isStatus = true;
            if (StringNullOrWhiteSpaceControl(txt_ad.Text))
            {
                label_adError.Text = "İsim alanı boş girilemez!";
                if (!label_ad.Text.Contains("*"))
                {
                    label_ad.Text += "*";
                }
                isStatus = false;
            }
            else if (txt_ad.Text.Length < 2)
            {
                label_adError.Text = "İsim alanı 2 karakterden az olamaz!";
                isStatus = false;
            }
            else
            {
                label_adError.Text = "";
            }

            if (StringNullOrWhiteSpaceControl(txt_soyad.Text))
            {
                label_soyadError.Text = "Soyisim alanı boş girilemez!";
                if (!label_soyad.Text.Contains("*"))
                {
                    label_soyad.Text += "*";
                }
                isStatus = false;
            }
            else if (txt_soyad.Text.Length < 2)
            {
                label_soyadError.Text = "Soyisim alanı 2 karakterden az olamaz!";
                isStatus = false;
            }
            else
            {
                label_soyadError.Text = "";
            }

            if (StringNullOrWhiteSpaceControl(txt_adres.Text))
            {
                label_adresError.Text = "Adres alanı boş girilemez!";
                if (!label_adres.Text.Contains("*"))
                {
                    label_adres.Text += "*";
                }
                isStatus = false;
            }
            else
            {
                label_adresError.Text = "";
            }

            if (StringNullOrWhiteSpaceControl(txt_email.Text))
            {
                label_emailError.Text = "Email alanı boş girilemez!";
                if (!label_email.Text.Contains("*"))
                {
                    label_email.Text += "*";
                }
                isStatus = false;
            }
            else
            {
                label_emailError.Text = "";
            }
            if (StringNullOrWhiteSpaceControl(txt_ehliyetno.Text))
            {
                label_ehliyetnoError.Text = "Ehliyet numarası alanı boş girilemez!";
                if (!label_ehliyetNo.Text.Contains("*"))
                {
                    label_ehliyetNo.Text += "*";
                }
                isStatus = false;
            }
            else if (txt_ehliyetno.Text.Length < 6)
            {
                label_ehliyetnoError.Text = "Ehliyet numarası alanı 6 karakterden az olamaz!";
                isStatus = false;
            }
            else if (!decimal.TryParse(txt_ehliyetno.Text, out decimal result))
            {
                label_ehliyetnoError.Text = "Ehliyet numarası alanı sayısal bir değer olmalıdır!";
                isStatus = false;
            }
            else if (_context.Yoneticiler.Any(y => y.EhliyetNo == txt_ehliyetno.Text))
            {
                label_ehliyetnoError.Text = "Bu ehliyet numarası ile daha önceden kayıt oluşturulmuş!";
                isStatus = false;
            }
            else
            {
                label_ehliyetnoError.Text = "";
            }

            if (StringNullOrWhiteSpaceControl(txt_parola.Text))
            {
                label_parolaError.Text = "Parola alanı boş girilemez!";
                if (!label_parola.Text.Contains("*"))
                {
                    label_parola.Text += "*";
                }
                isStatus = false;
            }
            else
            {
                label_parolaError.Text = "";
            }

            if (StringNullOrWhiteSpaceControl(txt_telefon.Text))
            {
                label_telefonError.Text = "Telefon alanı boş girilemez!";
                if (!label_telefon.Text.Contains("*"))
                {
                    label_telefon.Text += "*";
                }
                isStatus = false;
            }
            else if (txt_telefon.Text.Length < 10)
            {
                label_telefonError.Text = "Telefon alanı 10 karakterden az olamaz!";
                isStatus = false;
            }
            else if (!decimal.TryParse(txt_telefon.Text, out decimal result))
            {
                label_telefonError.Text = "Telefon alanı sayısal bir değer olmalıdır!";
                isStatus = false;
            }
            else if (_context.Yoneticiler.Any(y => y.Telefon == txt_telefon.Text))
            {
                label_telefonError.Text = "Bu telefon numarası ile daha önceden kayıt oluşturulmuş!";
                isStatus = false;
            }
            else
            {
                label_telefonError.Text = "";
            }

            if (StringNullOrWhiteSpaceControl(txt_tc.Text))
            {
                label_tcError.Text = "TC alanı boş girilemez!";
                if (label_tc.Text.Contains("*"))
                {
                    label_tc.Text += "*";
                }
                isStatus = false;
            }
            else if (txt_tc.Text.Length < 11)
            {
                label_tcError.Text = "TC alanı 11 karakterden az olamaz!";
                isStatus = false;
            }
            else if (!decimal.TryParse(txt_tc.Text, out decimal result))
            {
                label_tcError.Text = "TC alanı sayısal bir değer olmalıdır!";
                isStatus = false;
            }
            else if (_context.Yoneticiler.Any(y => y.TC == txt_tc.Text))
            {
                label_tcError.Text = "Bu TC numarası ile daha önceden kayıt oluşturulmuş!";
                isStatus = false;
            }
            else
            {
                label_tcError.Text = "";
            }

            return isStatus;
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
            label_adError.Text = "";
            if (label_ad.Text.EndsWith("*"))
            {
                label_ad.Text = label_ad.Text.Remove(label_ad.Text.Length - 1);
            }
        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {
            label_soyadError.Text = "";
            if (label_soyad.Text.EndsWith("*"))
            {
                label_soyad.Text = label_soyad.Text.Remove(label_soyad.Text.Length - 1);
            }
        }

        private void txt_ehliyetno_TextChanged(object sender, EventArgs e)
        {
            label_ehliyetnoError.Text = "";
            if (label_ehliyetNo.Text.EndsWith("*"))
            {
                label_ehliyetNo.Text = label_ehliyetNo.Text.Remove(label_ehliyetNo.Text.Length - 1);
            }
        }

        private void txt_telefon_TextChanged(object sender, EventArgs e)
        {
            label_telefonError.Text = "";
            if (label_telefon.Text.EndsWith("*"))
            {
                label_telefon.Text = label_telefon.Text.Remove(label_telefon.Text.Length - 1);
            }
        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            label_tcError.Text = "";
            if (label_tc.Text.EndsWith("*"))
            {
                label_tc.Text = label_tc.Text.Remove(label_tc.Text.Length - 1);
            }
        }

        private void txt_parola_TextChanged(object sender, EventArgs e)
        {
            label_parolaError.Text = "";
            if (label_parola.Text.EndsWith("*"))
            {
                label_parola.Text = label_parola.Text.Remove(label_parola.Text.Length - 1);
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            label_emailError.Text = "";
            if (label_email.Text.EndsWith("*"))
            {
                label_email.Text = label_email.Text.Remove(label_email.Text.Length - 1);
            }
        }

        private void txt_adres_TextChanged(object sender, EventArgs e)
        {
            label_adresError.Text = "";
            if (label_adres.Text.EndsWith("*"))
            {
                label_adres.Text = label_adres.Text.Remove(label_adres.Text.Length - 1);
            }
        }
    }
}
