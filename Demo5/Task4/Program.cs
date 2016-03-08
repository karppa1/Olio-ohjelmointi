using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue joukkue = new Joukkue();
            joukkue.lisaaPelaaja(new Pelaaja("Aku", 25, 10, "Keskushyökkääjä"));
            joukkue.lisaaPelaaja(new Pelaaja("Hannu", 26, 11, "Vasenlaitahyökkääjä"));
            joukkue.lisaaPelaaja(new Pelaaja("Roope", 27, 12, "Oikealaitahyökkääjä"));
            joukkue.lisaaPelaaja(new Pelaaja("Hessu", 28, 13, "Pakki"));
            joukkue.lisaaPelaaja(new Pelaaja("Mikki", 29, 14, "Maalivahti"));

            Console.WriteLine(joukkue.ToString());

            Console.ReadLine();
        }
    }
}
