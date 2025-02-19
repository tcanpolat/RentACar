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
            if(!MandatoryAreasControl(txt_ad.Text, label_adError)) { return;}
            if (!MandatoryAreasControl(txt_adres.Text, label_adresError)) { return; }
            if(!MandatoryAreasControl(txt_ehliyetno.Text, label_ehliyetnoError)) { return; }
            if(!MandatoryAreasControl(txt_email.Text, label_emailError)) { return; }
            if(!MandatoryAreasControl(txt_parola.Text, label_parolaErrorr)) { return; }
            if(!MandatoryAreasControl(txt_soyad.Text, label_soyadError)) { return; }
            if(!MandatoryAreasControl(txt_tc.Text, label_tcErrorr)) { return; }
            if(!MandatoryAreasControl(txt_telefon.Text, label_telefonError)) { return; }

            List<Yonetici> ynt = new List<Yonetici>();
            ynt = _context.Yoneticiler.ToList();
            bool kullaniciVar = false;

            foreach (var yonetici in ynt)
            {
                if(yonetici.TC == txt_tc.Text)
                {
                    kullaniciVar = true;
                }
            }

            if (kullaniciVar)
            {
                MessageBox.Show("Bu Tc ile daha önce kayıtlı bir yönetici mevcut!");
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

        }
        public bool MandatoryAreasControl(string text, Label label)
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                label.Text = "Bu alan zorunludur!";
                return false;
            }
            return true;
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
            label_adError.Text = "";
        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {
            label_soyadError.Text = "";
        }

        private void txt_ehliyetno_TextChanged(object sender, EventArgs e)
        {
            label_ehliyetnoError.Text = "";
        }

        private void txt_telefon_TextChanged(object sender, EventArgs e)
        {
            label_telefonError.Text = "";
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            label_emailError.Text = "";
        }

        private void txt_adres_TextChanged(object sender, EventArgs e)
        {
            label_adresError.Text = "";
        }
    }
}
