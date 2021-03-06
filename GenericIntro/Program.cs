using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList<string> mylist = new MyList<string>();
            mylist.Add("davut");
            mylist.Add("tarık");
            mylist.Add("bakır");
            Console.WriteLine(mylist.Length);
            mylist.Add("hiroo");
            Console.WriteLine(mylist.Length);

            foreach (string isim in mylist.Items)
            {
                Console.WriteLine(isim);
            }


        }
    }
}
