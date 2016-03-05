using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Ohjelma ohjelma1 = new Ohjelma("Dokumentti", "Pelinkehitys");
            Sarja sarja1 = new Sarja("Sarja", "Walking Dead", 12);
            Elokuva elokuva1 = new Elokuva("Elokuva", "Rush Hour", 120);

            ohjelma1.printData();
            sarja1.printData();
            elokuva1.printData();

            Console.ReadLine();
        }
    }
}
