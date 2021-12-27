using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkotomasyonn
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=arac_otopark;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmSatis_Load(object sender, EventArgs e)
        {
            SatıslarıListele();
            Hesapla();
          
        }
        private void Hesapla()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satis", baglanti);
            label1.Text = "Toplam Tutar=" + komut.ExecuteScalar() + "₺";
            baglanti.Close();
        }
        private void SatıslarıListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnasayfa ana = new frmAnasayfa();
            ana.Show();
            ana.Location = new Point(500, 200);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
