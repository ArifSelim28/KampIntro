using System;

namespace Donnguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "YAZILIM GELİŞTİRİCİ YETİŞTİRME KAMPI";
            string kurs2 = "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL";
            string kurs3 = "JAVA";
            string kurs4 = "PYTHON";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            
            //array - dizi

            string[] kurslar = new string[] { "YAZILIM GELİŞTİRİCİ YETİŞTİRME KAMPI", "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL", "JAVA","PYTHON" }; 
                
            for (int i = 0; i <4; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("SAYFA SONU - FOOTER");
        }
    }
}
