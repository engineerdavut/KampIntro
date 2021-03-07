using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Dizayn Patternlerin olmasinin nedeni basvuru yap icine aldigi parametre.
        //Method injection. 
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            //loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }

        }
        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
