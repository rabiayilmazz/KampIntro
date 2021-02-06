using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService database = new DatabaseLoggerService();
            ILoggerService file = new FileLoggerService();

            BasvuruManager basvuru = new BasvuruManager();
            BasvuruManager basvuru2 = new BasvuruManager();
            basvuru.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            basvuru2.BasvuruYap(new EsnafKrediManeger(), new SmsLoggerServise());


            //basvuru.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
            //basvuru.KrediBilgilendirme(krediler);

        }
    }
}
