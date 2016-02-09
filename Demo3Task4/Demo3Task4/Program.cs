using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();

            car.Name = "Toyota";
            car.Speed = 200;
            car.Tyres = 4;

            car.PrintData();

            car.RemoveData();
            car.PrintData();

            car.Name = "Nissan";
            car.Speed = 185;
            car.Tyres = 4;

            car.PrintData();

            Console.ReadLine();

        }
    }
}
