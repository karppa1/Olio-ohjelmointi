using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Kortti
    {
        public string Arvo; 
        public string Maa; 

        public Kortti(string arvo, string maa)
        {
            Arvo = arvo;
            Maa = maa;
        }

        public override string ToString()
        {
            return Arvo + " of " + Maa;
        }
    }
}
