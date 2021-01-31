using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs = new Kurs();
            kurs.egitmen = "aaaa";
            kurs.kursAdi = "bbb";
            kurs.izlenme = 678;
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenme { get; set; }


    }
}
