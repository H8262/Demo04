using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Employee
    {
        public string Name { set; get; }
        public string Profession { set; get; }
        public int Salary { set; get; }

        public override string ToString()
        {
            return "Name: " + Name +" Profession: " + Profession + " Salary: " + Salary;
        }

    }
}
