using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<string> teksti = new List<string>();
            
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Kirjoita merkkijono > ");
                    string line = Console.ReadLine();
                    
                    teksti.Add(line);
                }

            string rivit = "";
            foreach(string data in teksti)
            {
                rivit += "\n" + data;
            }

            // Tallennetaan tiedostoon...
            System.IO.StreamWriter outputFile = null;

            try
            {
                outputFile = new System.IO.StreamWriter("tekstit.txt");
                outputFile.WriteLine(rivit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {                
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }

            // Luetaan tiedoston sisältö ja tulostetaan se näkyviin
            try
            {
                string sisalto = System.IO.File.ReadAllText("tekstit.txt");
                System.Console.WriteLine("Tiedoston sisältö:\n" + sisalto);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

            Console.ReadLine();
        }
    }
}
