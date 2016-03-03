using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Biisit
    {
        public string Biisi { get; set; }
        public double Kesto { get; set; }

        public Biisit(string biisi,double kesto)
        {
            Biisi = biisi;
            Kesto = kesto;
        }

        public override string ToString()
        {
            return "--- " + Biisi + " - " + Kesto;
        }

    }
}
