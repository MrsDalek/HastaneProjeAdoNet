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

    public partial class Form3 : Form
    {
        int count;
        public Form3()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataSet ds;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        private void Form3_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select UnvanAdi,UnvanID from Unvan ", con);

            dt = new DataTable("Unvan");
            ds = new DataSet();
            dap.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_unvan.DataSource = ds.Tables[0];
            comboBox_unvan.DisplayMember = "UnvanAdi";
            comboBox_unvan.ValueMember = "UnvanID";
            
            SqlDataAdapter dap1 = new SqlDataAdapter("select HastaneAdi,HastaneID from Hastaneler", con);
            dt = new DataTable("bHastane");
            ds = new DataSet();
            dap1.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_bHastane.DataSource = ds.Tables[0];
            comboBox_bHastane.DisplayMember = "HastaneAdi";
            comboBox_bHastane.ValueMember = "HastaneID";
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = "";
                }
            }
            button_Guncelle.Enabled = false;
            button_Sil.Enabled = false;
        }

        private void button_Kayit_Click(object sender, EventArgs e)
        {

            if (textBox_Ad.Text != "" && textBox_Soyad.Text != "" && textBox_Yas.Text != "" && textBox_TC.Text != "" && textBox_TC.Text.Length == 11 && textBox_Tel.Text != "" && textBox_Mail.Text != "" && comboBox_bHastane.Text != "" && comboBox_unvan.Text != "" && richTextBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into Personeller (PersonelAdi,PersonelSoyad,HastaneID,UnvanID) values(@ad,@soyad,@hid,@uid)" + "Insert into PersonelDetay (PersonelYas,PersonelCinsiyet,PersonelTel,PersonelMail,PersonelAdres,PersonelTc) values(convert(int,@yas),convert(bit,@cinsiyet),@tel,@mail,@adres,@tc)", con);
                cmd.Parameters.AddWithValue("@ad", textBox_Ad.Text);
                cmd.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
                cmd.Parameters.AddWithValue("@hid", comboBox_bHastane.SelectedValue);
                cmd.Parameters.AddWithValue("@uid", comboBox_unvan.SelectedValue);

                cmd.Parameters.AddWithValue("@yas", textBox_Yas.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", checkBox1.Checked);
                cmd.Parameters.AddWithValue("@tel", textBox_Tel.Text); 
                cmd.Parameters.AddWithValue("@mail", textBox_Mail.Text); 
                cmd.Parameters.AddWithValue("@adres", richTextBox1.Text);
                       
                    cmd.Parameters.AddWithValue("@tc", textBox_TC.Text);
    
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
                MessageBox.Show("Lütfen boş alan bırakmayınız veya tc yi doğru giriniz");
            }
        }
        private void button_Goster_Click(object sender, EventArgs e)
        {
            Getir();
        }
        private void button_Guncelle_Click(object sender, EventArgs e)
        {
    
            con.Open();
            SqlCommand cmd = new SqlCommand("update Personeller set PersonelAdi=@ad,PersonelSoyad=@soyad,HastaneID=@hid,UnvanID=convert(int,@uid) where PersonelID=convert(int,@ID)"+ "update PersonelDetay set PersonelYas=convert(int,@yas),PersonelCinsiyet=@cinsiyet,PersonelTel=@tel,PersonelMail=@mail,PersonelAdres=@adres,PersonelTc=@tc where PDID=convert(int,@pID)", con);
        
            cmd.Parameters.AddWithValue("@ID", count);
            cmd.Parameters.AddWithValue("@ad", textBox_Ad.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
            cmd.Parameters.AddWithValue("@hid", comboBox_bHastane.SelectedValue);
            cmd.Parameters.AddWithValue("@uid", comboBox_unvan.SelectedValue);
           
            cmd.Parameters.AddWithValue("@pID", count);
            cmd.Parameters.AddWithValue("@yas", textBox_Yas.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", checkBox1.Checked);
            cmd.Parameters.AddWithValue("@tel", textBox_Tel.Text);
            cmd.Parameters.AddWithValue("@mail", textBox_Mail.Text);
            cmd.Parameters.AddWithValue("@adres", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@tc", textBox_TC.Text);
   
            cmd.ExecuteNonQuery();
            Temizle();
            con.Close();
            Getir();
            MessageBox.Show("Kayıt Başarıyla Güncellendi");
            button_Guncelle.Enabled = false;
            button_Sil.Enabled = false;
        }
        private void button_Sil_Click(object sender, EventArgs e)
        {
          
            SqlCommand cmd = new SqlCommand("update Personeller set durum = 0 where PersonelID=convert(int,@ID)" + "update PersonelDetay set durum = 0 where PDID=convert(int,@pID)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ID", count);
            cmd.Parameters.AddWithValue("@pID", count);
            cmd.ExecuteNonQuery();
            con.Close();
            Temizle();
            Getir();
            MessageBox.Show("kayıt silindi");
            button_Guncelle.Enabled = false;
            button_Sil.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox_Ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_Soyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox_bHastane.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox_unvan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox_Yas.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                checkBox1.Checked = (bool)dataGridView1.CurrentRow.Cells[5].Value;
                textBox_Tel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox_Mail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                richTextBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox_TC.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            count = Convert.ToInt32((dataGridView1.CurrentRow.Cells[10].Value));
            button_Guncelle.Enabled = true;
            button_Sil.Enabled = true;
            button_Kayit.Enabled = false;
        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
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
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = "";
                }
                if (item is CheckBox)
                {
                    CheckBox cek = (CheckBox)item;
                    cek.Checked = false;
                }


            }
            button_Kayit.Enabled = true;
        }
        private void Getir()
        {
            SqlDataAdapter dap = new SqlDataAdapter("select PersonelAdi,PersonelSoyad,HastaneAdi,UnvanAdi,PersonelYas,PersonelCinsiyet,PersonelTel,PersonelMail,PersonelAdres,PersonelTc,PersonelID from Personeller,PersonelDetay,Unvan,Hastaneler where PersonelID = PDID and Personeller.UnvanID = Unvan.UnvanID  and Hastaneler.HastaneID = Personeller.HastaneID and Personeller.durum = 1", con);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[10].Visible = false;

        }

        private void textBox1_Search_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("Convert("+dataGridView1.Columns[0].DataPropertyName+",System.String) Like'"+textBox1_Search.Text+"%'");
            dataGridView1.DataSource = bs;
          
        }
    }
}
