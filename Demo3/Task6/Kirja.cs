using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Kirja
    {
        public string Nimi { get; set; }
        public string Kirjailija { get; set; }
        public double Hinta { get; set; }
        public int Painos { get; set; }

        public Kirja(string nimi,string kirjailija,double hinta,int painos)
        {
            Nimi = nimi;
            Kirjailija = kirjailija;
            Hinta = hinta;
            Painos = painos;
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + "\nKirjailija: " + Kirjailija + "\nHinta: " + Hinta + " euroa" + "\nPainos: " + Painos + ".painos";
        }
    }
}
