using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkotomasyonn
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
   
            frmAraçOtoparkKaydı kayit = new frmAraçOtoparkKaydı();
     
           
            kayit.Location = new Point(600,150);
            kayit.Show();
            Hide();
     

        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkYerleri yer = new frmAraçOtoparkYerleri();
           
            yer.Location = new Point(600, 150);
            yer.Show();
            Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkÇıkış çıkış = new frmAraçOtoparkÇıkış();
       
            çıkış.Location = new Point(600, 150);
            çıkış.Show();
            Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
          
            satis.Location = new Point(222,65);
            satis.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.Show();
            Hide();
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
        }
        public void PanelPla_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
