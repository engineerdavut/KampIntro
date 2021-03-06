using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] isimler = new string[] { "ali", "mehmet" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            ///Console.WriteLine(isimler[2]); patlar. Listler collectionlar kullanılır.

            List<string> isimler2 = new List<string> { "Ali", "MEHMET", "mahmut" };
            isimler2.Add("Cihan");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
        }
    }
}
