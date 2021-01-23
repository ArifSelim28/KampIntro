using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arif Selim Öztürk
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "134728";
            musteri1.Adı = "Arif Selim";
            musteri1.Soyadi = "Öztürk";
            musteri1.TcNo = "012313131241";

            //Kodlama.İo

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 28;
            musteri2.MusteriNo = "13213312";
            musteri2.SirketAdı = "Kodlama.io";
            musteri2.VergiNo = "132312414";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);






        }
    }
}
