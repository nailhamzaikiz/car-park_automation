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
    public partial class frmAraçOtoparkKaydı : Form
    {
        public frmAraçOtoparkKaydı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI;Initial Catalog=arac_otopark;Integrated Security=True");
        private void frmAraçOtoparkKaydı_Load(object sender, EventArgs e)
        {
            Boşaraçlar();
        }
        private void Boşaraçlar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from aracdurumu WHERE durumu='BOS'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnasayfa ana = new frmAnasayfa();
            ana.Show();
            ana.Location = new Point(500,200);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into arac_otopark_kaydi(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih)"+
                "values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@tc", textTC.Text);
            komut.Parameters.AddWithValue("@ad", textAD.Text);
            komut.Parameters.AddWithValue("@soyad", textSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", texttelefon.Text);
            komut.Parameters.AddWithValue("@email", textEmail.Text);
            komut.Parameters.AddWithValue("@plaka", textPlaka.Text);
            komut.Parameters.AddWithValue("@marka", comboBoxMarka.Text);
            komut.Parameters.AddWithValue("@seri", textBoxSeri.Text);
            komut.Parameters.AddWithValue("@renk", textBoxRenk.Text);
            komut.Parameters.AddWithValue("@parkyeri", comboBoxParkYeri.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update aracdurumu set durumu='DOLU' where parkyeri='"+comboBoxParkYeri.SelectedItem+"'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç kaydı oluşturuldu", "Kayıt");
            comboBoxParkYeri.Items.Clear();
            Boşaraçlar();
            foreach(Control item in grupKişi.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grupAraç.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grupAraç.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grupKişi_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
