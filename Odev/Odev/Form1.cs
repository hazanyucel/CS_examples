using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mutlak_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox3.Text);
            if (sayi < 0)
            {
                sayi = sayi * (-1);
                textBox3.Text = Convert.ToString(sayi);

            }
            else
                textBox3.Text = Convert.ToString(sayi);
        }

        private void karekok_Click(object sender, EventArgs e)
        {
            // girilen sayının karekökünü, 1 ve sayı arasındaki orta değere bakarak bulmaya çalışıyor
            

            double sayi = Convert.ToDouble(textBox3.Text);
            double epsilon = 0.00001; // Hesaplama hassasiyeti
            double baslangic = 0;
            double son = Math.Max(1, sayi);
            double orta = (baslangic + son) / 2;

            while (son - baslangic > epsilon)
            {
                orta = (baslangic + son) / 2;
                if (orta * orta > sayi)
                    son = orta;
                else
                    baslangic = orta;
            }
            textBox3.Text = Convert.ToString(orta);
        }

        private void max_Click(object sender, EventArgs e)
        {
            double max = -1;
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                
                string[] numbers = textBox3.Text.Split(',');
                double[] doublenum = new double[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    double sayi= Convert.ToDouble(numbers[i]);
                    
                    doublenum[i] = sayi;

                }
                for (int i = 0; i < doublenum.Length-1; i++)
                {
                    if (doublenum[i] < doublenum[i+1])
                    {
                        max = doublenum[i + 1];
                    }
                    
                }

            }
            textBox3.Text= max.ToString();
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double aci =Convert.ToDouble(textBox3.Text);  
            double sinus=Math.Sin((Math.PI * aci) / 180.0);
            textBox3.Text = Convert.ToString(sinus);
        }

        private void cps_Click(object sender, EventArgs e)
        {
            double aci = Convert.ToDouble(textBox3.Text);
            double cosinus=Math.Cos((Math.PI * aci) / 180.0);
            textBox3.Text = Convert.ToString(cosinus);
        }

        private void çiz_Click(object sender, EventArgs e)
        {
            
            // Başlangıç ve bitiş değerlerini al
            double baslangic = Convert.ToDouble(textBox1.Text);
            double bitis = Convert.ToDouble(textBox2.Text);

            // Grafiği çizmek için Graphics nesnesi oluştur
            Graphics g = panel1.CreateGraphics();
            Pen sinPen = new Pen(Color.Blue);
            Pen cosPen = new Pen(Color.Red);

            // Panel boyutları
            int width = panel1.Width;
            int height = panel1.Height;
            int centerX = width / 2;
            int centerY = height / 2;

            // Ölçek
            double scale = 40;
            g.DrawLine(Pens.Black, 0, centerY, width, centerY); // X ekseni
            g.DrawLine(Pens.Black, centerX, 0, centerX, height); // Y ekseni

            // Başlangıçtan bitişe kadar adım adım grafiği çiz
            for (double x = baslangic; x <= bitis; x += 0.1)
            {
                if (checkBox1.Checked)
                {
                    double sinValue = Math.Sin(x);
                    double sinY = centerY - sinValue * scale;
                    g.DrawLine(sinPen, (float)(x * scale) + centerX, (float)sinY, (float)(x * scale) + centerX, (float)sinY + 1);
                }


                if (checkBox2.Checked)
                {
                    double cosValue = Math.Cos(x);
                    double cosY = centerY - cosValue * scale;
                    g.DrawLine(cosPen, (float)(x * scale) + centerX, (float)cosY, (float)(x * scale) + centerX, (float)cosY + 1);
                }
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gerial_Click(object sender, EventArgs e)
        {
            textBox3.Text= string.Empty;
            panel1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
