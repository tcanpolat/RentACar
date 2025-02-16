using RentACar.ORM.Context;
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
    public partial class frmAracListesi : Form
    {
        DataContext _context = new DataContext();
        public string kid;
        public int id;
        public frmAracListesi()
        {
            InitializeComponent();
        }

        private void frmAracListesi_Load(object sender, EventArgs e)
        {
            dgv_aracListesi.DataSource = _context.Arabalar.Where(a => a.AktifMi == true).ToList();
            dgv_aracListesi.Columns[6].Visible = false;
            dgv_aracListesi.Columns[8].Visible = false;
            dgv_aracListesi.Columns[10].Visible = false;
            dgv_aracListesi.Columns[11].Visible = false;
            dgv_aracListesi.Columns[9].HeaderText = "Eklenme Tarihi";
        }

        private void dgv_aracListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmAracDetayVeKirala frmAracDetayVeKirala = new frmAracDetayVeKirala();
            frmAracDetayVeKirala.kid = kid;
            id = int.Parse(dgv_aracListesi.CurrentRow.Cells["ID"].Value.ToString());
            frmAracDetayVeKirala.id = id;
            frmAracDetayVeKirala.Show();
        }
    }
}
