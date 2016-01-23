using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "Kalle Kitti";
            employee.Profession = "Siivooja";
            employee.Salary = 1200;

            Boss boss = new Boss();

            boss.Name = "Timo Heinonen";
            boss.Profession = "Lord of the whole universe";
            boss.Salary = 9001;
            boss.Car = "Ford Kia";
            boss.Bonus = 2000;

            Console.WriteLine(employee.ToString());
            Console.WriteLine(boss.ToString());
        }
    }
}
