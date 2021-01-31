using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "aaaa";
            string kurs2 = "bbbb";
            string kurs3 = "cccc";
            string kurs4 = "dddd";
            string kurs5 = "eeee";

            string[] kurslar = new string[] {kurs1, kurs2, kurs3, kurs4, kurs5 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
