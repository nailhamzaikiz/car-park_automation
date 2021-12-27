using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace parkotomasyonn
{
    public partial class frmAraçOtoparkYerleri : Form
    {
        public frmAraçOtoparkYerleri()
        {
            InitializeComponent();

            }

        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=arac_otopark;Integrated Security=True");

        private void frmAraçOtoparkYerleri_Load(object sender, EventArgs e)
        {
            BoşParkYerleri();
            DoluparkYerleri();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac_otopark_kaydi", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString())
                        {
                            item.Text = read["plaka"].ToString();
                        }
                    }
                }
            }
            baglanti.Close();
        }
        private void BoşParkYerleri()
        {
            int sayac = -7;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                }
            }
        }
        private void DoluparkYerleri()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from aracdurumu", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmAnasayfa ana = new frmAnasayfa();
            ana.Show();
            ana.Location = new Point(500, 200);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
