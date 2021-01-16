using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        // syntax

        public void Ekle(Urun urun)
        {
            Console.WriteLine("TEBRİKLER.SEPETE EKLENDİ : " + urun.Adi);
        }
        public void Ekle2(string urunAdı, string aciklama,double fiyati,int stokAdedi)
        {
            Console.WriteLine("TEBRİKLER.SEPETE EKLENDİ :" + urunAdı);
        }

    }
}
