using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Juoma
    {
        public string Tyyppi { get; set; }
        public string Pakkaus { get; set; }

        public Juoma(string tyyppi,string pakkaus)
        {
            Tyyppi = tyyppi;
            Pakkaus = pakkaus;
        }

        public override string ToString()
        {
            return "Tyyppi: " + Tyyppi + " - Pakkaus: " + Pakkaus;
        }
    }
}
