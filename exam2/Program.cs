using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {

            Clients client1 = new Clients();
            client1.Id = 248;
            client1.Name = "Zafer";
            client1.Surname = "demir";
            client1.City = "ankara;";

            Clients client2 = new Clients();
            client2.Id = 197;
            client2.Name = "Mehmet ";
            client2.Surname = "kara ";
            client2.City = "Yozgat ";

            


            Clients[] Clients = new Clients[] { };

            foreach (Clients client in Clients)
            {
                Console.WriteLine(client.Id);
                Console.WriteLine(client.Name);
                Console.WriteLine(client.Surname);
                Console.WriteLine(client.City);
            }
            Console.ReadLine();
        }
    }
}
