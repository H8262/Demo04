using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(4);
            Doge doge = new Doge(4);

            int i = 1;
            int menu = 0;

            do
            {
                Console.WriteLine("Choose animal!");
                Console.WriteLine("1. Cat");
                Console.WriteLine("2. Dog");
                Console.WriteLine("3. Abandon animals!");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("This cat has : " + cat.Legs + " legs");
                            cat.CatMethod();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("This dog has : " + doge.Legs + " legs");
                            doge.DogeMethod();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Animals require your attention!");
                            i = 0;
                            break;
                        }                     
                }
            } while (i == 1);

        }
    }
}
