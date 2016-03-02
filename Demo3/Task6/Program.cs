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
            const int maxKirjaa = 5;
            Kirja[] kirjat = new Kirja[maxKirjaa];

            Kirja kirja1 = new Kirja("Olio-ohjelmointi", "Aku Ankka", 39.95, 8);
            kirjat[0] = kirja1;

            Kirja kirja2 = new Kirja("SQL", "Hessu Hopo", 29.75, 2);
            kirjat[1] = kirja2;

            Kirja kirja3 = new Kirja("C++", "Hannu Hanhi", 25.85, 1);
            kirjat[2] = kirja3;

            Kirja kirja4 = new Kirja("3D-mallinnus", "Mikki Hiiri", 24.15, 4);
            kirjat[3] = kirja4;

            Kirja kirja5 = new Kirja("Peliohjelmointi", "Pelle Peloton", 49.75, 2);
            kirjat[4] = kirja5;

            Console.WriteLine("* Myynnissä olevat kirjat *");
            Console.WriteLine("*************************");
            for(int i = 0; i < maxKirjaa; i++)
            {
                Console.WriteLine(kirjat[i]);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
