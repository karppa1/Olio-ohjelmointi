using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Task4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void RemoveData()
        {
            Name = "";
            Speed = 0;
            Tyres = 0;
            Console.WriteLine("Data removed!");
        }

        public void PrintData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return ("Car: " + Name + " Speed: " + Speed + " Tyres: " + Tyres);
        }
    }
}
