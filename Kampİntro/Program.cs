using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği

            string kategoriEtiketi = "KATEGORİ";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;

            //Do not repeat yourself - kendini tekrarlama

            Console.WriteLine(kategoriEtiketi);
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("AZALIŞ BUTONU");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("ARTIŞ BUTONU");
            }
            else
            {
                Console.WriteLine("DEĞİŞMEDİ BUTONU");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("KULLANICI AYARLARI BUTONU");
            }
            else
            {
                Console.WriteLine("GİRİŞ YAP BUTONU");
            }
        }
    }
}
