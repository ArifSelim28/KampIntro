using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ARİF SELİM";
            int yas = 14;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "ARİF SELİM";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "KEREM VARIŞ";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "PYTHON";
            kurs3.Egitmen = "ENGİN DEMİROĞ";
            kurs3.İzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + "" : "" + kurs1.Egitmen)

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }



        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
