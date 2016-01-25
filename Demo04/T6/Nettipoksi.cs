using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Nettipoksi : Esineet
    {
        public Nettipoksi(string kunto, int piuha)
            : base(kunto,piuha)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
   
}
