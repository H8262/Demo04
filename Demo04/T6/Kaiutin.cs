using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Kaiutin : Esineet
    {

        public string Vari { get; set; }

        public Kaiutin(string kunto, int piuha,string vari)
            :base(kunto,piuha)
        {
            Vari = vari;
        }

        public override string ToString()
        {
            return base.ToString() + " väri " + Vari;
        }
    }
}
