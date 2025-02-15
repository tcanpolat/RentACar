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
            List<Yonetici> ynt = new List<Yonetici>();
            ynt = _context.Yoneticiler.Where(y => y.TC == txt_tc.Text).ToList();

            foreach (var yonetici in ynt)
            {
                TC = yonetici.TC.ToString();
                sifre = yonetici.Sifre.ToString();
                id = yonetici.ID;
            }

            if(TC == txt_tc.Text)
            {
                if(sifre == txt_parola.Text)
                {
                    // Anasayfa formu açılacak.
                    frmYoneticiPanel frmYoneticiPanel = new frmYoneticiPanel();
                    frmYoneticiPanel.kid = id.ToString();
                    this.Hide();
                    frmYoneticiPanel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifreniz hatalıdır!");
                }
            }
            else
            {
                MessageBox.Show("TC'niz hatalıdır!");
            }


        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
