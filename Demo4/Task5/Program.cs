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
            Radio radio = new Radio(false, 0, 0.0f);
            radio.printData();

                Console.WriteLine("Laitetaanko radio päälle (K/E)?");   // Kesken...
                string line = Console.ReadLine();

                int number = 0;
                bool result = int.TryParse(line, out number);
                if (result)
                {
                    Console.WriteLine("Error! Et vastannut K tai E!");
                    radio.Power = false;
                }
                else radio.Power = true;

                while (radio.Power == true)
                {
                    radio.adjustVolume();
                    radio.adjustFrequency();
                    radio.printData();

                Console.WriteLine("Jatketaanko radion säätämistä (K/E)?");  // Kesken...
                string line2 = Console.ReadLine();

                int number2 = 0;
                bool result2 = int.TryParse(line, out number2);
                if (result2)
                {
                    Console.WriteLine("Error! Et vastannut K tai E!");
                    radio.Power = false;
                }
                else radio.Power = true;
            }
        }
    }
}
