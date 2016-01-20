using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();

            do
            {
                Console.Write("Give a new volume value (0-100): ");
                amp.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Volume is set to: " + amp.Volume);
            } while (true);

        }
    }
}
