using System;

namespace RefveOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 78;
            int sayi2 = 83;
            int sayi3;
            Console.WriteLine("Sayi 1 " + sayi1);

            int sonuc = Add3(sayi1, sayi2);
            Console.WriteLine("Sonuc " + sonuc);
            sonuc = Add(ref sayi1, sayi2);
            Console.WriteLine("Sonuc " + sonuc);
            Console.WriteLine("Sayi 1 " + sayi1);

            sonuc = Add2(out sayi3, sayi2);
            Console.WriteLine("Sonuc " + sonuc);
            Console.WriteLine("Sayi 3 " + sayi3);




        }
        static int Add(ref int sayi1, int sayi2)
        {
            sayi1 = 923;
            return sayi1 + sayi2;
        }
        static int Add2(out int sayi3, int sayi2)
        {
            sayi3 = 948;
            return sayi3 + sayi2;
        }
        static int Add3(int sayi1, int sayi2)
        {
            sayi1 = 955;
            return sayi1 + sayi2;
        }
    }
}
