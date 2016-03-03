using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi Kernel", "Teacher", 2200.0f);
            Boss jussi = new Boss("Jussi Jurkka", "Head of Institute", 6600.0f, "Audi", 4500.0f);

            kirsi.printData();
            jussi.printData();

            kirsi.Profession = "Principal Teacher";
            kirsi.Salary += 3000.0f;
            jussi.Bonus += 1000.0f;

            kirsi.printData();
            jussi.printData();

            Console.ReadLine();
        }
    }
}
