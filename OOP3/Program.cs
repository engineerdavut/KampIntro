using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            // interface aynı referansı tutar.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            List<ILoggerService> loggers = new List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService() };
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            // iceride de new lenip gonderilebilir parametre olarak
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService> { new FileLoggerService(), new SmsLoggerService() });
            basvuruManager.BasvuruYap(konutKrediManager,new List<ILoggerService> { databaseLoggerService, new FileLoggerService() });

            List<IKrediManager> krediler= new List<IKrediManager>() {konutKrediManager ,ihtiyacKrediManager,tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmeYap(krediler);

        }
    }
}
