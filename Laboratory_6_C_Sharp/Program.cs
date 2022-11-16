using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_6_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat ginger = new Cat(5, "Red", 2);
            Dog graff = new Dog(2, "Black", 1);

            Console.WriteLine(ginger.ToString());
            Console.WriteLine(ginger.MakeSound());
            Console.WriteLine(graff.ToString());
            Console.WriteLine(graff.MakeSound());

            Console.ReadKey();

        }
    }
}
