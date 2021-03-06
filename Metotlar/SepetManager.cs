using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Encapsulation
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi." + urun.Adi);
        }


        // Yanlis Kullanim.
        public void Ekle2(string urunadi,string kategori)
        {/// bir stok adedi eklemeye sayfalar patlar.
            Console.WriteLine("Sepete Eklendi." + urunadi);
        }
    }
}
