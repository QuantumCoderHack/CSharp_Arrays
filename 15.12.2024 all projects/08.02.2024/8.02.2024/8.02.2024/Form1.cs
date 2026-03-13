using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Collections_15._02._2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int[] deger = new int[50];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 50; i++)
                listBox1.Items.Add(deger[i]);

            elemancount = deger.Length - 1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
                deger[i] = rnd.Next(1, 100);
            MessageBox.Show("dizi oluşturuldu");
        }
        int elemancount = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int[] deger2 = new int[elemancount];
            for (int i = 0; i < elemancount; i++)
            {
                deger2[i] = deger[i];
                listBox1.Items.Add(deger2[i]);
            }
            if (elemancount > 0)
                elemancount--;
            label1.Text = "ıtems count =" + (deger2.Length - 1).ToString();



        }
    }
}

        
            
                
                
               
        
   


