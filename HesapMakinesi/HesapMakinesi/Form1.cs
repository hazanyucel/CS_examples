using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
           
        }
        int artiKontrol = 0;
        int eksiKontrol = 0;
        int carpimKontrol = 0;
        int bolmeKontrol = 0;
        int modKontrol=0;
        double num1;
        double num2;

        private void button6_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            carpimKontrol++;


        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            num2=Convert.ToDouble(textBox1.Text);

            num2 = Convert.ToDouble(textBox1.Text);
            double sonuc = 0;
            if (artiKontrol == 1)
            {
                sonuc = num1 + num2;
                textBox1.Text = Convert.ToString(sonuc);
                artiKontrol = 0;
            }
            else if (eksiKontrol == 1)
            {
                sonuc = num1 - num2;
                textBox1.Text = Convert.ToString(sonuc);
                eksiKontrol = 0;
            }
            else if (carpimKontrol == 1)
            {
                sonuc = num1 * num2;
                textBox1.Text = Convert.ToString(sonuc);
                carpimKontrol = 0;
            }
            else if(modKontrol == 1)
            {
                sonuc = num1 % num2;
                textBox1.Text = Convert.ToString(sonuc);
                modKontrol = 0;
            }
            if (bolmeKontrol == 1 && num2 != 0)
            {
                sonuc = num1 / num2;
                textBox1.Text = Convert.ToString(sonuc);
                bolmeKontrol = 0;
            }
            else if (bolmeKontrol == 1 && num2 == 0)
            {

                textBox1.Font = new Font("Arial", 11);
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.Text = "SIFIRA BÖLÜNEMEZ";
                bolmeKontrol = 0;

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
         

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            artiKontrol++;

        }

        private void button7_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            eksiKontrol++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            bolmeKontrol++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            modKontrol++;
        }
    }
}