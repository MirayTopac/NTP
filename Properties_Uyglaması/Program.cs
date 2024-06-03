using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Uyglaması
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriYonetimi musteriyonet = new MusteriYonetimi();
            musteriyonet.Ekle();
            musteriyonet.Guncelle();

            MusteriBilgileri musteri1 = new MusteriBilgileri();
            musteri1.Id = 1;
            musteri1.Ad = "Miray";
            musteri1.Soyad = "Topaç";
            musteri1.Sehir = "Konya";

            MusteriBilgileri musteri2 = new MusteriBilgileri
            {
                Id = 2,
                Ad = "Hazal",
                Soyad = "Doğan",
                Sehir = "Erzurum",
            };
            Console.WriteLine(musteri2.Sehir);
            Console.ReadLine();
        }
    }
}
