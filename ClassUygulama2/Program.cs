using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(5, 6);
            Console.WriteLine("Dikdörtgenin Alanı: {0}",dikdortgen.AlanHesapla());
            Console.WriteLine("Dikdörtgenin Çevresi: {0}", dikdortgen.CevreHesapla());
            Console.ReadLine();
        }
    }
}
