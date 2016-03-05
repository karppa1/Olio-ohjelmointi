using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Sarja : Ohjelma
    {
        public int Jaksot { get; set; }

        public Sarja(string tyyppi, string nimi, int jaksot)
            : base(tyyppi, nimi)
        {
            Jaksot = jaksot;
        }

        public override string ToString()
        {
            return base.ToString() + "\nJaksot: " + Jaksot;
        }
    }
}
