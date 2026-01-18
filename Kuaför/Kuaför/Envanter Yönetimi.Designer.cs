namespace Kuaför
{
    partial class Envanter_Yönetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Envanter_Yönetimi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Ürün_Miktarı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ürün_ID = new System.Windows.Forms.TextBox();
            this.txt_Ürün_Türü = new System.Windows.Forms.TextBox();
            this.txt_Ürün_Adı = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_ürün_sil = new System.Windows.Forms.Button();
            this.btn_ürün_ekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Ürün_Ara = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progress_Stok = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.txt_Ürün_Miktarı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Ürün_ID);
            this.groupBox1.Controls.Add(this.txt_Ürün_Türü);
            this.groupBox1.Controls.Add(this.txt_Ürün_Adı);
            this.groupBox1.Location = new System.Drawing.Point(23, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 226);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // txt_Ürün_Miktarı
            // 
            this.txt_Ürün_Miktarı.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ürün_Miktarı.Location = new System.Drawing.Point(127, 137);
            this.txt_Ürün_Miktarı.Name = "txt_Ürün_Miktarı";
            this.txt_Ürün_Miktarı.Size = new System.Drawing.Size(120, 25);
            this.txt_Ürün_Miktarı.TabIndex = 9;
            this.txt_Ürün_Miktarı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(61, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Envanter Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(5, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ürün Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(5, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ürün ID";
            // 
            // txt_Ürün_ID
            // 
            this.txt_Ürün_ID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ürün_ID.Location = new System.Drawing.Point(127, 180);
            this.txt_Ürün_ID.Name = "txt_Ürün_ID";
            this.txt_Ürün_ID.Size = new System.Drawing.Size(120, 25);
            this.txt_Ürün_ID.TabIndex = 10;
            this.txt_Ürün_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txt_Ürün_Türü
            // 
            this.txt_Ürün_Türü.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ürün_Türü.Location = new System.Drawing.Point(128, 52);
            this.txt_Ürün_Türü.Name = "txt_Ürün_Türü";
            this.txt_Ürün_Türü.Size = new System.Drawing.Size(119, 25);
            this.txt_Ürün_Türü.TabIndex = 7;
            this.txt_Ürün_Türü.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_Ürün_Adı
            // 
            this.txt_Ürün_Adı.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ürün_Adı.Location = new System.Drawing.Point(128, 96);
            this.txt_Ürün_Adı.Name = "txt_Ürün_Adı";
            this.txt_Ürün_Adı.Size = new System.Drawing.Size(119, 25);
            this.txt_Ürün_Adı.TabIndex = 8;
            this.txt_Ürün_Adı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_geri.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_geri.Location = new System.Drawing.Point(666, 9);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 33);
            this.btn_geri.TabIndex = 39;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_ürün_sil
            // 
            this.btn_ürün_sil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ürün_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ürün_sil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ürün_sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ürün_sil.Location = new System.Drawing.Point(290, 260);
            this.btn_ürün_sil.Name = "btn_ürün_sil";
            this.btn_ürün_sil.Size = new System.Drawing.Size(98, 40);
            this.btn_ürün_sil.TabIndex = 38;
            this.btn_ürün_sil.Text = "Sil";
            this.btn_ürün_sil.UseVisualStyleBackColor = false;
            this.btn_ürün_sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ürün_ekle
            // 
            this.btn_ürün_ekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ürün_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ürün_ekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ürün_ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ürün_ekle.Location = new System.Drawing.Point(23, 362);
            this.btn_ürün_ekle.Name = "btn_ürün_ekle";
            this.btn_ürün_ekle.Size = new System.Drawing.Size(141, 43);
            this.btn_ürün_ekle.TabIndex = 37;
            this.btn_ürün_ekle.Text = "Ekle";
            this.btn_ürün_ekle.UseVisualStyleBackColor = false;
            this.btn_ürün_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(380, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ürün Ara";
            // 
            // txt_Ürün_Ara
            // 
            this.txt_Ürün_Ara.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ürün_Ara.Location = new System.Drawing.Point(497, 71);
            this.txt_Ürün_Ara.Name = "txt_Ürün_Ara";
            this.txt_Ürün_Ara.Size = new System.Drawing.Size(147, 25);
            this.txt_Ürün_Ara.TabIndex = 35;
            this.txt_Ürün_Ara.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(290, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 139);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Envanter Yönetimi";
            // 
            // progress_Stok
            // 
            this.progress_Stok.Location = new System.Drawing.Point(18, 55);
            this.progress_Stok.Name = "progress_Stok";
            this.progress_Stok.Size = new System.Drawing.Size(404, 23);
            this.progress_Stok.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(158, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Stok Kontrolü";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.progress_Stok);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(290, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 98);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Envanter_Yönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ürün_sil);
            this.Controls.Add(this.btn_ürün_ekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Ürün_Ara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Envanter_Yönetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envanter Yönetimi";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Ürün_Miktarı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ürün_ID;
        private System.Windows.Forms.TextBox txt_Ürün_Türü;
        private System.Windows.Forms.TextBox txt_Ürün_Adı;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_ürün_sil;
        private System.Windows.Forms.Button btn_ürün_ekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Ürün_Ara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progress_Stok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}