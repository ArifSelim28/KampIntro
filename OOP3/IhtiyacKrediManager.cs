using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı!!!");
        }

        public void IslemYap()
        {
            Console.WriteLine("İhtiyaç kredisi işlemi yapıldı!!!");
        }
    }
}
