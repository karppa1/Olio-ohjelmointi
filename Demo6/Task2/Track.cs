﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Track
    {
        public string Name { get; set; }
        public string Duration { get; set; }

        public override string ToString()
        {
            return "* " + Name + ", " + Duration;
        }
    }
}
