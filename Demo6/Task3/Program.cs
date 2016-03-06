using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pakka korttipakka = new Pakka();
            korttipakka.Sekoita();

            for(int i = 0; i < 52; i++)
            {
                Console.Write("{0,-19}", korttipakka.Jaa());

                // Kirjoitetaan neljän riveihin...

                if((i +1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
