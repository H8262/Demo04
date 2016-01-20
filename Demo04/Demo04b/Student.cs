using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04b
{
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student(string firstName, string lastName, string studentID) 
            : base(firstName,lastName)
        {
            StudentID = studentID;

        }
        public void StudentMethod()
        {
            Console.WriteLine("Student does something...");
        }
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }

    }
}
