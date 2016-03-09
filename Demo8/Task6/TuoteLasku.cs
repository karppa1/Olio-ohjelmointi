using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class TuoteLasku
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }
        public int Maara { get; set; }

        public double tuoteSumma => (Maara * Hinta);

        public TuoteLasku(string nimi,double hinta,int maara)
        {
            Nimi = nimi;
            Hinta = hinta;
            Maara = maara;
        }

        public override string ToString()
        {
            return Nimi + " - " + Hinta + "e " + "x " + Maara;            
        }
    }
}
