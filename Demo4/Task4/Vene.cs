using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Vene : Kulkuneuvo
    {
        public string Tyyppi { get; set; }
        public int Istuimet { get; set; }

        public Vene(string nimi, string malli, int vuosimalli, string vari, string tyyppi, int istuimet)
            : base(nimi, malli, vuosimalli, vari)
        {
            Tyyppi = tyyppi;
            Istuimet = istuimet;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTyyppi: " + Tyyppi + "\nIstuimet: " + Istuimet;
        }
    }
}
