using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.ID = 1;
            musteri1.Adi = "faruk";
            musteri1.Soyadi = "cam";
            musteri1.TcNo = "43245254354";
            musteri1.MusteriNo = "344546567";



            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "6456546";
            musteri2.SirketAdi = "kıta reklamcilik";
            musteri2.VergiNo = "567898";

            Musteri musreri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


        }
    }
}
