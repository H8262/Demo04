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
    class Radio
    {
        private int volume;
        private int maxVolume = 9;
        private int minVolume = 0;
        public bool IsOn = false;
        private int frequency;
        private int maxFrequency = 26000;
        private int minFrequency = 2000;


        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume && value >= minVolume) volume = value;
                else
                {
                    if (value <= minVolume)
                    {
                        volume = minVolume;
                        Console.WriteLine("Volume is set to min");
                    }
                    else
                    {
                        volume = maxVolume;
                        Console.WriteLine("Volume is set to max");
                    }
                }
            }
        }

        public int Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if(value <= maxFrequency && value >= minFrequency)
                {
                    frequency = value;
                }
                else
                {
                    if(value > maxFrequency)
                    {
                        frequency = maxFrequency;
                        Console.WriteLine("Frequency set to max");
                    }
                    else
                    {
                        frequency = minFrequency;
                        Console.WriteLine("Frequency set to min");
                    }
                }
            }
        }

        public override string ToString()
        {
            return "Frequency: " + Frequency + " Volume: " + Volume + " Is radio on? " + IsOn;
        }
    }
}
