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
            Kiuas kiuas = new Kiuas(false,0.0,0.0);

            kiuas.printData();

            kiuas.onOff();

            while (kiuas.Power == true)
            {
                kiuas.saadaLampotila();
                kiuas.saadaKosteus();
                kiuas.printData();

                Console.WriteLine("\nJatketaanko kiukaan säätämistä (K/E)?");
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
                            kiuas.Power = true;
                            break;
                        case 'e':
                        case 'E':
                            kiuas.Power = false;
                            break;
                        default:
                            Console.WriteLine("Error! Et vastannut K tai E! Ohjelma lopetetaan!");
                            break;
                    }
                }
            }
            if (kiuas.Power == false)
            {
                Console.WriteLine("Kiuas on pois päältä\n");
                kiuas.Lampotila = 0.0;
                kiuas.Kosteus = 0.0;
                kiuas.printData();
            }
            

            Console.ReadLine();
        }
    }
}
