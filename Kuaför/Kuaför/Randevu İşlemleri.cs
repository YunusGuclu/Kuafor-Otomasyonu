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
    public partial class Randevu_İşlemleri : Form
    {
        public Randevu_İşlemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Randevu.mdb");
        DataTable tablo = new DataTable();

        private void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from Randevu", baglanti);
            adt.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Randevu_İşlemleri_Load(object sender, EventArgs e)
        {
            listele();
            OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Personel.mdb");
            OleDbCommand komut2 = new OleDbCommand();
            komut2.CommandText = "select*from Personel";
            komut2.Connection = baglanti2;
            komut2.CommandType = CommandType.Text;
            OleDbDataReader dr;
            baglanti2.Open();
            dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                combo_Kuaför.Items.Add(dr["Ad Soyad"]);
            }
            baglanti2.Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if ((txt_Ad_Soyad.Text == "") || (masked_Telefon.Text == "") || (combo_Kuaför.Text == "") || (combo_Randevu_Saati.Text == ""))
            {
                MessageBox.Show("Boşluk İçermez...", "Uyarı");
            }
            else
            {
                if (btn_Ekle.Text == "Ekle")
                {
                    baglanti.Open();
                    // Kullanıcının seçtiği randevu tarihi 
                    DateTime secilenRandevuTarihi = date_Randevu_Tarihi.Value.Date;

                    // Tarih bilgisini belirli bir formatta string'e dönüştürüyorum
                    string tarihString = secilenRandevuTarihi.Date.ToString("dd.MM.yyyy");

                    // Var olan randevuları kontrol et
                    OleDbCommand kontrolKomut = new OleDbCommand("SELECT [Randevu Tarihi], [Randevu Saati] FROM Randevu WHERE [Randevu Tarihi]=@tarih AND [Randevu Saati]=@saat AND [Kuaför]=@kuafor", baglanti);
                    kontrolKomut.Parameters.AddWithValue("@tarih", tarihString);
                    kontrolKomut.Parameters.AddWithValue("@saat", combo_Randevu_Saati.Text);
                    kontrolKomut.Parameters.AddWithValue("@kuafor", combo_Kuaför.Text);

                    OleDbDataReader kontrolReader = kontrolKomut.ExecuteReader();

                    if (kontrolReader.HasRows)
                    {
                        // Çakışma durumunu kontrol ediyorum
                        MessageBox.Show("Seçtiğiniz tarih, saat ve kuaförde başka bir randevu bulunmaktadır. Lütfen farklı bir tarih, saat veya kuaför seçiniz.", "Uyarı");
                    }
                    else
                    {
                        // Çakışma yoksa yeni randevuyu ekleyebilirsiniz
                        OleDbCommand ekleKomut = new OleDbCommand("INSERT INTO Randevu([Ad Soyad],Telefon,Kuaför,[Randevu Tarihi],[Randevu Saati]) VALUES('" + txt_Ad_Soyad.Text + "','" + masked_Telefon.Text + "','" + combo_Kuaför.Text + "','" + tarihString + "','" + combo_Randevu_Saati.Text + "')", baglanti);
                        ekleKomut.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarıyla eklendi.", "Uyarı");
                    }

                    kontrolReader.Close();
                    baglanti.Close();
                    tablo.Clear();
                    listele();

                    txt_Ad_Soyad.Text = "";
                    masked_Telefon.Text = "";
                    combo_Kuaför.Text = "";
                    combo_Randevu_Saati.Text = " ";

                }
            }

            if (btn_Ekle.Text == "Güncelle")
            {
                baglanti.Open();               
                // Kullanıcının seçtiği randevu tarihi 
                DateTime secilenRandevuTarihi = date_Randevu_Tarihi.Value.Date;

                // Tarih bilgisini belirli bir formatta string'e dönüştürüyorum
                string tarihString = secilenRandevuTarihi.Date.ToString("dd.MM.yyyy");

                // Var olan randevuları kontrol ediyorum
                OleDbCommand kontrolKomut = new OleDbCommand("SELECT [Randevu Tarihi], [Randevu Saati] FROM Randevu WHERE [Randevu Tarihi]=@tarih AND [Randevu Saati]=@saat AND [Kuaför]=@kuafor", baglanti);
                kontrolKomut.Parameters.AddWithValue("@tarih", tarihString);
                kontrolKomut.Parameters.AddWithValue("@saat", combo_Randevu_Saati.Text);
                kontrolKomut.Parameters.AddWithValue("@kuafor", combo_Kuaför.Text);

                OleDbDataReader kontrolReader = kontrolKomut.ExecuteReader();

                if (kontrolReader.HasRows)
                {
                    // Çakışma durumu kontrolü
                    MessageBox.Show("Seçtiğiniz tarih, saat ve kuaförde başka bir randevu bulunmaktadır. Lütfen farklı bir tarih, saat veya kuaför seçiniz.", "Uyarı");
                }
                else
                {
                    // Çakışma yoksa yeni randevuyu ekleyebilirsiniz
                    OleDbCommand güncelleKomut = new OleDbCommand("UPDATE Randevu SET [Ad Soyad]='" + txt_Ad_Soyad.Text + "', Kuaför='" + combo_Kuaför.Text + "', [Randevu Tarihi]='" + tarihString + "', [Randevu Saati]='" + combo_Randevu_Saati.Text + "' WHERE Telefon='" + masked_Telefon.Text + "'", baglanti);
                    güncelleKomut.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla güncellendi.", "Uyarı");
                }

                kontrolReader.Close();
                baglanti.Close();
                tablo.Clear();
                listele();

                txt_Ad_Soyad.Text = "";
                masked_Telefon.Text = "";
                combo_Kuaför.Text = "";
                combo_Randevu_Saati.Text = " ";

                btn_Ekle.Text = "Ekle";
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete*from Randevu where [Ad Soyad]='" + dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.", "Kayıt");
            tablo.Clear();
            listele();
        }
        private void txt_Ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from Randevu where [Ad Soyad] like '" + txt_Ara.Text + "%' or Telefon like'" + txt_Ara.Text + "%'or Kuaför like'" + txt_Ara.Text + "%'or [Randevu Tarihi] like'" + txt_Ara.Text + "%'or [Randevu Saati] like'" + txt_Ara.Text + "%'", baglanti);
            DataTable tablo2 = new DataTable();
            adt.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ad_Soyad.Text = dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString();
            masked_Telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            combo_Kuaför.Text = dataGridView1.CurrentRow.Cells["Kuaför"].Value.ToString();
            combo_Randevu_Saati.Text = dataGridView1.CurrentRow.Cells["Randevu Saati"].Value.ToString();

            btn_Ekle.Text = "Güncelle";
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Personel_Paneli Personel_Paneli = new Personel_Paneli();
            Personel_Paneli.Show();
            this.Hide();
        }

        private void txt_Ad_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
