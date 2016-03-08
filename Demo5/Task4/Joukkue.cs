using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Joukkue
    {
        public Joukkue()
        {
            pelaajat = new List<Pelaaja>();
        }

        public void lisaaPelaaja(Pelaaja p)
        {
            pelaajat.Add(p);
        }

        public override string ToString()
        {
            string s = "Joukkue: \n";
            foreach(Pelaaja data in pelaajat)
            {
                s += "\n";
                s += data.ToString();
            }
            return s;
        }

        private List<Pelaaja> pelaajat;
    }
}
