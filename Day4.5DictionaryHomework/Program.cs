using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4._5DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ocak");
            myDictionary.Add(2, "Şubat");
            myDictionary.Add(3, "Mart");
            myDictionary.Add(4, "Nisan");

            foreach (var key in myDictionary.Keys)
            {
                Console.WriteLine("Index Number :" + key);
            }
            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine("Output :" + value);
            }

            Console.Read();
        }
    }
}
