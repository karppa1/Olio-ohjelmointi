using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Pelaaja : Henkilo
    {
        public int Pelinumero { get; set; }
        public string Pelipaikka { get; set; }

        public Pelaaja(string nimi, int ika, int pelinumero, string pelipaikka)
            :base(nimi,ika)
        {
            Pelinumero = pelinumero;
            Pelipaikka = pelipaikka;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPelinumero: " + Pelinumero + " Pelipaikka: " + Pelipaikka;
        }
    }
}
