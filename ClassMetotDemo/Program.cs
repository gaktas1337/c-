using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 158,
                FirstName = "zafer",
                LastName = "Demir"
            };

            Musteri musteri2 = new Musteri
            {
                Id = 148,
                FirstName = "Mehmet",
                LastName = "Kara"
            };

            Musteri[] musteri = new Musteri[] {musteri1,musteri2, };

            foreach (var Musteri in musteri)
            {
                Console.WriteLine(Musteri.Id);
                Console.WriteLine(Musteri.FirstName);
                Console.WriteLine(Musteri.LastName);

            }

            MusteriManager musteriManagercagır = new MusteriManager();
            musteriManagercagır.Ekle();
            musteriManagercagır.Listele();
            musteriManagercagır.Sil();
            Console.ReadKey();
        }
    }
}
