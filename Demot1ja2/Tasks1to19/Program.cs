﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1to19
{
    class Program
    {
        static void Main(string[] args)
        {

            Harjoitus19();

            Console.ReadLine();

        }
        // ------------
        static void Harjoitus1()
        {
            int luku;

            Console.Write("Anna luku 1-3 > ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1) Console.Write("Annoit luvun yksi ");

            else if (luku == 2) Console.Write("Annoit luvun kaksi ");

            else if (luku == 3) Console.Write("Annoit luvun kolme ");

            else Console.Write("Annoit jonkin muun luvun ");

        }
        // ------------
        static void Harjoitus2()
        {
            int points = 0;

            Console.WriteLine("Anna pistemäärä 0-12 > ");
            points = int.Parse(Console.ReadLine());

            switch (points)
            {
                case 0:
                case 1:
                    Console.WriteLine("Koulunumero on 0 ");

                    break;

                case 2:
                case 3:
                    Console.WriteLine("Koulunumero on 1 ");

                    break;

                case 4:
                case 5:
                    Console.WriteLine("Koulunumero on 2 ");

                    break;

                case 6:
                case 7:
                    Console.WriteLine("Koulunumero on 3 ");

                    break;

                case 8:
                case 9:
                    Console.WriteLine("Koulunumero on 4 ");

                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Koulunumero on 5 ");

                    break;

                default:
                    Console.WriteLine("Virheellinen pistemäärä! ");

                    break;
            }

        }
        // ------------
        static void Harjoitus3()
        {
            int num1, num2, num3 = 0;

            Console.Write("Anna eka luku > ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toka luku > ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku > ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lukujen summa on " + (num1 + num2 + num3));

            Console.WriteLine("Lukujen keskiarvo on " + (num1 + num2 + num3) / 3);

        }
        // ------------        
        static void Harjoitus4()
        {

            int age = 0;

            Console.WriteLine("Anna ikäsi > ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Alaikäinen");
            }

            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Aikuinen");
            }

            else
            {
                Console.WriteLine("Seniori");
            }

        }
        // ------------
        static void Harjoitus5()
        {
            int sec = 0;
            int tunnit = 0;
            int min = 0;

            Console.WriteLine("Anna sekunnit > ");
            sec = int.Parse(Console.ReadLine());

            tunnit = sec / 3600;
            min = sec / 60 % 60;
            sec = sec % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunnit + (" tunti ") + min + (" minuutti ") + sec + (" sekuntti"));
        }
        // ------------
        static void Harjoitus6()
        {
            int matka = 0;
            const double kulutus = 7.02;
            const double hinta = 1.595;

            Console.WriteLine("Anna matka > ");
            matka = int.Parse(Console.ReadLine());

            double totalkulu = kulutus * matka / 100;
            double totalhinta = totalkulu * hinta;

            Console.WriteLine("Kulutus on {0:F2} litraa, kustannus {1:F2} euroa", totalkulu, totalhinta);            
        }
        // ------------
        static void Harjoitus7()
        {
            int year = 0;

            Console.WriteLine("Anna vuosiluku > ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi! ");
            }

            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi! ");
            }
        }
        // ------------
        static void Harjoitus8()
        {
            const int numValues = 3;
            int[] table = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                Console.WriteLine("Anna numero > ");
                table[i] = int.Parse(Console.ReadLine());
            }

            int number = 0;

            Array.Sort(table);
            number = table[2];

            Console.WriteLine("Suurin luku on " + number);
        }
        // ------------
        static void Harjoitus9()
        {
            int number = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Anna luku > ");
                number = int.Parse(Console.ReadLine());

                sum += number;

            } while (number != 0);

            Console.WriteLine("Lukujen summa on " + sum);
        }
        // ------------
        static void Harjoitus10()
        {
            const int numValues = 9;
            int[] taulukko = new int[numValues] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < numValues; i++)
            {
                if (taulukko[i] % 2 == 0)
                {
                    Console.WriteLine("HEP! numero: " + taulukko[i]);
                }
            }
        }
        // ------------
        static void Harjoitus11()
        {

            int number = 0;

            Console.WriteLine("Anna luku > ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        // ------------
        static void Harjoitus12()
        {
            const int numValues = 5;
            int[] taulukko = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                Console.WriteLine("Anna luku > ");
                taulukko[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Luvut käänteisessä järjestyksessä ");

            for (int i = numValues - 1; i >= 0; i--)
            {
                Console.WriteLine(taulukko[i]);
            }
        }
        // ------------
        static void Harjoitus13()
        {
            const int numValues = 5;
            int[] taulukko = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                Console.WriteLine("Anna luku > ");
                taulukko[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            Array.Sort(taulukko);   // Lajittelu suuruusjärjestykseen

            for (int i = 1; i < taulukko.Length - 1; i++)
            {
                sum += taulukko[i];
            }

            Console.WriteLine("Kokonaispisteet: " + sum);
        }
        // ------------

        static void Harjoitus14()
        {

            const int numbers = 10;
            int[] table = new int[numbers];
            const int numValues = 6;

            int grade = 0;

            Console.WriteLine("Anna kymmenen opiskelijan arvosana asteikolla 0-5");

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Anna arvosana > ");
                grade = int.Parse(Console.ReadLine());

                if (grade > 5)
                {
                    Console.WriteLine("Error! Virheellinen arvosana! Ohjelma lopetetaan!");
                    return;
                }

                else table[grade]++;

            }

            Console.WriteLine();

            int sum = 0;

            for (int i = 0; i < numValues; i++)
            {
                Console.Write(i + ":");
                sum = table[i];

                for (int j = 0; j <= sum - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

        }
        // ------------

        static void Harjoitus15()
        {
            int num;

            Console.WriteLine("Anna luku > ");
            num = int.Parse(Console.ReadLine());

            int tree = num - 2;

            for (int i = 0; i < tree; i++)
            {
                int empty = tree - i;
                for (int j = 0; j <= empty; j++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star <= i * 2; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < 2; i++)
            {
                int empty = tree;
                for (int j = 0; j <= empty; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");
                Console.WriteLine();
            }            

        }
        // ------------
        static void Harjoitus16()
        {
            bool done = false;
            int randomNumber = new Random().Next(0, 100);

            do
            {

                Console.WriteLine("Arvaa luku > ");
                int number = int.Parse(Console.ReadLine());

                if (number == randomNumber)
                {
                    Console.WriteLine("Oikein!");
                    done = true;
                }

                else if (number > randomNumber)
                {
                    Console.WriteLine("Numero on pienempi!");
                }

                else if (number < randomNumber)
                {
                    Console.WriteLine("Numero on suurempi!");
                }

            } while (!done);
        }
        // ------------

        static void Harjoitus17()
        {
            int[] table1 = { 10, 20, 30, 40, 50 };
            int[] table2 = { 5, 15, 25, 35, 45 };

            // Vaihtoehto 1
            //            int[] table3 = Enumerable.Concat(table1, table2).OrderBy(v => v).ToArray();

            // Vaihtoehto 2
            int[] table3 = Enumerable.Concat(table1, table2).ToArray(); // Toimii näinkin
            Array.Sort(table3); // Lajittelu suuruusjärjestykseen

            Console.WriteLine("Luvut taulukossa 1 : ");
            foreach (int value in table1)
                Console.Write("" + value + ",");
            Console.WriteLine();

            Console.WriteLine("Luvut taulukossa 2 : ");
            foreach (int value in table2)
                Console.Write("" + value + ",");
            Console.WriteLine();

            Console.WriteLine("Luvut yhdistetyssä taulukossa : ");
            foreach (int value in table3)
                Console.Write("" + value + ",");
            Console.WriteLine();

        }
        // ------------

        static void Harjoitus18()
        {
            string jono;

            Console.WriteLine("Anna merkkijono > ");
            jono = Console.ReadLine();

            string jono2 = "";

            for (int i = jono.Length - 1; i >= 0; i--)
            {
                jono2 += jono[i];
            }

            if (jono == jono2)
            {
                Console.WriteLine("Oli palindromi!");
            }

            else
            {
                Console.WriteLine("Ei ollut palindromi!");
            }

        }
        // ------------

        static void Harjoitus19()
        {
            bool done = false;
            string[] sana = new string[5] { "k", "o", "i", "r", "a", };
            string[] arvaus = new string[5] { "-", "-", "-", "-", "-", };

            int numero = 10;
            string testi1 = "";

            // Vertailua varten otetaan merkkijono talteen testi1-muuttujaan
            for (int i = 0; i < sana.Length; i++)
            {
                testi1 += sana[i];
            }

            Console.WriteLine("*Hirsipuupeli*");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Arvauksia jäljellä: " + numero);
                Console.WriteLine("\nArvattava sana: ");    // Tulostetaan arvattava sana merkki kerrallaan, alussa pelkkiä -----
                for(int i = 0; i < 5; i++)
                {
                    Console.Write(arvaus[i]);
                }
                bool ilmo = false;
                Console.WriteLine();
                Console.WriteLine("Anna kirjain > ");
                string line = Console.ReadLine();

                // Testataan oikeat merkit ja painallukset
                int number;
                bool result1 = int.TryParse(line, out number);  // Jos numero niin error!
                if (result1)
                {
                    Console.WriteLine("\nError!");
                    Console.WriteLine("Paina enter!");
                    return;
                }

                char kirjain;
                bool result2 = char.TryParse(line, out kirjain);    // Jos kirjain niin käytetään
                if (result2)
                {
                    string testi2 = "";

                    for (int i = 0; i < 5; i++)
                    {
                        if (sana[i] == kirjain.ToString())
                        {
                            arvaus[i] = kirjain.ToString();

                            for(int j = 0; j < arvaus.Length; j++)
                            {
                                testi2 += arvaus[j];    // Vertailua varten otetaan arvattu merkkijono talteen testi2-muuttujaan
                            }

                            ilmo = true;
                            Console.WriteLine("\nKirjain löytyi!");                            
                        }                        
                    }
                    
                    numero--;
                    if (ilmo == false)
                    {
                        Console.WriteLine("\nKirjainta ei löytynyt!");
                    }

                    if (testi1 == testi2)   // Verrataan onko kysytty sana sama kuin arvattu
                    {
                        done = true;
                        Console.WriteLine("\nOikein!");
                        Console.WriteLine("Arvattava sana oli " + testi2);
                        Console.WriteLine("\nPaina enter!");
                    }
                    else if (numero == 0)
                    {
                        done = true;
                        Console.WriteLine("\nHävisit!");
                        Console.WriteLine("Paina enter!");
                    }
                }
                else
                {
                    Console.WriteLine("Error!");    // Jos ei ole kirjain eikä numero niin error!
                    Console.WriteLine("Paina enter!");
                    return;
                }

            } while (!done);

        }
        // ------------
    }
}
