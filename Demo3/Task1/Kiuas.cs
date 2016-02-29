using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Kiuas
    {
        public bool Power { get; set; }
        public double Lampotila { get; set; }
        public double Kosteus { get; set; }

        public Kiuas(bool power, double lampotila, double kosteus)
        {
            Power = power;
            Lampotila = lampotila;
            Kosteus = kosteus;
        }

        public void onOff()
        {
            Console.WriteLine("\nLaitetaanko kiuas päälle (K/E)?");
            string line = Console.ReadLine();

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
                    case 'K': Power = true;
                        Console.WriteLine("Kiuas on päällä");
                        break;
                    case 'e':
                    case 'E': Power = false;
                        break;
                    default: Console.WriteLine("Error! Et vastannut K tai E! Ohjelma lopetetaan!");
                        break;
                }
            }
            
        }

        public void saadaLampotila()
        {
            Console.WriteLine("Aseta haluttu lämpötila:");
            string line = Console.ReadLine();

            double number = 0.0;
            bool result2 = double.TryParse(line, out number);
            if (result2)
            {
                Lampotila = number;
            }

            else
            {
                Console.WriteLine("Virheellinen lämpötila!\n");
            }
        }

        public void saadaKosteus()
        {
            Console.WriteLine("Aseta haluttu kosteus:");
            string line = Console.ReadLine();

            double number = 0.0;
            bool result2 = double.TryParse(line, out number);
            if (result2)
            {
                Kosteus = number;
            }

            else
            {
                Console.WriteLine("Virheellinen kosteus!\n");
            }
        }

        public void printData()
        {
            string tila = "";
            if (Power == true)
            {
                tila = "ON";
            }
            else
            {
                tila = "OFF";
            }
            Console.WriteLine("Kiukaan tiedot:");
            Console.WriteLine("Virta: " + tila);
            Console.WriteLine("Lämpötila: " + Lampotila + " astetta");
            Console.WriteLine("Kosteus: " + Kosteus + " %");
        }
    }
}
