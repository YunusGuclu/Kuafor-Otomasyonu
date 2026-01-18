namespace Kuaför
{
    partial class Ödeme_İşlemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ödeme_İşlemleri));
            this.btn_Sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.masked_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_Ücret = new System.Windows.Forms.TextBox();
            this.txt_Yapılan_İşlem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_Kuaför = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_İşlem_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ad_Soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Sil.FlatAppearance.BorderSize = 0;
            this.btn_Sil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sil.Location = new System.Drawing.Point(297, 388);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(89, 35);
            this.btn_Sil.TabIndex = 46;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 240);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(279, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ödeme İşlemleri";
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Geri.FlatAppearance.BorderSize = 0;
            this.btn_Geri.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Geri.Location = new System.Drawing.Point(672, 9);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 35);
            this.btn_Geri.TabIndex = 44;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Ekle.FlatAppearance.BorderSize = 0;
            this.btn_Ekle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ekle.Location = new System.Drawing.Point(12, 388);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(134, 35);
            this.btn_Ekle.TabIndex = 42;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.masked_Telefon);
            this.groupBox1.Controls.Add(this.txt_Ücret);
            this.groupBox1.Controls.Add(this.txt_Yapılan_İşlem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.combo_Kuaför);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.date_İşlem_Tarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Ad_Soyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 240);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // masked_Telefon
            // 
            this.masked_Telefon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masked_Telefon.Location = new System.Drawing.Point(129, 54);
            this.masked_Telefon.Mask = "(999) 000-00-00";
            this.masked_Telefon.Name = "masked_Telefon";
            this.masked_Telefon.Size = new System.Drawing.Size(139, 23);
            this.masked_Telefon.TabIndex = 42;
            // 
            // txt_Ücret
            // 
            this.txt_Ücret.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ücret.Location = new System.Drawing.Point(129, 197);
            this.txt_Ücret.Name = "txt_Ücret";
            this.txt_Ücret.Size = new System.Drawing.Size(139, 23);
            this.txt_Ücret.TabIndex = 40;
            this.txt_Ücret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ücret_KeyPress);
            // 
            // txt_Yapılan_İşlem
            // 
            this.txt_Yapılan_İşlem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Yapılan_İşlem.Location = new System.Drawing.Point(129, 89);
            this.txt_Yapılan_İşlem.Name = "txt_Yapılan_İşlem";
            this.txt_Yapılan_İşlem.Size = new System.Drawing.Size(139, 23);
            this.txt_Yapılan_İşlem.TabIndex = 39;
            this.txt_Yapılan_İşlem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Yapılan_İşlem_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Yapılan İşlem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ücret";
            // 
            // combo_Kuaför
            // 
            this.combo_Kuaför.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Kuaför.FormattingEnabled = true;
            this.combo_Kuaför.Location = new System.Drawing.Point(129, 161);
            this.combo_Kuaför.Name = "combo_Kuaför";
            this.combo_Kuaför.Size = new System.Drawing.Size(139, 24);
            this.combo_Kuaför.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Kuaför";
            // 
            // date_İşlem_Tarihi
            // 
            this.date_İşlem_Tarihi.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_İşlem_Tarihi.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.date_İşlem_Tarihi.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.date_İşlem_Tarihi.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.date_İşlem_Tarihi.CalendarTrailingForeColor = System.Drawing.SystemColors.ScrollBar;
            this.date_İşlem_Tarihi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_İşlem_Tarihi.Location = new System.Drawing.Point(129, 123);
            this.date_İşlem_Tarihi.Name = "date_İşlem_Tarihi";
            this.date_İşlem_Tarihi.Size = new System.Drawing.Size(139, 26);
            this.date_İşlem_Tarihi.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "İşlem Tarihi";
            // 
            // txt_Ad_Soyad
            // 
            this.txt_Ad_Soyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad_Soyad.Location = new System.Drawing.Point(129, 19);
            this.txt_Ad_Soyad.Name = "txt_Ad_Soyad";
            this.txt_Ad_Soyad.Size = new System.Drawing.Size(139, 23);
            this.txt_Ad_Soyad.TabIndex = 25;
            this.txt_Ad_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ad_Soyad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ad Soyad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(400, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "Ara";
            // 
            // txt_Ara
            // 
            this.txt_Ara.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ara.Location = new System.Drawing.Point(467, 95);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(161, 25);
            this.txt_Ara.TabIndex = 49;
            this.txt_Ara.TextChanged += new System.EventHandler(this.txt_Ara_TextChanged);
            // 
            // Ödeme_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Ara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Ödeme_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme İşlemleri";
            this.Load += new System.EventHandler(this.Ödeme_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_Kuaför;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_İşlem_Tarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ad_Soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Yapılan_İşlem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ücret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Ara;
        private System.Windows.Forms.MaskedTextBox masked_Telefon;
    }
}