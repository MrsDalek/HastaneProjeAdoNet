
namespace randevuSistemi
{
    partial class Form1
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
            this.comboBox_Bolge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_AltBolge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Hastaneler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_TıbbiBirimler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Doktorlar = new System.Windows.Forms.ComboBox();
            this.btn_saat = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_randevu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Bolge
            // 
            this.comboBox_Bolge.FormattingEnabled = true;
            this.comboBox_Bolge.Location = new System.Drawing.Point(1, 40);
            this.comboBox_Bolge.Name = "comboBox_Bolge";
            this.comboBox_Bolge.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Bolge.TabIndex = 0;
            this.comboBox_Bolge.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Bolge_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölge Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(1, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şehir Seçiniz";
            // 
            // comboBox_AltBolge
            // 
            this.comboBox_AltBolge.FormattingEnabled = true;
            this.comboBox_AltBolge.Location = new System.Drawing.Point(1, 112);
            this.comboBox_AltBolge.Name = "comboBox_AltBolge";
            this.comboBox_AltBolge.Size = new System.Drawing.Size(121, 21);
            this.comboBox_AltBolge.TabIndex = 2;
            this.comboBox_AltBolge.SelectionChangeCommitted += new System.EventHandler(this.comboBox_AltBolge_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(1, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hastane Seçiniz";
            // 
            // comboBox_Hastaneler
            // 
            this.comboBox_Hastaneler.FormattingEnabled = true;
            this.comboBox_Hastaneler.Location = new System.Drawing.Point(1, 182);
            this.comboBox_Hastaneler.Name = "comboBox_Hastaneler";
            this.comboBox_Hastaneler.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Hastaneler.TabIndex = 4;
            this.comboBox_Hastaneler.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Hastaneler_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(1, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tıbbi Birim Seçiniz";
            // 
            // comboBox_TıbbiBirimler
            // 
            this.comboBox_TıbbiBirimler.FormattingEnabled = true;
            this.comboBox_TıbbiBirimler.Location = new System.Drawing.Point(1, 252);
            this.comboBox_TıbbiBirimler.Name = "comboBox_TıbbiBirimler";
            this.comboBox_TıbbiBirimler.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TıbbiBirimler.TabIndex = 6;
            this.comboBox_TıbbiBirimler.SelectionChangeCommitted += new System.EventHandler(this.comboBox_TıbbiBirimler_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(1, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doktor Seçiniz";
            // 
            // comboBox_Doktorlar
            // 
            this.comboBox_Doktorlar.FormattingEnabled = true;
            this.comboBox_Doktorlar.Location = new System.Drawing.Point(1, 322);
            this.comboBox_Doktorlar.Name = "comboBox_Doktorlar";
            this.comboBox_Doktorlar.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Doktorlar.TabIndex = 8;
            this.comboBox_Doktorlar.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Doktorlar_SelectionChangeCommitted);
            // 
            // btn_saat
            // 
            this.btn_saat.BackColor = System.Drawing.Color.Orchid;
            this.btn_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_saat.Location = new System.Drawing.Point(279, 232);
            this.btn_saat.Name = "btn_saat";
            this.btn_saat.Size = new System.Drawing.Size(108, 41);
            this.btn_saat.TabIndex = 10;
            this.btn_saat.Text = "Saati Seç";
            this.btn_saat.UseVisualStyleBackColor = false;
            this.btn_saat.Click += new System.EventHandler(this.btn_saat_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(153, 40);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 233);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_randevu
            // 
            this.btn_randevu.BackColor = System.Drawing.Color.Purple;
            this.btn_randevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_randevu.Location = new System.Drawing.Point(623, 363);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(143, 47);
            this.btn_randevu.TabIndex = 14;
            this.btn_randevu.Text = "Randevu Al";
            this.btn_randevu.UseVisualStyleBackColor = false;
            this.btn_randevu.Click += new System.EventHandler(this.btn_randevu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Bisque;
            this.label6.Location = new System.Drawing.Point(179, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Randevu Tarihi Seçiniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Bisque;
            this.label7.Location = new System.Drawing.Point(421, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Saat Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::randevuSistemi.Properties.Resources.dijital_saglik1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_randevu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_saat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Doktorlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_TıbbiBirimler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Hastaneler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_AltBolge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Bolge);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Bolge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_AltBolge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Hastaneler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_TıbbiBirimler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Doktorlar;
        private System.Windows.Forms.Button btn_saat;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

