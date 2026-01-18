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
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }

   
        private void btn_Yönetici_Girişi_Click(object sender, EventArgs e)
        {
            Yönetici_Girişi Yönetici_Girişi = new Yönetici_Girişi();
            Yönetici_Girişi.Show();
            this.Hide();
        }

        private void btn_Personel_Girişi_Click(object sender, EventArgs e)
        {
            Personel_Girişi Personel_Girişi = new Personel_Girişi();
            Personel_Girişi.Show();
            this.Hide();
        }

      
        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
