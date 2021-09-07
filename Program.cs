using System;

namespace OOPGelismis
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "21312";
            musteri1.Adi = "Doğan";
            musteri1.Soyadi = "Ay";
            musteri1.Tcno = "12312312";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12313";
            musteri2.SirketAdi = "Holding";
            musteri2.VergiNo = "12341231";

            //gerçek Müşteri - tüzel müşteri 

            Musteri musteri3 = new GercekMusteri();
            
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);

            
        }
    }
}
