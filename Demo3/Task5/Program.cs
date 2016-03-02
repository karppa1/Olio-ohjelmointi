using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxStudents = 5;
            Student[] students = new Student[MaxStudents];

            Student student1 = new Student(1234, "Aku","Ankkalinna 1", "040-12345678");
            students[0] = student1;

            Student student2 = new Student(2353, "Hessu", "Ankkalinna 2", "040-12345443");
            students[1] = student2;

            Student student3 = new Student(5432,"Roope","Ankkalinna 3","040-11112222");
            students[2] = student3;

            Student student4 = new Student(2345,"Hannu","Ankkalinna 4","040-11231244");
            students[3] = student4;

            Student student5 = new Student(3324,"Mikki","Ankkalinna 5","040-12334525");
            students[4] = student5;

            for (int i = 0; i < MaxStudents; i++)
            {
                Console.WriteLine(students[i]);
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
