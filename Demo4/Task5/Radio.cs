﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Radio
    {
        public bool Power { get; set; }
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error! Väärä arvo!");
                    volume = 0;
                }
                else if (value > 9)
                {
                    Console.WriteLine("Error! Väärä arvo!");
                    volume = 9;
                }
                else volume = value;
            }
        }

        public float Frequency
        {
            get { return frequency; }
            set
            {
                if (value < 2000.0f)
                {
                    Console.WriteLine("Error! Väärä arvo!");
                    frequency = 2000.0f;
                }
                else if (value > 26000.0f)
                {
                    Console.WriteLine("Error! Väärä arvo!");
                    frequency = 26000.0f;
                }
                else frequency = value;
            }
        }

        public Radio(bool power, int volume, float frequency)
        {
            Power = power;
            Volume = volume;
            Frequency = frequency;
        }

        public void onOff()
        {
            Console.WriteLine("Laitetaanko radio päälle (K/E)?");
            string line = Console.ReadLine();
            int number = 0;
            bool result = int.TryParse(line, out number);
            if (result)
            {
                Console.WriteLine("Error! Et vastannut K tai E!");
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
                        break;
                    case 'e':
                    case 'E': Power = false;
                        break;
                    default: Console.WriteLine("Error! Et vastannut K tai E!");
                        Power = false;
                        break;
                }
            }
        }

        public void adjustVolume()
        {
            Console.WriteLine("\nSäädä äänenvoimakkuus (0-9) > ");
            string line = Console.ReadLine();

            int number = 0;
            bool result = int.TryParse(line, out number);
            if (result)
            {
                Volume = number;
            }
            else Console.WriteLine("Error!");
        }

        public void adjustFrequency()
        {
            Console.WriteLine("\nSäädä taajuus (2000.0 - 26000.0) > ");
            string line = Console.ReadLine();

            float number = 0.0f;
            bool result = float.TryParse(line, out number);
            if (result)
            {
                Frequency = number;
            }
            else Console.WriteLine("Error!");
        }

        public override string ToString()
        {
            return "\nPower: " + tila + "\nVolume: " + Volume + "\nFrequncy: " + Frequency;
        }

        public void printData()
        {
            if (Power == true)
            {
                tila = "ON";
            }
            else tila = "OFF";

            Console.WriteLine("Radion tila:");
            Console.WriteLine(ToString());
        }

        private int volume;
        private float frequency;
        private string tila = "";
    }
}
