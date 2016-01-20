using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Elevator elevator = new Elevator();
            do
            {
                Console.WriteLine("Elevator is in room: " + elevator.Height);
                Console.Write("Give floor number (1-5): ");
                elevator.Height = int.Parse(Console.ReadLine());
            } while (true);

        }
    }
}
