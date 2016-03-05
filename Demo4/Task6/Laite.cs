using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Laite : Media
    {
        public string Valmistaja { get; set; }

        public Laite(string tyyppi, string nimi, string  valmistaja)
            : base(tyyppi, nimi)
        {
            Valmistaja = valmistaja;
        }

        public override string ToString()
        {
            return base.ToString() + "\nValmistaja: " + Valmistaja;
        }
    }
}
