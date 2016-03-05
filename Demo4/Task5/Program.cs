using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, 0, 2000.0f);
            radio.printData();
            Console.WriteLine();
            radio.onOff();

                while (radio.Power == true)
                {
                    radio.adjustVolume();
                    radio.adjustFrequency();
                    radio.printData();

                Console.WriteLine("\nJatketaanko radion säätämistä (K/E)?");
                string line = Console.ReadLine();

                int number = 0;
                bool result = int.TryParse(line, out number);
                if (result)
                {
                    Console.WriteLine("Error! Et vastannut K tai E!");
                    radio.Power = false;
                    return;
                }
                char vastaus;
                bool result2 = char.TryParse(line, out vastaus);
                if (result2)
                {
                    switch (vastaus)
                    {
                        case 'k':
                        case 'K': radio.Power = true;
                            break;

                        case 'e':
                        case 'E': radio.Power = false;
                            break;

                        default: Console.WriteLine("Error! Et vastannut K tai E!");
                            radio.Power = false;
                            break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
