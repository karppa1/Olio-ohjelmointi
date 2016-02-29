using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone(false, "-", 0, 0);

            pesukone.printData();
            pesukone.onOff();

            while (pesukone.Power == true)
            {
                pesukone.valitseOhjelma();
                pesukone.saadaLinkous();
                pesukone.saadaAika();
                pesukone.printData();

                Console.WriteLine("\nJatketaanko pesukoneen käyttöä (K/E)?");
                string line = Console.ReadLine();
                Console.WriteLine();

                int number = 0;
                bool result1 = int.TryParse(line, out number);
                if (result1)
                {
                    Console.WriteLine("Error! Et vastannut K tai E! Ohjelma lopetetaan!");
                    return;
                }
                char vastaus;
                bool result2 = char.TryParse(line, out vastaus);
                if (result2)
                {
                    switch (vastaus)
                    {
                        case 'k':
                        case 'K':
                            pesukone.Power = true;
                            break;
                        case 'e':
                        case 'E':
                            pesukone.Power = false;
                            break;
                        default:
                            Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!");
                            pesukone.Power = false;
                            break;
                    }
                }
            }
            if (pesukone.Power == false)
            {
                Console.WriteLine("Pesukone on pois päältä\n");
                pesukone.Ohjelma = "-";
                pesukone.Kierros = 0;
                pesukone.Kesto = 0;
                pesukone.printData();
            }

            Console.ReadLine();
        }
    }
}
