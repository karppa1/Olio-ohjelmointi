﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Human : Mammal
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public override void Move(int amount)
        {
            Console.WriteLine("Human is moving " + amount + " steps.");
        }

        public void GetOlder()
        {
            Age += 10;
            Console.WriteLine("Human is " + Age + " years old.");
        }
    }
}
