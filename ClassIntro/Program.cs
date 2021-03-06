using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "Java";
            kurs1.kursegitmeni = "engin demirog";
            kurs1.izlenmeorani = 6;


            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "c++";
            kurs2.kursegitmeni = "engin demirog";
            kurs2.izlenmeorani = 8;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "python";
            kurs3.kursegitmeni = "engin demirog";
            kurs3.izlenmeorani = 10;


            Product product1 = new Product();
            product1.productname = "Lenovo V15-IIL Intel Core i5 1035G1 8GB 256GB SSD Windows 10 Home 15.6 FHD Taşınabilir Bilgisayar 82C5000QTX";
            product1.productprice = 5799.00;
            product1.productrate = 4.7;
            product1.productcategory = "Bigisayarlar";

            Product product2 = new Product();
            product2.productname = "Matematik Hayattır: Hayatımızı Süsleyen Matematik Parçaları-Theoni Pappas";
            product2.productprice = 30.59;
            product2.productrate = 5.0;
            product2.productcategory = "Kitaplar";

            Product product3 = new Product();
            product3.productname = "Çaykur Tiryaki 1000 gr Dökme Çay";
            product3.productprice = 34.89;
            product3.productrate = 4.8;
            product3.productcategory = "İçecek ürünleri";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + "  :  " + kurs.kursegitmeni);
            }
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            foreach (var product in products)
            {
                Console.WriteLine(product.productname + "  :  " + product.productprice +"   :  "+product.productcategory);
            }
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productname + "  :  " + products[i].productprice + "   :  " + products[i].productrate);
            }
            int k = 1;
            while (k < 3)
            {
                Console.WriteLine(products[k].productname + "  :  " + products[k].productprice + "   :  " + products[k].productrate);
                k++;
            }
        }
        class Kurs
        {
            public string kursAdi { get; set; }

            public string kursegitmeni { get; set; }

            public int izlenmeorani { get; set; }


        }
        class Product
        {
            public string productname { get; set; }

            public double productprice { get; set; }

            public double productrate { get; set; }

            public string productcategory { get; set; }


        }
    }
}
