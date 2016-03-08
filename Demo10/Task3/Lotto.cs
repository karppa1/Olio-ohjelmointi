using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Lotto
    {
        private Random rand = new Random();

        public List<int> arvotutNumerot(string peli)
        {
            int maxArvo = 0;    // Suurin sallittu arvottava luku
            int maxNumerot = 0; // Arvottavien numeroiden määrä

            if (peli.Equals("Lotto"))
            {
                maxArvo = 39;
                maxNumerot = 7;
            }
            else if(peli.Equals("Viking Lotto"))
            {
                maxArvo = 48;
                maxNumerot = 6;
            }
            else if (peli.Equals("Eurojackpot"))
            {
                maxArvo = 50;
                maxNumerot = 5;
            }

            List<int> numerot = new List<int>();
            do
            {
                int numero = rand.Next(1, maxArvo + 1);

                // Tarkistus löytyykö arvottu numero jo listalta, jos ei lisätään listaan...
                if (!numerot.Contains(numero)) numerot.Add(numero);

            } while (numerot.Count < maxNumerot);

            numerot.Sort();

            if (peli.Equals("Eurojackpot"))
            {
                List<int> tahtiNumerot = new List<int>();
                do
                {
                    int numero = rand.Next(1, 11);

                    // Tarkistus löytyykö arvottu numero jo listalta, jos ei lisätään listaan...
                    if (!tahtiNumerot.Contains(numero)) tahtiNumerot.Add(numero);

                } while (tahtiNumerot.Count < 2);

                tahtiNumerot.Sort();
                numerot.AddRange(tahtiNumerot);
            }

            return numerot;
        }
    }
}
