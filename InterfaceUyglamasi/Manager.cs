using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUyglamasi
{
    class Manager : IWorker,ISalary,IEat
    {
        public void Eat()
        {
            Console.WriteLine("Yonetici yemek yer");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yonetici maaş alır.");
        }

        public void Work()
        {
            Console.WriteLine("Yonetici çalışıyor.");
        }
    }
}
