using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Cd
    {
        public string Artisti { get; set; }
        public string Nimi { get; set; }
        public List<Biisit> biisit;
        public double Hinta { get; set; }

        public Cd()
        {
            biisit = new List<Biisit>();
        }

        public void lisaaBiisi(Biisit biisi)
        {
            biisit.Add(biisi);
        }

        public override string ToString()
        {
            string data = "* CD *";
            data += "\nArtisti: " + Artisti + "\nLevy: " + Nimi + "\nHinta: " + Hinta +" euroa\n";
            data += "\nKappaleet:";
            foreach (Biisit biisi in biisit)
            {
                if (biisit != null) data += "\n" + biisi.ToString();
            }

            return data;
        }
    }
}
