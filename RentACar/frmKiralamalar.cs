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
using System.Data.Entity;

namespace RentACar
{
    public partial class frmKiralamalar : Form
    {
        DataContext _context = new DataContext();
        public string kid;
        public int kiralamaID;
        public string plaka;
        public frmKiralamalar()
        {
            InitializeComponent();
        }

        private void frmKiralamalar_Load(object sender, EventArgs e)
        {
            var kiralamalar = _context.Kiralamalar
         .Include(k => k.Araba) 
         .Select(k => new
         {
             k.ID,
             k.YoneticiID,
             Plaka = k.Araba.Plaka,
             k.AlisTarihi,
             k.TeslimTarihi,
             k.FaturaTutari,
             k.KiralamaSuresi,
             k.AddDate,
             k.UpdateDate,
             k.DeleteDate,
             k.AktifMi
         })
         .ToList();
            dgv_kiralamalar.DataSource = kiralamalar;
            dgv_kiralamalar.Columns[0].Visible = false;
            dgv_kiralamalar.Columns[1].Visible = false;
           

            // Ödev hangi araç ise o aracın plakası datagridviewe yazılacak.
        }

        private void dgv_kiralamalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmKiralamaYonet frmKiralamaYonet = new frmKiralamaYonet();
            kiralamaID = int.Parse(dgv_kiralamalar.CurrentRow.Cells[0].Value.ToString());
            plaka = dgv_kiralamalar.CurrentRow.Cells[2].Value.ToString();
            frmKiralamaYonet.kiralamaID = kiralamaID;
            frmKiralamaYonet.plaka = plaka;
            frmKiralamaYonet.Show();
            this.Hide();
        }
    }
}
