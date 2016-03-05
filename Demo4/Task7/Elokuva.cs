using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Elokuva : Ohjelma
    {
        public double Kesto { get; set; }

        public Elokuva(string tyyppi, string nimi, double kesto)
            : base(tyyppi, nimi)
        {
            Kesto = kesto;
        }

        public override string ToString()
        {
            return base.ToString() + "\nKesto: " + Kesto + " min";
        }
    }
}
