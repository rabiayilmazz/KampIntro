using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyac kredisi hesapla metodu");
        }

        public void Makbuz()
        {
            throw new NotImplementedException();
        }
    }
}
