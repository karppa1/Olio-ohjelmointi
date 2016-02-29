using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Televisio
    {
        public bool Power { get; set; }
        public string Kanava { get; set; }
        public string Tiedot { get; set; }

        public Televisio(bool power, string kanava, string tiedot)
        {
            Power = power;
            Kanava = kanava;
            Tiedot = tiedot;
        }

        public void onOff()
        {
            Console.WriteLine("\nLaitetaanko televisio päälle (K/E)?");
            string line = Console.ReadLine();

            int number = 0;
            bool result1 = int.TryParse(line, out number);
            if (result1)
            {
                Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!\n");
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
                        Console.WriteLine("Televisio on päällä\n");
                        break;
                    case 'e':
                    case 'E':
                        Power = false;
                        break;
                    default:
                        Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!\n");
                        Power = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!\n");
                Power = false;
            }
        }

        public void valitseKanava()
        {
            
            Console.WriteLine("Kanavavaihtoehdot: ");
            Console.WriteLine("1 Ykkönen \n2 Kakkonen \n3 Kolmonen");
            string line = Console.ReadLine();

            int number = 0;
            bool result = int.TryParse(line, out number);

            if (result)
            {
                switch (number)
                {
                    case 1: Kanava = "Ykkönen";
                        Tiedot = "Jonkun sarjan uusinta...";
                        break;

                    case 2: Kanava = "Kakkonen";
                        Tiedot = "Ja taas uusinta...";
                        break;

                    case 3: Kanava = "Kolmonen";
                        Tiedot = "Joku elokuva...";
                        break;

                    default: Console.WriteLine("\nError!");
                        Power = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!\n");
                Power = false;
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
            Console.WriteLine("\nTelevision tiedot:");
            Console.WriteLine("Virta: " + tila);
            Console.WriteLine("Kanava: " + Kanava);
            Console.WriteLine("Ohjelman tiedot: " + Tiedot);
        }
                
    }
}
