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
    public partial class frmKiralamaYonet : Form
    {
        DataContext _context = new DataContext();
        public int kiralamaID;

        public frmKiralamaYonet()
        {
            InitializeComponent();
        }

        private void frmKiralamaYonet_Load(object sender, EventArgs e)
        {
            var kiralama = _context.Kiralamalar.Where(k => k.ID == kiralamaID).FirstOrDefault();
            if (kiralama == null)
            {
                MessageBox.Show("Kiralama bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lbl_alistarihi.Text = kiralama.AlisTarihi.ToString();
            lbl_teslimtarihi.Text = kiralama.TeslimTarihi.ToString();
            chck_kiradami.Checked = kiralama.AktifMi;
           
        }

        private void btn_kiralama_guncelle_Click(object sender, EventArgs e)
        {
            Kiralama kiralama = _context.Kiralamalar.Where(k => k.ID == kiralamaID).FirstOrDefault();
            kiralama.AktifMi = chck_kiradami.Checked;
            if(kiralama == null) { MessageBox.Show("Kiralama bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Araba arabalar = _context.Arabalar.FirstOrDefault(a => a.ID == kiralama.ArabaID);
            if(arabalar == null) { MessageBox.Show("Araç bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); return;  }

            if(kiralama.AktifMi == true)
            {
                arabalar.AktifMi = false;
            }
            else
            {
                arabalar.AktifMi=true;
            }
            // Aracında aktif durumu değişecek.
            kiralama.TeslimTarihi=dateTimePicker_güncellenmisTarih.Value;
            label_güncellenmisFiyat.Text= kiralama.KiralamaSuresi.Value.ToString();

            _context.SaveChanges();
            MessageBox.Show("Kira durumu güncellendi", "Başarılı İşlem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
