using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Esineet
    {
        public string Kunto { get; set; }
        public int Piuha { get; set; }


        public Esineet()
        {
        }

        public Esineet(string kunto, int piuha)
        {
            Kunto = kunto;
            Piuha = piuha;
        }

        public override string ToString()
        {
            return "Kunto: "+ Kunto +" piuhan pituus: " + Piuha;
        }
    }
}
