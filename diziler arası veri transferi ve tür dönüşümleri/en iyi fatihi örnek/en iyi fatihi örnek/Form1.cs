using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace en_iyi_fatihi_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int sayac = 0;
            string[]start=new string[5];
            int i=0;
            string numbers="";
        private void button1_Click(object sender, EventArgs e)
        {
           start[sayac]=textBox1.Text;
           sayac += 1;
            MessageBox.Show("eklenti alan =" + (5 - sayac).ToString());
            if(sayac==5)
            {
                MessageBox.Show("alan kapasitesi dolmuştur.");
                button1.Enabled = false;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbers = string.Join(",", start);
            string newnumbers=numbers.Replace(',',(char)13);
            MessageBox.Show(newnumbers);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            MessageBox.Show("Sıfırlandı");
            for(int i=0;i<5;i++)
            {
                start[i] = "";
            }
        }
    }
}
