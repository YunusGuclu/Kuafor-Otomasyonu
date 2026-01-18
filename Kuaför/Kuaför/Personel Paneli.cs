using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuaför
{
    public partial class Personel_Paneli : Form
    {
        public Personel_Paneli()
        {
            InitializeComponent();
        }

       
        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Personel_Girişi Personel_Girişi = new Personel_Girişi();
            Personel_Girişi.Show();
            this.Hide();
        }
        private void btn_Randevu_Yönetimi_Click(object sender, EventArgs e)
        {
            Randevu_İşlemleri randevu_İşlemleri = new Randevu_İşlemleri();
            randevu_İşlemleri.Show();
            this.Hide();
        }

        private void btn_Ödeme_İşlemleri_Click(object sender, EventArgs e)
        {
            Ödeme_İşlemleri Ödeme_İşlemleri = new Ödeme_İşlemleri();
            Ödeme_İşlemleri.Show();
            this.Hide();
        }

      
    }
}
