using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Pyora : Kulkuneuvo
    {
        public bool Vaihteet { get; set; }
        public string Vaihdemerkki { get; set; }

        public Pyora(string nimi, string malli, int vuosimalli, string vari, bool vaihteet, string vaihdemerkki)
            : base(nimi, malli, vuosimalli, vari)
        {
            Vaihteet = vaihteet;
            Vaihdemerkki = vaihdemerkki;
        }

        public override string ToString()
        {
            return base.ToString() + "\nVaihteet: " + Vaihteet + "\nVaihdemerkki: " + Vaihdemerkki;
        }
    }
}
