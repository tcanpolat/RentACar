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
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void linklbl_kayitform_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullaniciKayit frmKullaniciKayit = new frmKullaniciKayit();
            frmKullaniciKayit.Show();
        }
    }
}
