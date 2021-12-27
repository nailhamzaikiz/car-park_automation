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
    public partial class Admin : Form
    {
public Admin()
{
    InitializeComponent();
}
int sayac = 3;
private void button1_Click(object sender, EventArgs e)
{
    frmAnasayfa yeni = new frmAnasayfa();
    if (textBox1.Text == "" && textBox2.Text == "")
    {
        MessageBox.Show("Kullanacı adı ve/veya şifre boş geçilmez.","Dikkat");
    }
    else
    {
        if(textBox1.Text=="admin" && (textBox2.Text=="berke" || textBox2.Text == "hamza"))
        {
            yeni.Show();
            this.Hide(); 
        }
        else
        {
            sayac--;
            MessageBox.Show("Kullanıcı adı veya şifre hatalı.Kalan hakkınız="+sayac,"Dikkat");
            if (sayac == 0)
            {
                Application.Exit();
            }
        }
    }  
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                eye.Image = parkotomasyonn.Properties.Resources.eye;
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                eye.Image = parkotomasyonn.Properties.Resources.eye_off__1_;
                textBox2.UseSystemPasswordChar = false;
            }

            ;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            eye.Image = parkotomasyonn.Properties.Resources.eye;
            textBox2.UseSystemPasswordChar = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
