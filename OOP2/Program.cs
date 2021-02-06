using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 123;
            musteri1.MusteriNo = "1233";
            musteri1.Adi = "Rabia";
            musteri1.Soyadi = "YILMAZ";
            musteri1.TcNo = "111232323435";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 123;
            musteri2.MusteriNo = "1233";
            musteri2.SirketAdi = "şirket";
            musteri2.VeriNo = "1232443";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager manager = new CustomerManager();
            manager.Ekle(musteri1);
            manager.Ekle(musteri2);
            manager.Ekle(musteri3);
            manager.Ekle(musteri4);

        }
    }
}
