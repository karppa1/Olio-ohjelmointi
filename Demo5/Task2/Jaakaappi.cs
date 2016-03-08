using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Jaakaappi
    {
        public Jaakaappi()
        {
            ruuat = new List<Ruoka>();
            juomat = new List<Juoma>();

            lisaaRuoka(new Ruoka("Jauheliha", "Atria"));
            lisaaRuoka(new Ruoka("Makkara", "HK"));
            lisaaRuoka(new Ruoka("Kana", "Atria"));

            lisaaJuoma(new Juoma("Olut", "Pullo"));
            lisaaJuoma(new Juoma("Maito", "Purkki"));
            lisaaJuoma(new Juoma("Mehu", "Tölkki"));
        }

        public void lisaaRuoka(Ruoka r)
        {
            ruuat.Add(r);
        }

        public void lisaaJuoma(Juoma j)
        {
            juomat.Add(j);
        }

        public override string ToString()
        {
            string s = "Jääkaapin sisältö: \n";
            foreach(Ruoka data in ruuat)
            {
                s += "\n";
                s += data.ToString();
            }
            s += "\n";
            foreach(Juoma data in juomat)
            {
                s += "\n";
                s += data.ToString();
            }

            return s;
        }

        private List<Ruoka> ruuat;
        private List<Juoma> juomat;
    }
}
