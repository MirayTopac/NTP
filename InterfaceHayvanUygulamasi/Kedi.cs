using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHayvanUygulamasi
{
    class Kedi : IHayvan,IBeslen
    {
        public void Beslen()
        {
            Console.WriteLine("Kedi süt içti");
        }

        public void SesCikar()
        {
            Console.WriteLine("Kedi : miav miav");
        }
    }
}
