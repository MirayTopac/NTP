using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_buyuk_sayi_bulma
{
    class BuyukSayiBul
    {
        private int a, b, c;
        public int SayiBulucu(int sayi1, int sayi2)
        {
            int sonuc;
            if(sayi1<sayi2)
            {
                sonuc = sayi2;
            }
            else
            {
                sonuc = sayi1;
            }
            return sonuc;
        }
    }
}
