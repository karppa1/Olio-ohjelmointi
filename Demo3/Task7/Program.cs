using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd cd1 = new Cd();

            cd1.Artisti = "Lost Society";
            cd1.Nimi = "Fast Loud Death";
            cd1.Hinta = 19.95;

            cd1.lisaaBiisi(new Biisit("N.W.L", 2.22));
            cd1.lisaaBiisi(new Biisit ("Trash All Over You", 3.41));
            cd1.lisaaBiisi(new Biisit ("E.A.G.", 2.20));
            cd1.lisaaBiisi(new Biisit ("Kill (Those Who Oppose Me)", 2.17));
            cd1.lisaaBiisi(new Biisit ("Bitch, Out' My Way", 4.02));
            cd1.lisaaBiisi(new Biisit ("Fast Loud Death", 3.26));
            cd1.lisaaBiisi(new Biisit ("Lead Through the Head", 3.14 ));
            cd1.lisaaBiisi(new Biisit ("Diary of a Thrashman", 2.42 ));
            cd1.lisaaBiisi(new Biisit ("Toxic Avenger", 1.08 ));
            cd1.lisaaBiisi(new Biisit ("This Is Me", 2.43 ));
            cd1.lisaaBiisi(new Biisit ("Braindead Metalhead", 3.27 ));
            cd1.lisaaBiisi(new Biisit ("Piss Out My Ass", 2.00 ));
            cd1.lisaaBiisi(new Biisit ("Fatal Anoxia", 2.27 ));
            cd1.lisaaBiisi(new Biisit ("Escape from Delirium", 4.08 ));
            cd1.lisaaBiisi(new Biisit ("I Stole Your Love (KISS-cover)", 3.23 ));

            Console.WriteLine(cd1.ToString());

            Console.ReadLine();
        }
    }
}
