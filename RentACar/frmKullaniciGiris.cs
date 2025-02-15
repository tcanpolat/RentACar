using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmKullaniciGiris : Form
    {
        DataContext _context = new DataContext();
        string TC = "";
        string sifre = "";
        int id;
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void linklbl_kayitform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullaniciKayit frmKullaniciKayit = new frmKullaniciKayit();
            frmKullaniciKayit.ShowDialog();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if(!AllValidationOperations())
            {
                return;
            }
        }

        public bool AllValidationOperations()
        {
            bool isValid = true;
            List<Yonetici> ynt = new List<Yonetici>();
            ynt = _context.Yoneticiler.Where(y => y.TC == txt_tc.Text).ToList();

            //String değer kontrolü yaptık.
            IsNullOrWhiteSpaceControl(txt_tc.Text, "Tc Kimlik No", label_tc_error, label_tc);
            IsNullOrWhiteSpaceControl(txt_parola.Text, "Parola", label_parola_error, label_parola);
            
            //Eğer bu liste'nin count'u 0 gelirse listeye hiçbir şey atamamıştır. Yani veritabanında bu TC'ye ait bir kullanıcı yoktur.
            //Bu sebeple kullanıcı bulunamadı mesajı verebiliriz.
            //Bu işleme #guard close (koruyucu koşul) ismi veriliyor.
            if (ynt.Count == 0)
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            foreach (var yonetici in ynt)
            {
                TC = yonetici.TC.ToString();
                sifre = yonetici.Sifre.ToString();
                id = yonetici.ID;
            }

            if (TC == txt_tc.Text)
            {
                if (sifre == txt_parola.Text)
                {
                    // Anasayfa formu açılacak.
                    frmYoneticiPanel frmYoneticiPanel = new frmYoneticiPanel();
                    frmYoneticiPanel.kid = id.ToString();
                    this.Hide();
                    frmYoneticiPanel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifreniz hatalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }
            }
            else
            {
                MessageBox.Show("TC'niz hatalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            return isValid;
        }
        //String null-whiteSpace kontrolü
        public bool IsNullOrWhiteSpaceControl(string text, string title, Label errorMessage, Label addStarToTitle)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                errorMessage.Text = $"{title} boş olamaz!";
                if (!addStarToTitle.Text.Contains("*"))
                {
                    addStarToTitle.Text += "*";
                }
                return true;
            }
            return false;
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            label_tc_error.Text = "";
            if (label_tc.Text.EndsWith("*"))
            {
                label_tc.Text = label_tc.Text.Remove(label_tc.Text.Length - 1);
            }
        }

        private void txt_parola_TextChanged(object sender, EventArgs e)
        {
            label_parola_error.Text = "";
            if (label_parola.Text.EndsWith("*"))
            {
                label_parola.Text = label_parola.Text.Remove(label_parola.Text.Length - 1);
            }
        }
    }
}

