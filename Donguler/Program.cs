using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştime kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python Kursu";

            //array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştime kampı", "Programlamaya başlangıç için temel kurs", "Java Kursu" ,"Python Kursu" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-----------For döngüsü sonu--------");
            foreach (string Kurs in kurslar)
            {
                Console.WriteLine(Kurs);
            }

            Console.WriteLine("-----------sAYFA sonu--------");
            Console.ReadLine();
        }
    }
}
