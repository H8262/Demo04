using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Doge : Animals
    {
        public Doge(int legs)
        :base (legs)
        {
        }

        public void DogeMethod()
        {
            Console.WriteLine("Bark!");
        }
    }
}
