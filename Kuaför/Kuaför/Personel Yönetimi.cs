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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kuaför
{
    public partial class Personel_Yönetimi : Form
    {
        public Personel_Yönetimi()
        {
            InitializeComponent();
        }
       
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Personel.mdb");
        DataTable tablo = new DataTable();
        private void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from Personel", baglanti);
            adt.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Personel_Yönetimi_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if ((txt_Ad_Soyad.Text == "") || (masked_Telefon.Text == "") || (txt_Yaş.Text == "") || (txt_Maaş.Text == "") || (txt_Kullanıcı_Adı.Text == "") || (txt_Şifre.Text == ""))
            {
                MessageBox.Show("Boşluk İçermez...", "Uyarı");
            }
            else
            {
                if (btn_Ekle.Text == "Ekle")
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("INSERT INTO Personel ([Ad Soyad], Telefon, Yaş, Maaş, [Kullanıcı Adı], Şifre) VALUES ('" + txt_Ad_Soyad.Text + "', '" + masked_Telefon.Text + "', '" + txt_Yaş.Text + "','" + txt_Maaş.Text + "','" + txt_Kullanıcı_Adı.Text + "','" + txt_Şifre.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi.", "Kayıt");
                    tablo.Clear();
                    listele();

                    txt_Ad_Soyad.Text = "";
                    masked_Telefon.Text = "";
                    txt_Yaş.Text = "";
                    txt_Maaş.Text = " ";
                    txt_Kullanıcı_Adı.Text = "";
                    txt_Şifre.Text = "";

                }

                if (btn_Ekle.Text == "Güncelle")
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("update Personel set [Ad Soyad]='" + txt_Ad_Soyad.Text + "',Telefon='" + masked_Telefon.Text + "',Yaş='" + txt_Yaş.Text + "',Maaş='" + txt_Maaş.Text + "' ,[Kullanıcı Adı]='" + txt_Kullanıcı_Adı.Text + "' where şifre='" + txt_Şifre.Text + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt güncellendi", "Kayıt");
                    tablo.Clear();
                    listele();

                    txt_Ad_Soyad.Text = "";
                    masked_Telefon.Text = "";
                    txt_Yaş.Text = "";
                    txt_Maaş.Text = " ";
                    txt_Kullanıcı_Adı.Text = "";
                    txt_Şifre.Text = "";

                    btn_Ekle.Text = "Ekle";
                }
            }
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("DELETE FROM Personel WHERE [Ad Soyad] = ?", baglanti);
            komut.Parameters.AddWithValue("@AdSoyad", dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi", "Kayıt");
            tablo.Clear();
            listele();

        }
        private void txt_Ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from Personel where [Ad Soyad] like '" + txt_Ara.Text + "%' or Telefon like'" + txt_Ara.Text + "%'or Yaş like'" + txt_Ara.Text + "%' or Maaş like '" + txt_Ara.Text + "%' or [Kullanıcı Adı] like'" + txt_Ara.Text + "%'or Şifre like'" + txt_Ara.Text + "%'", baglanti);
            DataTable tablo2 = new DataTable();
            adt.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_Ad_Soyad.Text = dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString();
            masked_Telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();       
            txt_Yaş.Text = dataGridView1.CurrentRow.Cells["Yaş"].Value.ToString();
            txt_Maaş.Text = dataGridView1.CurrentRow.Cells["Maaş"].Value.ToString();
            txt_Kullanıcı_Adı.Text = dataGridView1.CurrentRow.Cells["Kullanıcı Adı"].Value.ToString();
            txt_Şifre.Text = dataGridView1.CurrentRow.Cells["Şifre"].Value.ToString();

            btn_Ekle.Text = "Güncelle";
        }

        private void txt_Ad_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
     
        private void txt_Yaş_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void txt_Maaş_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Yönetici_Paneli Yönetici_Paneli = new Yönetici_Paneli();
            Yönetici_Paneli.Show();
            this.Hide();
        }

        
    }
}
