using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tila = true;                           // Kesken...
            List<string> teksti = new List<string>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kirjoita merkkijono > ");
                string line = Console.ReadLine();

                teksti.Add(line);
            }

            Console.WriteLine();
            foreach(string data in teksti)
            {
                Console.WriteLine(data);
            }

            Console.ReadLine();
        }
    }
}
