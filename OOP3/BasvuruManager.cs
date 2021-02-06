using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService log)
        {
            // bilgiler alınır hesaplar yapılır
            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();
            krediManager.Hesapla();
            log.Log();
            // Console.WriteLine("");
        }
        public void KrediBilgilendirme(List<IKrediManager> krediler )
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
