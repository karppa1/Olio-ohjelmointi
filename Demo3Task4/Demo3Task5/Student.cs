using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Task5
{
    class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }        

/*        public void PrintData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }
        */
        public override string ToString()
        {
            return ("StudentID: " + StudentID + "\nName:" + Name + "\nAddress: " + Address + "\nPhone: " + Phone);
        }


    }
}
