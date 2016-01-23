/*
 * Copyright (C) Timo Heinonen
 *
 * This file is part of my homework :)
 *
 * Created: Timo Heinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            int i = 1;      //this is for the do while loop
            
            do {
                Console.WriteLine("Welcome to radio! What do you want to do?");
                Console.WriteLine("1. Turn radio on/off");
                Console.WriteLine("2. Adjust volume");
                Console.WriteLine("3. Adjust frequency");
                Console.WriteLine("4. Radio status");
                Console.WriteLine("5. Abandon radio");
                int valikko = int.Parse(Console.ReadLine());
                switch (valikko)
                {
                    case 1:
                        {
                            Console.Write("Set Radio on off (1 or 0): ");
                            int valinta = int.Parse(Console.ReadLine());

                            if (valinta == 1)                            
                                radio.IsOn = true;                            
                            else
                                radio.IsOn = false;

                            Console.WriteLine("Radio is now " + radio.IsOn);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Adjust radio volume (0-9): ");
                            radio.Volume = int.Parse(Console.ReadLine());
                            Console.WriteLine("Volume is now: " + radio.Volume);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Adjust radio frequency (2000 - 26000): ");
                            radio.Frequency = int.Parse(Console.ReadLine());
                            Console.WriteLine("Frequency is now: " + radio.Frequency);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(radio.ToString());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Sad radio is sad :(");
                            i = 0;
                            break;
                        }
                }

            } while (i == 1);
        }
    }
}
