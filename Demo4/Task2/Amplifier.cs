using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Amplifier
    {
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    volume = 0;
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : " + volume);
                }
                else if (value > 100)
                {
                    volume = 100;
                    Console.WriteLine("Too much volume -  Amplifier volume is set to maximum : " + volume);
                }
                else volume = value;
            }
        }

        public void askNumber()
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Give a new volume value (0-100) >");
                string line = Console.ReadLine();

                int number = 0;
                bool result = int.TryParse(line, out number);
                if (result)
                {
                    Volume = number;
                }
                else
                {
                    Console.WriteLine("Error! You didn't gave a number!");
                    return;
                }

                printData();
            }
        }

        public void printData()
        {
            Console.WriteLine("Amplifier volume is set to : " + volume);
        }

        private int volume = 0;
    }
}
