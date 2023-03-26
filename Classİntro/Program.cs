using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "c#";
            kurs1.Egitmen = "Enging Demiroğ";
            kurs1.izlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.izlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "C++";
            kurs4.Egitmen = "Murat Kurtbogan";
            kurs4.izlenmeOranı = 100;

            //Console.WriteLine(kurs1.KursAdı + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2 , kurs3 , kurs4};

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.KursAdı + " : " + Kurs.Egitmen);
            }




            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOranı { get; set; }
    }
}

