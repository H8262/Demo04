using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Elevator
    {
        private int height;
        private int maxHeight = 5;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 5 && value >= 1) height = value;
                else
                {
                    Console.WriteLine("Invalid input - elevator will now break");

                }

            }


        }

    }
}
