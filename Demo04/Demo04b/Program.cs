using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04b
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Age = 35;
            person.Address = "Piippukatu 2";
            person.PhoneNumber = "02012345678";

            Teacher teacher = new Teacher("Jussi","Konsoli","D456");
            teacher.Address = "Piippukatu 1";
            teacher.PhoneNumber = "01294121914";

            Student student = new Student("Timo", "Heinonen", "H8262");
            student.Address = "Polttolinja 10 D";
            student.PhoneNumber = "123456789";

            Console.WriteLine(student.ToString());
            Console.WriteLine(teacher.ToString());
            Console.WriteLine(person.ToString());

            
        }
    }
}
