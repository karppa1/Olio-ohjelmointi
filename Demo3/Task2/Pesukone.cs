using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pesukone
    {
        public bool Power { get; set; }
        public string Ohjelma { get; set; }
        public int Kierros { get; set; }
        public double Kesto { get; set; }

        public Pesukone(bool power,string ohjelma,int kierros,double kesto)
        {
            Power = power;
            Ohjelma = ohjelma;
            Kierros = kierros;
            Kesto = kesto;
        }

        public void onOff()
        {
            Console.WriteLine("\nLaitetaanko pesukone päälle (K/E)?");
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
                    case 'K':
                        Power = true;
                        Console.WriteLine("Pesukone on päällä");
                        break;
                    case 'e':
                    case 'E':
                        Power = false;
                        break;
                    default:
                        Console.WriteLine("Error! Et vastannut K tai E! Ohjelma lopetetaan!");
                        break;
                }
            }
        }

        public void valitseOhjelma()
        {

        }

        public void saadaLinkous()
        {
            Console.WriteLine("Säädä linkouksen kierrokset:");
            string line = Console.ReadLine();

            int number = 0;
            bool result2 = int.TryParse(line, out number);
            if (result2)
            {
                Kierros = number;
            }

            else
            {
                Console.WriteLine("Virheellinen kierrosluku!\n");
            }
        }

        public void saadaAika()
        {
            Console.WriteLine("Säädä ohjelman kesto (esim 1,15):");
            string line = Console.ReadLine();

            double number = 0.0;
            bool result2 = double.TryParse(line, out number);
            if (result2)
            {
                Kesto = number;
            }

            else
            {
                Console.WriteLine("Virheellinen aika!\n");
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
            Console.WriteLine("Pesukoneen tiedot:");
            Console.WriteLine("Virta: " + tila);
            Console.WriteLine("Pesuohjelma: " + Ohjelma);
            Console.WriteLine("Linkous: " + Kierros + " kierrosta/min");
            Console.WriteLine("Pesuohjelman kesto: " + Kesto + " tuntia");
        }
    }
}
