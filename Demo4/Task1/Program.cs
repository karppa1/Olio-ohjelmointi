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
            Elevator elevator = new Elevator();
            elevator.PrintData();

            elevator.AskNumber();

            Console.ReadLine();
        }
    }
}
