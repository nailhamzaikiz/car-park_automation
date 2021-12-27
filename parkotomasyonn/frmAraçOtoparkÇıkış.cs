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
    public partial class frmAraçOtoparkÇıkış : Form
    {
        public frmAraçOtoparkÇıkış()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=arac_otopark;Integrated Security=True");
        private void frmAraçOtoparkÇıkış_Load(object sender, EventArgs e)
        {
            DoluYerler();
            Plakalar();
            timer1.Enabled = true; 
        }
        private void Plakalar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac_otopark_kaydi", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboPlaka.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }
        private void DoluYerler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from aracdurumu where durumu='DOLU'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }
        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac_otopark_kaydi where plaka='"+comboPlaka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                //textBoxParkYeri2.Text = read["parkyeri"].ToString();
                
                
            }
            baglanti.Close();
            comboBoxParkYeri.SelectedIndex = 0;
        }
        private void comboBoxParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from arac_otopark_kaydi where parkyeri='" + comboBoxParkYeri.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBoxAd.Text = read["ad"].ToString();
                textBoxMarka.Text = read["marka"].ToString();
                textBoxSeri.Text = read["seri"].ToString();
                textBoxPlaka.Text = read["plaka"].ToString();
                lblGelişTarihii.Text = read["tarih"].ToString();
            }
            baglanti.Close();
            DateTime geliş, çıkış;
            geliş =DateTime.Parse(lblGelişTarihii.Text);
            çıkış= DateTime.Parse(lblÇıkışTarihii.Text);
            TimeSpan fark; 
            fark = çıkış - geliş;
            lblSüree.Text = fark.TotalHours.ToString("0.00");
            lblToplamTutarr.Text=((double.Parse(lblSüree.Text) * 1)+7).ToString("0.00");
            if (fark.Hours>12){
                lblToplamTutarr.Text = ((double.Parse(lblSüree.Text) * 0.75)+7).ToString("0.00");
            }
            if (fark.Hours>24){
                lblToplamTutarr.Text = ((double.Parse(lblSüree.Text) * 0.5)+7).ToString("0.00");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblÇıkışTarihii.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("delete from arac_otopark_kaydi where plaka='"+textBoxPlaka.Text+ "'", baglanti);
        komut.ExecuteNonQuery();
        SqlCommand komut2 = new SqlCommand("update aracdurumu set durumu='BOS' where parkyeri='" + comboBoxParkYeri.Text + "'", baglanti);
        komut2.ExecuteNonQuery();
        SqlCommand komut3 = new SqlCommand("insert into satis(parkyeri,plaka,gelis_tarihi,cikis_tarihi,süre,tutar) values(@parkyeri,@plaka,@geliş_tarihi,@çıkış_tarihi,@süre,@tutar)", baglanti);
        komut3.Parameters.AddWithValue("@parkyeri", comboBoxParkYeri.Text);
        komut3.Parameters.AddWithValue("@plaka", textBoxPlaka.Text);
        komut3.Parameters.AddWithValue("@geliş_tarihi", lblGelişTarihii.Text);
        komut3.Parameters.AddWithValue("@çıkış_tarihi", lblÇıkışTarihii.Text);
        komut3.Parameters.AddWithValue("@süre", double.Parse(lblSüree.Text));
        komut3.Parameters.AddWithValue("@tutar", double.Parse(lblToplamTutarr.Text));
        komut3.ExecuteNonQuery();
        baglanti.Close();
        MessageBox.Show("Araç Çıkışı yapıldı");

            foreach (Control item in groupBox2.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                    comboBoxParkYeri.Text = "";
                    comboPlaka.Text = "";
                }
            }
            comboPlaka.Items.Clear();
            comboBoxParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnasayfa ana = new frmAnasayfa();
            ana.Show();
            ana.Location = new Point(500, 200);
        }
        private void textBoxParkYeri2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblÇıkışTarihii_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
