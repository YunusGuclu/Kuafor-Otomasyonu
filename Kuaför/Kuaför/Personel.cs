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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RandevuBayan.mdb");
        DataTable tablo = new DataTable();

        private void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adt = new OleDbDataAdapter("select*from RandevuBayan", baglanti);
            adt.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Üye form5= new Üye();
            form5.Show();
            this.Hide();
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == ""))
            {
                MessageBox.Show("Boşluk İçermez...", "Uyarı");
            }
            else
            {
                if (button1.Text == "Ekle")
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("insert into RandevuBayan([Ad Soyad],Telefon,Kuaför,[Randevu Tarihi],[Randevu Saati])values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi.", "Kayıt");
                    tablo.Clear();
                    listele();
                    for (int i = 0; i < Controls.Count; i++)
                    {
                        if (Controls[i] is TextBox)
                        {
                            Controls[i].Text = "";
                        }
                        if (Controls[i] is ComboBox)
                        {
                            Controls[i].Text = "";
                        }

                    }
                }

                if (button1.Text == "Güncelle")
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("update RandevuBayan set [Ad Soyad]='" + textBox1.Text + "'where Telefon='" + textBox2.Text + "'", baglanti);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt güncellendi", "Kayıt");
                    tablo.Clear();
                    listele();
                    for (int i = 0; i < Controls.Count; i++)
                    {
                        if (Controls[i] is TextBox)
                        {
                            Controls[i].Text = "";
                        }
                    }
                    button1.Text = "Ekle";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete*from RandevuBayan where [Ad Soyad]='" + dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.", "Kayıt");
            tablo.Clear();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(dr["Ad Soyad"]);
            }
            baglanti2.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells["Ad Soyad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["Kuaför"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["Randevu Saati"].Value.ToString();
            button1.Text = "Güncelle";
        }

       
    }
}
