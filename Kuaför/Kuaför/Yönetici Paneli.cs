using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuaför
{
    public partial class Yönetici_Paneli : Form
    {
        public Yönetici_Paneli()
        {
            InitializeComponent();
        }

        private void btn_Personel_Yönetimi_Click(object sender, EventArgs e)
        {
            Personel_Yönetimi Personel_Yönetimi = new Personel_Yönetimi();
            Personel_Yönetimi.Show();
            this.Hide();
        }
        private void btn_Ödeme_Yönetimi_Click(object sender, EventArgs e)
        {
            Ödeme_Yönetimi Ödeme_Yönetimi = new Ödeme_Yönetimi();
            Ödeme_Yönetimi.Show();
            this.Hide();
        }

        private void btn_Envanter_Yönetimi_Click(object sender, EventArgs e)
        {
            Envanter_Yönetimi Envanter_Yönetimi = new Envanter_Yönetimi();
            Envanter_Yönetimi.Show();
            this.Hide();              
        }

        private void btn_Randevu_Yönetimi_Click(object sender, EventArgs e)
        {
            Randevu_Yönetimi Randevu_Yönetimi = new Randevu_Yönetimi();
            Randevu_Yönetimi.Show();
            this.Hide();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Yönetici_Girişi Yönetici_Girişi = new Yönetici_Girişi();
            Yönetici_Girişi.Show();
            this.Hide();
        }

        private void Yönetici_Paneli_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hesap_Yönetimi_Click(object sender, EventArgs e)
        {
            Hesap_Yönetimi hesap_yönetimi = new Hesap_Yönetimi();
            hesap_yönetimi.Show();
            this.Hide();
        }
    }
}
