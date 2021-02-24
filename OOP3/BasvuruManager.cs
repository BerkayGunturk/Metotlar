using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) //Her kredi çeşitine erişmemizi sağlıyor IKrediManager
        {
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // Dizinin kaç tane oldugunu bılmedıgımızde List kullanırız!
        {                                                                   // İster 1 İster 1000 elemanlı olabilir
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
