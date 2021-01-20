using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManeger
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "EEKLENDİ.");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "GÜNCELLENDİ.");

        }
    }
}
