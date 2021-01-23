using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            //sayı1 ?? 30

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            //sayılar1[0] 999


            //​Değişken türleri: "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
            //Referans türleri:  "string", "object", "class", "interface", "array", "delegate", "pointer"

            

        }
    }
}
