using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableKoleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            //hashtable nesnesi oluşturma
            Hashtable ogrenciler = new Hashtable();
            ogrenciler.Add(550, "Evin");//veri ekleme 1.yol
            ogrenciler.Add("Miray", 551);//veri ekleme 2.yol
            ogrenciler.Add(552, "Hazal");
            ogrenciler.Add(553, "Ehad");
            ogrenciler.Add(554, "Deniz");
            ogrenciler.Add(555, "Emirhan");

            //silme
            ogrenciler.Remove(550);
            ogrenciler.Remove("Ehad");

            //güncelleme
            ogrenciler[554] = "Kerim";

            foreach (var anahtar in ogrenciler.Keys)
            {
                Console.WriteLine(anahtar);
            }
            foreach (var deger in ogrenciler.Values)
            {
                Console.WriteLine(deger);
            }
            foreach(DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key+" - "+eleman.Value);
            }
            Console.ReadLine();
        }
    }
}
