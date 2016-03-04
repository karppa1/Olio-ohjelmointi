using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyora pyora1 = new Pyora("Jopo", "Street", 2016, "Sininen", false, "");
            Pyora pyora2 = new Pyora("Tunturi", "StreetPower", 2010, "Musta", true, "Shimano");
            Vene vene1 = new Vene("Suvi", "S900", 1990, "Valkoinen", "Soutuvene", 3);
            Vene vene2 = new Vene("Yamaha", "Model 1000", 2010, "Keltainen", "Moottorivene", 5);

            Console.WriteLine("Ensimmäisen pyörän tiedot:");
            pyora1.printData();

            Console.WriteLine("Toisen pyörän tiedot:");
            pyora2.printData();

            Console.WriteLine("Ensimmäisen veneen tiedot:");
            vene1.printData();

            Console.WriteLine("Toisen veneen tiedot:");
            vene2.printData();

            Console.ReadLine();
        }
    }
}
