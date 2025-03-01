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
    public partial class frmKiralamalar : Form
    {
        DataContext _context = new DataContext();
        public string kid;
        public int kiralamaID;

        public frmKiralamalar()
        {
            InitializeComponent();
        }

        private void frmKiralamalar_Load(object sender, EventArgs e)
        {
            dgv_kiralamalar.DataSource = _context.Kiralamalar.ToList();
            dgv_kiralamalar.Columns[0].Visible = false;
            dgv_kiralamalar.Columns[1].Visible = false;
            dgv_kiralamalar.Columns[2].Visible = false;
            dgv_kiralamalar.Columns[3].Visible = false;
            dgv_kiralamalar.Columns[8].Visible = false;
            // Ödev hangi araç ise o aracın plakası datagridviewe yazılacak.
        }

        private void dgv_kiralamalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmKiralamaYonet frmKiralamaYonet = new frmKiralamaYonet();
            kiralamaID = int.Parse(dgv_kiralamalar.CurrentRow.Cells[8].Value.ToString());
            frmKiralamaYonet.kiralamaID = kiralamaID;
            frmKiralamaYonet.Show();
            this.Hide();
        }
    }
}
