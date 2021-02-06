using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerServise : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS yollandı");
        }
    }
}
