using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Media media1 = new Media("Kirja", "Olio-ohjelmointi");
            Media media2 = new Media("Lehti", "Mikrobitti");
            Levy levy1 = new Levy("CD", "Lost Society", 66);
            Levy levy2 = new Levy("DVD", "Hellraiser", 93);
            Laite laite1 = new Laite("Puhelin", "Luuri", "Samsung");
            Laite laite2 = new Laite("Kannettava", "Läppäri", "Asus");

            media1.printData();
            media2.printData();
            levy1.printData();
            levy2.printData();
            laite1.printData();
            laite2.printData();

            media2.Nimi = "Tekniikan Maailma";
            laite2.Tyyppi = "Tabletti";
            laite2.Nimi = "Tab2";
            laite2.Valmistaja = "Samsung";

            media2.printData();
            laite2.printData();

            Console.ReadLine();
        }
    }
}
