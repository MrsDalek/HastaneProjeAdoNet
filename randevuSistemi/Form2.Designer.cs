
namespace randevuSistemi
{
    partial class Form2
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
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Boy = new System.Windows.Forms.TextBox();
            this.comboBox_KanGrubu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_kilo = new System.Windows.Forms.TextBox();
            this.richTextBox_Adres = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Yas = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_HastaGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Arama = new System.Windows.Forms.Label();
            this.textBox1_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(12, 38);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta Soyadı";
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(12, 88);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Soyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta Kimlik No";
            // 
            // textBox_TC
            // 
            this.textBox_TC.Location = new System.Drawing.Point(12, 139);
            this.textBox_TC.Name = "textBox_TC";
            this.textBox_TC.Size = new System.Drawing.Size(100, 20);
            this.textBox_TC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(10, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kan Grubu";
            // 
            // textBox_Boy
            // 
            this.textBox_Boy.Location = new System.Drawing.Point(13, 246);
            this.textBox_Boy.Name = "textBox_Boy";
            this.textBox_Boy.Size = new System.Drawing.Size(100, 20);
            this.textBox_Boy.TabIndex = 6;
            // 
            // comboBox_KanGrubu
            // 
            this.comboBox_KanGrubu.FormattingEnabled = true;
            this.comboBox_KanGrubu.Items.AddRange(new object[] {
            "0 Rh+",
            "0 Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-"});
            this.comboBox_KanGrubu.Location = new System.Drawing.Point(12, 199);
            this.comboBox_KanGrubu.Name = "comboBox_KanGrubu";
            this.comboBox_KanGrubu.Size = new System.Drawing.Size(100, 21);
            this.comboBox_KanGrubu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Boy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Bisque;
            this.label6.Location = new System.Drawing.Point(10, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "kilo";
            // 
            // textBox_kilo
            // 
            this.textBox_kilo.Location = new System.Drawing.Point(12, 301);
            this.textBox_kilo.Name = "textBox_kilo";
            this.textBox_kilo.Size = new System.Drawing.Size(100, 20);
            this.textBox_kilo.TabIndex = 10;
            // 
            // richTextBox_Adres
            // 
            this.richTextBox_Adres.Location = new System.Drawing.Point(245, 26);
            this.richTextBox_Adres.Name = "richTextBox_Adres";
            this.richTextBox_Adres.Size = new System.Drawing.Size(183, 111);
            this.richTextBox_Adres.TabIndex = 14;
            this.richTextBox_Adres.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Bisque;
            this.label7.Location = new System.Drawing.Point(183, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adres";
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(245, 177);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(183, 20);
            this.textBox_Tel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Bisque;
            this.label8.Location = new System.Drawing.Point(183, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefon No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Bisque;
            this.label9.Location = new System.Drawing.Point(8, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Yaş";
            // 
            // textBox_Yas
            // 
            this.textBox_Yas.Location = new System.Drawing.Point(12, 354);
            this.textBox_Yas.Name = "textBox_Yas";
            this.textBox_Yas.Size = new System.Drawing.Size(100, 20);
            this.textBox_Yas.TabIndex = 18;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Orchid;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(264, 210);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(144, 33);
            this.btn_Ekle.TabIndex = 20;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Orchid;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(264, 256);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(144, 39);
            this.btn_Guncelle.TabIndex = 21;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Orchid;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(264, 301);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(144, 35);
            this.btn_Sil.TabIndex = 22;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_HastaGetir
            // 
            this.btn_HastaGetir.BackColor = System.Drawing.Color.Orchid;
            this.btn_HastaGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HastaGetir.Location = new System.Drawing.Point(264, 344);
            this.btn_HastaGetir.Name = "btn_HastaGetir";
            this.btn_HastaGetir.Size = new System.Drawing.Size(144, 37);
            this.btn_HastaGetir.TabIndex = 24;
            this.btn_HastaGetir.Text = "Hastaları Getir";
            this.btn_HastaGetir.UseVisualStyleBackColor = false;
            this.btn_HastaGetir.Click += new System.EventHandler(this.btn_HastaGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(490, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(288, 397);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Arama
            // 
            this.Arama.AutoSize = true;
            this.Arama.BackColor = System.Drawing.Color.Transparent;
            this.Arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Arama.ForeColor = System.Drawing.Color.Bisque;
            this.Arama.Location = new System.Drawing.Point(193, 382);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(61, 20);
            this.Arama.TabIndex = 26;
            this.Arama.Text = "Arama";
            // 
            // textBox1_Search
            // 
            this.textBox1_Search.Location = new System.Drawing.Point(245, 405);
            this.textBox1_Search.Name = "textBox1_Search";
            this.textBox1_Search.Size = new System.Drawing.Size(183, 20);
            this.textBox1_Search.TabIndex = 27;
            this.textBox1_Search.TextChanged += new System.EventHandler(this.textBox1_Search_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::randevuSistemi.Properties.Resources.dijital_saglik2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1_Search);
            this.Controls.Add(this.Arama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_HastaGetir);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Yas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox_Adres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_kilo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_KanGrubu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Boy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_TC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Ad);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Boy;
        private System.Windows.Forms.ComboBox comboBox_KanGrubu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_kilo;
        private System.Windows.Forms.RichTextBox richTextBox_Adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Yas;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_HastaGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Arama;
        private System.Windows.Forms.TextBox textBox1_Search;
    }
}