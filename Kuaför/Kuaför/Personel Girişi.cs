using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kuaför
{
    public partial class Personel_Girişi : Form
    {
        public Personel_Girişi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Personel.mdb");

        private void btn_Giriş_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Personel WHERE [Kullanıcı Adı] = @KullaniciAdi AND Şifre = @Sifre", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", txt_Kullanıcı_Adı.Text);
            komut.Parameters.AddWithValue("@Sifre", txt_Şifre.Text);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read() && string.Equals(txt_Kullanıcı_Adı.Text, oku["Kullanıcı Adı"].ToString(), StringComparison.Ordinal) && string.Equals(txt_Şifre.Text, oku["Şifre"].ToString(), StringComparison.Ordinal))
            {
                Personel_Paneli personelPaneli = new Personel_Paneli();
                personelPaneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız... Tekrar Deneyin.", "Uyarı");
            }

            baglanti.Close();
        }
        private void Personel_Girişi_Load(object sender, EventArgs e)
        {

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Ana_Sayfa Ana_Sayfa = new Ana_Sayfa();
            Ana_Sayfa.Show();
            this.Hide();
        }

        private void checkbox_Şifreyi_Göster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Şifreyi_Göster.Checked == true)
            {
                txt_Şifre.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Şifre.UseSystemPasswordChar = true;
            }
        }

        
    }
}
