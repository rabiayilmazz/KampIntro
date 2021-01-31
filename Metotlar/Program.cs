using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Urun elma = new Urun();
            elma.Adi = "elma";
            elma.Fiyat = 10;
            elma.Aciklama = "Amasya";

            Sepet sepet = new Sepet();
            sepet.ekle(elma);
        }
    }
}
