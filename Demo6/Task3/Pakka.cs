using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Pakka
    {
        public Kortti[] kortit;
        public const int maxKortit = 52;
        public Random rand;
        public int currentCard = 0;

        public Pakka()
        {
            string[] arvo = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] maa = new string[4] { "Spades", "Clubs", "Diamonds", "Hearts" };
            rand = new Random();

            kortit = new Kortti[maxKortit];
            for (int i = 0; i < kortit.Length; i++)
            {
                // esim. arvo --> 0 mod 13=0, 1 mod 13=1, 14 mod 13=1, 15 mod 13=2, 26 mod 13=0... 
                // esim. maa --> 0 / 13=0, 1 / 13=0,07... eli round 0, 13 / 13=1, 14 / 13=1,07... eli round 1, 26 / 13=2 jne...

                kortit[i] = new Kortti(arvo[i % 13], maa[i / 13]);
            }
        }

        public void Sekoita()
        {
            for(int i = 0; i < kortit.Length; i++)
            {
                int j = rand.Next(maxKortit);
                Kortti sekoitus = kortit[i];
                kortit[i] = kortit[j];
                kortit[j] = sekoitus;
            }
        }

        public Kortti Jaa()
        {
            if (currentCard < kortit.Length)
                return kortit[currentCard++];
            else
                return null;
        }        
    }
}
