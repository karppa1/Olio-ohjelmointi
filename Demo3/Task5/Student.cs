using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }        
        public string Address { get; set; }
        public string Phone { get; set; }

        public Student(int studentId, string name,string address,string phone)
        {
            StudentID = studentId;
            Name = name;            
            Address = address;
            Phone = phone;
        }

        public override string ToString()
        {
            return ("StudentID: " + StudentID + "\nName:" + Name + "\nAddress: " + Address + "\nPhone: " + Phone);
        }
    }
}
