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
            Human mammal = new Human();
            Adult adult = new Adult();
            Baby baby = new Baby();
            mammal.Move(15);
            adult.Move(1);
            baby.Move(1);
            
                for (int i = 0; i < 5; i++)
                {
                    mammal.GetOlder();
                }            

            Console.ReadLine();
        }
    }
}
