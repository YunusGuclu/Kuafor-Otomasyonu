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
    public partial class Envanter_Yönetimi : Form
    {
        public Envanter_Yönetimi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EnvanterListesi.mdb");
        DataTable tablo = new DataTable();
        public void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from EnvanterListesi", baglanti);
            adt.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Yönetici_Paneli form6 = new Yönetici_Paneli();
            form6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt_Ürün_Türü.Text == "") || (txt_Ürün_Adı.Text == "") || (txt_Ürün_Miktarı.Text == "") || (txt_Ürün_ID.Text == ""))
            {
                MessageBox.Show("Boşluk İçermez...", "Uyarı");
            }
            else
            {
                if (btn_ürün_ekle.Text == "Ekle")
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into EnvanterListesi([Ürün Türü],[Ürün Adı],[Ürün Miktarı],[Ürün ID])values('" + txt_Ürün_Türü.Text + "','" + txt_Ürün_Adı.Text + "','" + txt_Ürün_Miktarı.Text + "','" + txt_Ürün_ID.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi.", "Kayıt");
                    tablo.Clear();
                    listele();

                    txt_Ürün_Türü.Text = "";
                    txt_Ürün_Adı.Text = "";
                    txt_Ürün_Miktarı.Text = "";
                    txt_Ürün_ID.Text = "";
                }
                if(btn_ürün_ekle.Text == "Güncelle")
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("update EnvanterListesi set [Ürün Türü]='" + txt_Ürün_Türü.Text + "',[Ürün Adı] ='" + txt_Ürün_Adı.Text + "',[Ürün Miktarı]='" + txt_Ürün_Miktarı.Text + "'where [Ürün ID]='" + txt_Ürün_ID.Text + "'", baglanti);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt güncellendi", "Kayıt");
                    tablo.Clear();
                    listele();

                    txt_Ürün_Türü.Text = "";
                    txt_Ürün_Adı.Text = "";
                    txt_Ürün_Miktarı.Text = "";
                    txt_Ürün_ID.Text = "";

                    btn_ürün_ekle.Text = "Ekle";

                }
            }

        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete*from EnvanterListesi where [Ürün Türü]='"+dataGridView1.CurrentRow.Cells["Ürün Türü"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.", "Kayıt");
            tablo.Clear();
            listele();
        }
        DataTable tablo2 = new DataTable();
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from EnvanterListesi where [Ürün Türü] like '" + txt_Ürün_Ara.Text + "%' or [Ürün Adı] like'" + txt_Ürün_Ara.Text + "%' or [Ürün Miktarı] like'" + txt_Ürün_Ara.Text + "%'or [Ürün ID] like'" + txt_Ürün_Ara.Text + "%'", baglanti);
            DataTable tablo2 = new DataTable();
            adt.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ürün_Türü.Text = dataGridView1.CurrentRow.Cells["Ürün Türü"].Value.ToString();
            txt_Ürün_Adı.Text = dataGridView1.CurrentRow.Cells["Ürün Adı"].Value.ToString();
            txt_Ürün_Miktarı.Text = dataGridView1.CurrentRow.Cells["Ürün Miktarı"].Value.ToString();
            txt_Ürün_ID.Text = dataGridView1.CurrentRow.Cells["Ürün ID"].Value.ToString();

            btn_ürün_ekle.Text = "Güncelle";

            baglanti.Open();
            string urunMiktariSorgusu = "SELECT [Ürün Miktarı] FROM EnvanterListesi WHERE [Ürün ID] = '" + txt_Ürün_ID.Text + "'";
            OleDbCommand urunMiktarKomutu = new OleDbCommand(urunMiktariSorgusu, baglanti);
            
          
            int urunMiktari = Convert.ToInt32(urunMiktarKomutu.ExecuteScalar());
            
            progress_Stok.Value = urunMiktari;
            baglanti.Close();


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı veya kontrol karakterlerini kabul et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Girilen değeri kontrol et
            string currentText = txt_Ürün_Miktarı.Text + e.KeyChar;

            // TextBox boşsa veya içeriği sadece bir kontrol karakteri içeriyorsa işlem yapma
            if (string.IsNullOrEmpty(currentText) || currentText == e.KeyChar.ToString())
            {
                return;
            }

            // Girilen değeri kontrol et
            if (int.TryParse(currentText, out int enteredValue))
            {
                //Stok doluluk değeri max 100 olarak belirlendi
                // Girilen değer 100'den büyükse, işlemi engelle
                if (enteredValue > 100)
                {
                    e.Handled = true;
                }
            }


        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
