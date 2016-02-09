using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxStudents = 5;
            Student[] students;

            students = new Student[MaxStudents];
            Student student1 = new Student();
            
            student1.StudentID = 1234;
            student1.Name = "Aku";
            student1.Address = "Ankkalinna1";
            student1.Phone = "040-12345678";

            students[0] = student1;            
                        
            Student student2 = new Student();
           
            student2.StudentID = 2353;
            student2.Name = "Hessu";
            student2.Address = "Ankkalinna2";
            student2.Phone = "040-12345443";

            students[1] = student2;
            
            Student student3 = new Student();
            
            student3.StudentID = 5432;
            student3.Name = "Roope";
            student3.Address = "Ankkalinna3";
            student3.Phone = "040-11112222";

            students[2] = student3;

            Student student4 = new Student();
            
            student4.StudentID = 2345;
            student4.Name = "Hannu";
            student4.Address = "Ankkalinna4";
            student4.Phone = "040-11231244";

            students[3] = student4;

            Student student5 = new Student();
            
            student5.StudentID = 3324;
            student5.Name = "Mikki";
            student5.Address = "Ankkalinna5";
            student5.Phone = "040-12334525";

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
