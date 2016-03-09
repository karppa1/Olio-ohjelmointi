using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class KokonaisLasku
    {
        public string Asiakas { get; set; }
        public double Summa => loppuSumma();
        public int yhteensaTuotteita => tuotteetMaara();
        public List<TuoteLasku> tuotteet { get; set; } = new List<TuoteLasku>();

        private double loppuSumma()
        {
            double summa = 0;
            foreach(TuoteLasku data in tuotteet)
            {
                summa += data.tuoteSumma;
            }
            return summa;
        }

        private int tuotteetMaara()
        {
            return tuotteet.Count;
        }

        public void printData()
        {
            Console.WriteLine("Asiakkaan - {0} - ostokset:", Asiakas);
            Console.WriteLine("=================================");
            foreach(TuoteLasku data in tuotteet)
            {
                Console.WriteLine(data.ToString());
            }
            Console.WriteLine("=================================");
            Console.WriteLine("Yhteensä " + Summa + " e");
        }
    }
}
