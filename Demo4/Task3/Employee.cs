using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0) salary = value;
                else salary = 0.0f;
            }
        }

        public Employee(string name, string profession, float salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }

        public void printData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nProfession: " + Profession + "\nSalary: " + Salary;
        }

        private float salary;
    }
}
