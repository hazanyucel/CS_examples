using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static int dizi_ortalama(int[] dizi, out double ort)
        {
            int top = 0;
            foreach (int i in dizi)
            {
                top += i;
            }
            ort=(double)top/dizi.Length;
            
            return top;
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6};
            double ort;
            int toplam=dizi_ortalama(dizi, out ort);
            Console.WriteLine("toplam: {0}, Ortalama: {1} ", toplam, ort);
        }
    }
}
