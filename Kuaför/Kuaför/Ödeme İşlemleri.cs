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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kuaför
{
    public partial class Ödeme_İşlemleri : Form
    {
        public Ödeme_İşlemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Ödemeler.mdb");
        DataTable tablo=new DataTable();
        private void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from Ödemeler", baglanti);
            adt.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Ödeme_İşlemleri_Load(object sender, EventArgs e)
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
            if ((txt_Ad_Soyad.Text == "") || (masked_Telefon.Text == "") ||(txt_Yapılan_İşlem.Text=="")|| (combo_Kuaför.Text == "")||(txt_Ücret.Text==""))
            {
                MessageBox.Show("Boşluk İçermez...", "Uyarı");
            }
            else
            {
                if (btn_Ekle.Text == "Ekle")
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Ödemeler([Ad Soyad],Telefon,[Yapılan İşlem],[İşlem Tarihi],Kuaför,Ücret)values('"+txt_Ad_Soyad.Text+ "','"+masked_Telefon.Text+"','"+txt_Yapılan_İşlem.Text+"','"+date_İşlem_Tarihi.Value+"','" + combo_Kuaför.Text + "','"+txt_Ücret.Text+"')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi.", "Kayıt");
                    tablo.Clear();
                    listele();

                    txt_Ad_Soyad.Text = "";
                    masked_Telefon.Text = "";
                    txt_Yapılan_İşlem.Text = "";                  
                    combo_Kuaför.Text = " ";
                    txt_Ücret.Text = "";
                }
                if (btn_Ekle.Text == "Güncelle")
                {
                    baglanti.Open();
                    OleDbCommand komut2 = new OleDbCommand("UPDATE Ödemeler SET [Ad Soyad]='" + txt_Ad_Soyad.Text + "',[Yapılan İşlem]='" + txt_Yapılan_İşlem.Text + "', [İşlem Tarihi]='" + date_İşlem_Tarihi.Value + "',Kuaför='" + combo_Kuaför.Text + "',Ücret='" + txt_Ücret.Text + "' WHERE Telefon='" + masked_Telefon.Text + "'", baglanti);                    
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Güncellendi.", "Kayıt");
                    tablo.Clear();
                    listele();
                    btn_Ekle.Text = "Ekle";

                    txt_Ad_Soyad.Text = "";
                    masked_Telefon.Text = "";
                    txt_Yapılan_İşlem.Text = "";
                    combo_Kuaför.Text = " ";
                    txt_Ücret.Text = "";
                }

            }
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete*from Ödemeler where [Ad Soyad]='"+ dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString() + "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.", "Kayıt");
            tablo.Clear();
            listele();
        }

        
        private void txt_Ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from Ödemeler where [Ad Soyad] like '" + txt_Ara.Text + "%' or Telefon like'" + txt_Ara.Text + "%'", baglanti);
            DataTable tablo2=new DataTable();
            adt.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ad_Soyad.Text=dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString();
            masked_Telefon.Text =dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txt_Yapılan_İşlem.Text= dataGridView1.CurrentRow.Cells["Yapılan İşlem"].Value.ToString();
            combo_Kuaför.Text= dataGridView1.CurrentRow.Cells["Kuaför"].Value.ToString();
            txt_Ücret.Text= dataGridView1.CurrentRow.Cells["Ücret"].Value.ToString();

            btn_Ekle.Text = "Güncelle";
        }

        private void txt_Ad_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_Yapılan_İşlem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_Ücret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Personel_Paneli Personel_Paneli = new Personel_Paneli();
            Personel_Paneli.Show();
            this.Hide();
        }
    }
}
