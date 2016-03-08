using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    [Serializable]
    class Ohjelma
    {
        public string Nimi { get; set; }
        public string Kanava { get; set; }
        public string Alku { get; set; }
        public string Loppu { get; set; }
        public string Tiedot { get; set; }

        public Ohjelma(string nimi,string kanava,string alku,string loppu,string tiedot)
        {
            Nimi = nimi;
            Kanava = kanava;
            Alku = alku;
            Loppu = loppu;
            Tiedot = tiedot;
        }

    }
}
