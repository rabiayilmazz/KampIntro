using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("konut kredisi hesapla metodu");
        }

        public void Makbuz()
        {
            throw new NotImplementedException();
        }
    }
}
