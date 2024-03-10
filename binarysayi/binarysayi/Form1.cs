using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binarysayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSayi=textBox1.Text;
            int decimall= 0, us = 0;
            for (int i = strSayi.Length-1;i>=0; i--)
            {
                int basamak = Convert.ToInt32(strSayi[i] - '0');
                decimall += basamak * (int)Math.Pow(2, us++);
            }
            label1.Text= decimall.ToString();   
        }
    }
}
