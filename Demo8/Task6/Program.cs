using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            KokonaisLasku lasku = new KokonaisLasku();

            lasku.Asiakas = "Aku Ankka";
            lasku.tuotteet.Add(new TuoteLasku("Olut", 0.89, 6));
            lasku.tuotteet.Add(new TuoteLasku("Makkara", 1.99, 2));
            lasku.tuotteet.Add(new TuoteLasku("Sinappi", 1.58, 1));

            lasku.printData();

            Console.ReadLine();
        }
    }
}
