using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUyglamasi
{
    class Worker : IWorker,ISalary,IEat
    {
        public void Eat()
        {
            Console.WriteLine("Worker yemek yer.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker maaş alır.");
        }

        public void Work()
        {
            Console.WriteLine("Worker çalışıyor.");
        }
    }
}
