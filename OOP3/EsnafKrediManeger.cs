using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKrediManeger : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi heasaplandı!!!");
        }

        public void IslemYap()
        {
            Console.WriteLine("Esnaf kredisi işlemi yapıldı!!!");
        }
    }

}
   
