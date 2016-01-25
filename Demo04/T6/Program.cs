using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Nettipoksi pokis = new Nettipoksi("Paskana",5);
            Console.WriteLine(pokis.ToString());

            Kaiutin kaiutin = new Kaiutin("Hyvä", 3, "Musta");
            Console.WriteLine(kaiutin.ToString());
        }
    }
}
