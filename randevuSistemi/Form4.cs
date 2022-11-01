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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
        private void btn_BilgiGoruntule_Click(object sender, EventArgs e)
            
        {
            if (textBox_TC.Text != "" && textBox_TC.Text.Length < 11 )
            {
             
                SqlDataAdapter dap = new SqlDataAdapter("select h.HastaAdi,h.HastaSoyAdi,m.MGiris,m.MCikis,t.TahlilTur,ht.TahlilSonuc,ted.TedaviTanim , mt.ReceteAdi " +
                    "from  HastaTahlil ht full outer join Tahliller t on t.TahlilID = ht.TahlilID full outer join Hasta h on h.HastaID=ht.HastaID full outer join Muayene m on m.HastaID = h.HastaID full outer join MuayeneTedavi mt on mt.MID=m.MID full outer join Tedavi ted on ted.TedaviID=mt.TedaviID " +
                    "where h.Tc_Passaport=@tc", con);
                dap.SelectCommand.Parameters.AddWithValue("@tc", textBox_TC.Text);              
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı");
                }
               
          
                Temizle();
            }
          
        }

        private void Temizle()
        {
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
    }
}
