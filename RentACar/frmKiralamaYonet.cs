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
        public string plaka;
        public frmKiralamaYonet()
        {
            InitializeComponent();
        }

        private void frmKiralamaYonet_Load(object sender, EventArgs e)
        {
            var kiralama = _context.Kiralamalar.Where(k => k.ID == kiralamaID).FirstOrDefault();
            dtp_alistarihi.Text = kiralama.AlisTarihi.ToString();
            dtp_teslimtarihi.Text = kiralama.TeslimTarihi.ToString();
            dtp_teslimtarihi.MinDate = kiralama.TeslimTarihi.AddDays(-5);
            dtp_teslimtarihi.MaxDate = kiralama.TeslimTarihi.AddDays(5);
            dtp_alistarihi.MinDate = kiralama.AlisTarihi.AddDays(-5);
            dtp_alistarihi.MaxDate = kiralama.AlisTarihi.AddDays(5);
            chck_kiradami.Checked = kiralama.AktifMi;
            lbl_plaka.Text = plaka;
        }

        private void btn_kiralama_guncelle_Click(object sender, EventArgs e)
        {
            if (dtp_teslimtarihi.Value<=dtp_alistarihi.Value)
            {
                MessageBox.Show("Teslim tarihi alış tarihinden küçük olamaz.");
            }
            else
            { 
                Kiralama kiralama = _context.Kiralamalar.Where(k => k.ID == kiralamaID).FirstOrDefault();
                kiralama.AktifMi = chck_kiradami.Checked;
                Araba araba = _context.Arabalar.Where(a => a.ID == kiralama.ArabaID).FirstOrDefault();
                araba.AktifMi = chck_kiradami.CheckState == CheckState.Checked ? false : true;
                kiralama.AlisTarihi = dtp_alistarihi.Value;
                kiralama.TeslimTarihi = dtp_teslimtarihi.Value;
                // Aracında aktif durumu değişecek.
                _context.SaveChanges();
                MessageBox.Show("Kira durumu güncellendi");
                this.Hide();
            }
        }
    }
}
