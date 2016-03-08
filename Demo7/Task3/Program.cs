using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();
            List<Ohjelma> ohjelmat = new List<Ohjelma>();
            ohjelmat.Add(new Ohjelma("War,Inc.", "FOX", "22.55", "01.00", "War, Inc., USA, 2008. O: Joshua Seftel. P: John Cusack, Hilary Duff ja Marisa Tomei."));
            ohjelmat.Add(new Ohjelma("Criminal Minds", "FOX", "01.00", "02.00", "Kausi 8. Jakso 14. Paluu menneisyyteen."));
            ohjelmat.Add(new Ohjelma("The Walking Dead", "FOX", "02.00", "02.50", "Kausi 6. Jakso 12. Huominen on huomenna."));

            Stream writeMultipleStream = new FileStream("Ohjelmat.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(writeMultipleStream, ohjelmat);

            writeMultipleStream.Close();

            Stream openStream = new FileStream("Ohjelmat.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            List<Ohjelma> readOhjelmat = (List<Ohjelma>)formatter.Deserialize(openStream);

            openStream.Close();

            Console.WriteLine("Ohjelmat: \n");
            foreach (Ohjelma data in readOhjelmat)
            {
                Console.WriteLine("Nimi: {0} \nKanava: {1} \nAlkaa: {2} - Loppuu: {3} \nTiedot: {4} \n", data.Nimi,data.Kanava,data.Alku,data.Loppu,data.Tiedot);
            }

            Console.ReadLine();
        }
    }
}
