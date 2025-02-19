using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        void kodOlustur()
        {
            Random rnd = new Random();  
            int say=rnd.Next(10000,100000);
            textKod2.Text = say.ToString();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodOlustur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textKullaniciAdi.Text=="Bilgisayar"&&textSifre.Text=="12345"&&textKod1.Text==textKod2.Text)
            {
                Form2 frm = new Form2();
                frm.kullanici=textKullaniciAdi.Text;
                frm.ShowDialog();
                this.Hide();
                
            }
            
        }

        private void textKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
