using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Amp
    {
        private int volume;

        private int maxVolume = 100;
        private int minVolume = 0;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if(value <= maxVolume && value > minVolume)
                {
                    volume = value;
                }
                else
                {
                    if (value <= minVolume)
                    {
                        Console.WriteLine("Volume set to minimum - grandma is pleased");
                        volume = minVolume;
                    }
                    else
                    {
                        Console.WriteLine("Too much volume - volume set to maximum - ears will now break");
                        volume = maxVolume;
                    }
                }
            }
        }

    }
}
