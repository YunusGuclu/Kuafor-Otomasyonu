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
using System.Net;
using System.Net.Mail;


namespace Kuaför
{
    public partial class Şifreyi_Unuttum : Form
    {
        public Şifreyi_Unuttum()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Yönetici.mdb");
        private void Şifreyi_Unuttum_Load(object sender, EventArgs e)
        {

        }

        private void btn_Giriş_Click(object sender, EventArgs e)
        {            
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM Yönetici WHERE kullanıcıadı = @kullaniciadi AND email = @email", baglanti);
                komut.Parameters.AddWithValue("@kullaniciadi", txt_Kullanıcı_Adı.Text);
                komut.Parameters.AddWithValue("@email", txt_Email.Text);

                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read() && string.Equals(txt_Kullanıcı_Adı.Text, oku["kullanıcıadı"].ToString(), StringComparison.Ordinal) && string.Equals(txt_Email.Text, oku["email"].ToString(), StringComparison.Ordinal))
                {
                              
                MessageBox.Show(("ŞİFRENİZ= "+ oku["parola"].ToString()),"Şifre Hatırlatma");
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya E-Mail Girişi Yaptınız. Tekrar Deneyin.", "Uyarı");
                }

                baglanti.Close();
            

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Yönetici_Girişi yönetici_Girişi=new Yönetici_Girişi();
            yönetici_Girişi.Show();
            this.Hide();
        }
    }

    }
