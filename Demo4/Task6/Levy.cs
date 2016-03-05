using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Levy : Media
    {
        public double Kesto { get; set; }

        public Levy(string tyyppi, string nimi, double kesto)
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
