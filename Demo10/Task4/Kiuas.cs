using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Kiuas
    {
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value < 0) temperature = 0;
                if (value > 120) temperature = 120;
                else temperature = value;
            }
        }
        public int Humidity
        {
            get { return humidity; }
            set
            {
                if (value < 0) humidity = 0;
                if (value > 100) humidity = 100;
                else humidity = value;
            }
        }

        private int temperature;
        private int humidity;
    }
}
