using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classİntro
{
    class Program2
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.ProductName = "pamuklu dar kesim t shirt";
            Product1.ProductPrice = 128;
            Product1.ProductReviewCount = 67;
            Product1.ProductShippingincluded = true;

            Product Product2 = new Product();
            Product2.ProductName = "slim fit baskılı t shirt";
            Product2.ProductPrice = 191;
            Product2.ProductReviewCount = 27;
            Product2.ProductShippingincluded = false;

            Product Product3 = new Product();
            Product3.ProductName = "skinny fit kot pantolon ";
            Product3.ProductPrice = 288;
            Product3.ProductReviewCount = 46;
            Product3.ProductShippingincluded = true;

            Product[] Products = new Product[] { Product1, Product2, Product3 };

            foreach (var Product in Products)
            {
                Console.WriteLine(Product.ProductName + " " +"Ürünün Ücreti = " + Product.ProductPrice + " " + "Ürünün Yorum Sayısı = " + Product.ProductReviewCount + " ");
                if (Product.ProductShippingincluded)
                {
                    Console.WriteLine("Kargo Ücretsiz");
                }
                else
                {
                    Console.WriteLine("Kargo ücretli");
                }
            }
            Console.ReadLine();
        }
    }

    
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductReviewCount { get; set; }
        public bool ProductShippingincluded { get; set; }
    } 
}


