using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();// en başa IİhtiyacKrediManager de yazabilirdik.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new SmsLoggerService());// Yukarıda açıklama yapmadan new diyip daha kolay eriş.

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
