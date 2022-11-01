using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randevuSistemi
{
  
    public partial class Form2 : Form
    {
         int count ;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
     
        private void Form2_Load(object sender, EventArgs e)
        {
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (textBox_Ad.Text != "" && textBox_Soyad.Text != "" && textBox_TC.Text != "" && textBox_Boy.Text != "" && textBox_kilo.Text != "" && textBox_Tel.Text != "" && textBox_Yas.Text != "" && richTextBox_Adres.Text != "" && comboBox_KanGrubu.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into Hasta (HastaAdi,HastaSoyAdi,Tc_Passaport) values(@ad,@soyad,@tc)" + "Insert into HastaDetay (HastaKanGrubu,HastaBoy,HastaKilo,HastaAdres,HastaTel,HastaYas) values(@kan,@boy,@kilo,@adres,@tel,@yas)", con);


                cmd.Parameters.AddWithValue("@ad", textBox_Ad.Text);
                cmd.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
                if (textBox_TC.Text.Length < 11)
                {
                    cmd.Parameters.AddWithValue("@tc", textBox_TC.Text);
                }
                else
                {
                    MessageBox.Show("TC'yi yanlış girdiniz.");
                }
                cmd.Parameters.AddWithValue("@kan", comboBox_KanGrubu.Text);
                cmd.Parameters.AddWithValue("@boy", textBox_Boy.Text);
                cmd.Parameters.AddWithValue("@kilo", textBox_kilo.Text);
                cmd.Parameters.AddWithValue("@adres", richTextBox_Adres.Text);
                cmd.Parameters.AddWithValue("@tel", textBox_Tel.Text);
                cmd.Parameters.AddWithValue("@yas", textBox_Yas.Text);

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayit eklendi.");
                        con.Close();
                        Temizle();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Kayit ekleme işlemi başarısız.");
                        Temizle();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata");

                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }
        }

       

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Hasta set HastaAdi=@ad,HastaSoyAdi=@soyad,Tc_Passaport=@tc where HastaID=convert(int,@ID)" + "update HastaDetay set HastaKanGrubu=@kan,HastaBoy=@boy,HastaKilo=@kilo,HastaAdres=@adres,HastaTel=@tel,HastaYas=@yas where HDID=convert(int,@hID)", con);
            con.Open();

            cmd.Parameters.AddWithValue("@ID",count);

            cmd.Parameters.AddWithValue("@ad", textBox_Ad.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
            cmd.Parameters.AddWithValue("@tc", textBox_TC.Text);

            cmd.Parameters.AddWithValue("@hID",count);
            cmd.Parameters.AddWithValue("@kan", comboBox_KanGrubu.Text);
            cmd.Parameters.AddWithValue("@boy", textBox_Boy.Text);
            cmd.Parameters.AddWithValue("@kilo", textBox_kilo.Text);
            cmd.Parameters.AddWithValue("@adres", richTextBox_Adres.Text);
            cmd.Parameters.AddWithValue("@tel", textBox_Tel.Text);
            cmd.Parameters.AddWithValue("@yas",Convert.ToInt32(textBox_Yas.Text));

            cmd.ExecuteNonQuery();
            Temizle();
            con.Close();
            Getir();
            MessageBox.Show("Kayıt Başarıyla Güncellendi");
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }

        private void btn_HastaGetir_Click(object sender, EventArgs e)
        {
            Getir();
        }
      
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox_Ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_Soyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_TC.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox_KanGrubu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox_Boy.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox_kilo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                richTextBox_Adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox_Tel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox_Yas.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
            count =Convert.ToInt32((dataGridView1.CurrentRow.Cells[9].Value));
       
      
            btn_Guncelle.Enabled = true;
            btn_Sil.Enabled = true;
            btn_Ekle.Enabled = false;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Hasta set durum = 0 where HastaID=convert(int,@ID)"+"update HastaDetay set durum = 0 where HDID=convert(int,@hID)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ID", count);
            cmd.Parameters.AddWithValue("@hID", count);
            cmd.ExecuteNonQuery();
            con.Close();
            Temizle();
            Getir();
            MessageBox.Show("kayıt silindi");
            btn_Guncelle.Enabled = false;
            btn_Sil.Enabled = false;
        }

        private void textBox1_Search_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Convert(" + dataGridView1.Columns[0].DataPropertyName + ",System.String) Like'" + textBox1_Search.Text + "%'");
            dataGridView1.DataSource = bs;
        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = null;
                }
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }
                if (item is RichTextBox)
                {
                    RichTextBox rtxt = (RichTextBox)item;
                    rtxt.Text = "";
                }

            }
            btn_Ekle.Enabled = true;
        }
        public void Getir()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select HastaAdi,HastaSoyAdi,Tc_Passaport,HastaKanGrubu,HastaBoy,HastaKilo,HastaAdres,HastaTel,HastaYas,HastaID from hasta,HastaDetay where HastaID = HDID and hasta.durum = 1", con);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[9].Visible = false;
        }
    }
}
