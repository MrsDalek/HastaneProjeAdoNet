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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        SqlDataAdapter dap;
        DataSet ds;
        DataTable dt;
        string tarih;
        string saat;
        string Alan;
        string doktorAd;
        
        private void Form1_Load(object sender, EventArgs e)
        {
         

            dap = new SqlDataAdapter("Select BolgeAdi, BolgeID from Bolge", conn);
            ds = new DataSet();
            dt = new DataTable("BolgeAdi");
            dap.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_Bolge.DataSource = ds.Tables[0];
            comboBox_Bolge.DisplayMember = "BolgeAdi";
            comboBox_Bolge.ValueMember = "BolgeID";

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = null;
                }
            }
            monthCalendar1.Enabled = false;
            btn_saat.Enabled = false;
            btn_randevu.Enabled = false;
        }

        private void comboBox_Bolge_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter("Select AltBolgeAdi, AltBolgeID from AltBolge where BolgeID = @ID", conn);
            dap.SelectCommand.Parameters.AddWithValue("@ID", comboBox_Bolge.SelectedValue);
            ds = new DataSet();
            dt = new DataTable("AltBolgeAdi");
            dap.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_AltBolge.DataSource = ds.Tables[0];
            comboBox_AltBolge.DisplayMember = "AltBolgeAdi";
            comboBox_AltBolge.ValueMember = "AltBolgeID";
            comboBox_AltBolge.Text = null;
        
        }
        private void comboBox_AltBolge_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter("Select HastaneAdi, HastaneID from Hastaneler where AltBolgeID = @ID", conn);
            dap.SelectCommand.Parameters.AddWithValue("@ID", comboBox_AltBolge.SelectedValue);
            ds = new DataSet();
            dt = new DataTable("Hastaneler");
            dap.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_Hastaneler.DataSource = ds.Tables[0];
            comboBox_Hastaneler.DisplayMember = "HastaneAdi";
            comboBox_Hastaneler.ValueMember = "HastaneID";
            comboBox_Hastaneler.Text = null;

        }
        private void comboBox_Hastaneler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter("Select TibbiAdi, TBID from TibbiBirimler", conn);      
            ds = new DataSet();
            dt = new DataTable("TıbbiBirimler");
            dap.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_TıbbiBirimler.DataSource = ds.Tables[0];
            comboBox_TıbbiBirimler.DisplayMember = "TibbiAdi";
            comboBox_TıbbiBirimler.ValueMember = "TBID";
            Alan = comboBox_TıbbiBirimler.Text;
            comboBox_TıbbiBirimler.Text = null;
        }
        private void comboBox_TıbbiBirimler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter("Select * from vw_Doktor where  TBID  = @ID  ", conn);
            dap.SelectCommand.Parameters.AddWithValue("@ID", comboBox_TıbbiBirimler.SelectedValue);
            ds = new DataSet();
            dt = new DataTable("Doktorlar");
            dap.Fill(dt);
            ds.Tables.Add(dt);
            comboBox_Doktorlar.DataSource = ds.Tables[0];
            comboBox_Doktorlar.DisplayMember = "Doktor";
            comboBox_Doktorlar.ValueMember = "";
            doktorAd = comboBox_Doktorlar.Text;
            comboBox_Doktorlar.Text = null;
        }
        private void btn_saat_Click(object sender, EventArgs e)
        {
            DataTable dt = SaatGetir();
            dataGridView1.DataSource = dt;
            dataGridView1.Enabled = true;  
        }
        DataTable dt2 =new  DataTable();
        private DataTable SaatGetir()
        {
                dt2.Columns.Add(" ", typeof(string));
                dt2.Columns.Add("  ", typeof(string));
                dt2.Columns.Add("   ", typeof(string));
                dt2.Columns.Add("    ", typeof(string));
            
            
                dt2.Rows.Add("09:00", "09:15", "09:30", "09:45");
                dt2.Rows.Add("10:00", "10:15", "10:30", "10:45");
                dt2.Rows.Add("11:00", "11:15", "11:30", "11:45");
                dt2.Rows.Add("12:00", "12:15", "12:30", "12:45");
                dt2.Rows.Add("13:00", "13:15", "13:30", "13:45");
                dt2.Rows.Add("14:00", "14:15", "14:30", "14:45");
                dt2.Rows.Add("15:00", "15:15", "15:30", "15:45");
                dt2.Rows.Add("16:00", "16:15", "16:30", "16:45");
            
            return dt2;
        }

        private void comboBox_Doktorlar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(monthCalendar1.SelectionRange.Start > DateTime.Now)
            {

                btn_saat.Enabled = true;
                tarih = monthCalendar1.SelectionRange.Start.ToShortDateString();

            }
            else
            {
                MessageBox.Show("Bugün tarihinden ileri bir tarih seçiniz.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_randevu.Enabled = true;
            saat = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    
        private void btn_randevu_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(tarih + " " +saat + " tarihinde " + Alan +" bölümünden " +  doktorAd +" ile randevunuz oluşturulmuştur."    );

            
            TemizlemeMetodu();
         
        }
        private void TemizlemeMetodu()
        {
            foreach (Control item in this.Controls) 
            {
                if (item is ComboBox) 
                {
                    ComboBox cbox = (ComboBox)item;                     
                    cbox.Text = null;
                }
                if (item is MonthCalendar)
                {
                    MonthCalendar mc = (MonthCalendar)item;
                    mc.SelectionRange.Start = DateTime.Now;
                    monthCalendar1.Enabled = false;
                }
                if (item is DataGridView)
                {
                    DataGridView dgv = (DataGridView)item;
                    dgv.Enabled = false;
                    dgv.DataSource = null;
                    dt2.Columns.Clear();
                    dt2.Rows.Clear();

                }
                if(item is Button)
                {
                    Button btn = (Button)item;
                    btn.Enabled = false;
                }

            }
        }
    }
}
