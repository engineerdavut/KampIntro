using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Aciklama = "Amasya Elmasi";
            urun1.Fiyat = 3.25;

            Product urun2 = new Product();
            urun2.Adi = "muz";
            urun2.Aciklama = "Anamur muzu";
            urun2.Fiyat = 8;

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

        }
    }
}
