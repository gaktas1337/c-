﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi");
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " Silindi");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
