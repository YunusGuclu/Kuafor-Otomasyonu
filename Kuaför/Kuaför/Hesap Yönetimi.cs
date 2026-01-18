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
using System.Net.Mail;

namespace Kuaför
{
    public partial class Hesap_Yönetimi : Form
    {
        public Hesap_Yönetimi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Yönetici.mdb");
        private void btn_Giriş_Click(object sender, EventArgs e)
        {
           
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("UPDATE Yönetici SET kullanıcıadı ='" + txt_Yeni_Ad.Text + "', parola = '" + txt_Yeni_Şifre.Text + "',email='" + txt_Yeni_Email.Text + "'", baglanti);


                komut.ExecuteNonQuery();

                MessageBox.Show("Yeni Kullanıcı Adı, Şifre ve E-Mail Belirlendi.", "Uyarı");

                baglanti.Close();
            
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Yönetici_Paneli yönetici_Paneli = new Yönetici_Paneli();
            yönetici_Paneli.Show();
            this.Hide();
        }

        private void Hesap_Yönetimi_Load(object sender, EventArgs e)
        {

        }
        
    }
}
