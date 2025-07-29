using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlStatement
{
    internal class if_else
    {
        static void Main()
        {
            int a = 10;
            //if statement
            if (a == 10)
            {
                Console.WriteLine("a is  true");
            }
            //if else statement
            if (a == 110)
            {
                Console.WriteLine("a is true");
            }
            else
            {
                Console.WriteLine("a is false");
                //}
                //nested if else statement
                if (a == 3)
                {
                    Console.WriteLine("a is positive");
                }
                else if (a > 1)
                {
                    Console.WriteLine("a is negative");
                }
                else if (a < 0)
                {
                    Console.WriteLine("invalid value");
                }
            }
        }
    }
}