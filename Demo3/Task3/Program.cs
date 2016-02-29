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
            Televisio televisio = new Televisio(false,"-","-");

            televisio.printData();
            televisio.onOff();

            while (televisio.Power == true)
            {
                televisio.valitseKanava();                

                if (televisio.Power == true)
                {
                    televisio.printData();

                    Console.WriteLine("\nJatketaanko television käyttöä (K/E)?");
                    string line = Console.ReadLine();
                    Console.WriteLine();

                    int number = 0;
                    bool result1 = int.TryParse(line, out number);
                    if (result1)
                    {
                        Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!\n");
                        return;
                    }
                    char vastaus;
                    bool result2 = char.TryParse(line, out vastaus);
                    if (result2)
                    {
                        switch (vastaus)
                        {
                            case 'k':
                            case 'K':
                                televisio.Power = true;
                                break;
                            case 'e':
                            case 'E':
                                televisio.Power = false;
                                break;
                            default:
                                Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!\n");
                                televisio.Power = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nError! Et vastannut K tai E! Ohjelma lopetetaan!");
                        televisio.Power = false;
                    }
                }

            }
            if (televisio.Power == false)
            {
                Console.WriteLine("\nTelevisio on pois päältä");
                televisio.Kanava = "-";
                televisio.Tiedot = "-";
                televisio.printData();
            }

            Console.ReadLine();
        }
    }
}
