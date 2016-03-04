using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Vari { get; set; }

        public Kulkuneuvo(string nimi, string malli, int vuosimalli, string vari)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Vari = vari;
        }

        public void printData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + "\nMalli: " + Malli + "\nVuosimalli: " + Vuosimalli + "\nVäri: " + Vari;
        }
    }
}
