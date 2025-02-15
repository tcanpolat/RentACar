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
    public partial class frmYoneticiPanel : Form
    {
        public string kid;
        public frmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void frmYoneticiPanel_Load(object sender, EventArgs e)
        {

        }

        private void tsb_kiralamalar_MouseHover(object sender, EventArgs e)
        {
            tsl_kiralamalar.Visible = true;
        }

        private void tsb_kiralamalar_MouseLeave(object sender, EventArgs e)
        {
            tsl_kiralamalar.Visible = false;
        }

        private void tsb_aracekle_MouseHover(object sender, EventArgs e)
        {
            tsl_aracekle.Visible = true;
        }

        private void tsb_aracekle_MouseLeave(object sender, EventArgs e)
        {
            tsl_aracekle.Visible= false;
        }

        private void tsb_araclistesi_MouseHover(object sender, EventArgs e)
        {
            tsl_araclistesi.Visible = true;
        }

        private void tsb_araclistesi_MouseLeave(object sender, EventArgs e)
        {
            tsl_araclistesi.Visible= false;
        }

        private void tsb_aracekle_Click(object sender, EventArgs e)
        {
            frmAracEkle frmAracEkle = new frmAracEkle();
            frmAracEkle.Show();
        }
    }
}
