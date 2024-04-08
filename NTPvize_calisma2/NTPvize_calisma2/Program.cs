using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTPvize_calisma2
{
    class Kutu
    {
        public double length; 
        public double breadth; //genislik 
        public double height;

    }
   
     class Program
    {
        static void Main(string[] args)
        {
            Kutu kutu1=new Kutu();
            Kutu kutu2 = new Kutu();
            double volume = 0.0; //kutunun hacmini hesaplamak icin

            //Nesne1 ozellikleri
            kutu1.height = 5.0;
            kutu1.breadth = 9.0;
            kutu1.length = 6.9;

            //Nesne2 ozellikleri
            kutu2.length = 3.5;
            kutu2.height = 5.8;
            kutu2.breadth = 3.0;

            //hacim hesaplama
            volume = kutu1.height * kutu1.length * kutu1.breadth;
            Console.Write("volume of kutu1: {0} ", volume);


            volume=kutu2.breadth * kutu2.height * kutu2.length;
            Console.Write("volume of kutu2: {0} ",volume);
            Console.ReadKey();

        }
    }
}
