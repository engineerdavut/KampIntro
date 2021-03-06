using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<int ,string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(06,"Ankara");
            myDictionary.Add(61, "Trabzon");
            myDictionary.Add(34, "İstanbul");
            myDictionary.Add(27, "GaziAntep");
            Console.WriteLine(myDictionary.Length);
            myDictionary.Add(44, "Malatya");
            Console.WriteLine(myDictionary.Length);
            for (int i= 0; i < myDictionary.Items.Length; i++)
            {
                Console.WriteLine(myDictionary.Items[i]+"      "+myDictionary.Items1[i]);
            }
        }
    }
}
