using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKrediManeger : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("ESNAF KREDİ MANAGER HESAPLANDI");
        }

        public void Makbuz()
        {
            throw new NotImplementedException();
        }
    }
}
