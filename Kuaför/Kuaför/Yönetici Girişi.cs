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
    public partial class Yönetici_Girişi : Form
    {
        public Yönetici_Girişi()
        {
            InitializeComponent();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Yönetici.mdb");

        private void btn_Giriş_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Yönetici WHERE kullanıcıadı = @kullanıcıadı AND parola = @parola", baglanti);
            komut.Parameters.Add("kullanıcıadı", txt_Kullanıcı_Adı.Text);
            komut.Parameters.Add("parola", txt_Şifre.Text);

            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read() && string.Equals(txt_Kullanıcı_Adı.Text, oku["kullanıcıadı"].ToString(), StringComparison.Ordinal) && string.Equals(txt_Şifre.Text, oku["parola"].ToString(), StringComparison.Ordinal))
            {
                Yönetici_Paneli Yönetici_Paneli = new Yönetici_Paneli();
                Yönetici_Paneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...Tekrar Deneyin.", "Uyarı");
            }
            baglanti.Close();
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

        
        private void link_Şifreyi_Unuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şifreyi_Unuttum sifreyi_Unuttum = new Şifreyi_Unuttum();
            sifreyi_Unuttum.Show();
            this.Hide();
        }
    }
}
