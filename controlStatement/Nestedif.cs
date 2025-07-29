using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlStatement
{
    internal class Nestedif
    {
        static void Main()
        {

            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("a number is positive");

            }
            else if (a < 1)
            {
                Console.WriteLine("a is negative");
            }
            else
            {
                Console.WriteLine("a is zero");
            }

            //0 to 100 grade
            Console.WriteLine("enter your numnerical grade 0 to 100");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 90)
            {
                Console.WriteLine("your grade is A");
            }
            else if (num >= 80)
            {
                Console.WriteLine("your grade is B");
            }
            else if (num >= 75)
            {
                Console.WriteLine("your grade is C");
            }
            else if (num >= 60)
            {
                Console.WriteLine("your grade is D");
            }
            else
            {
                Console.WriteLine("your grade is F");
            }
        }

    }
}
