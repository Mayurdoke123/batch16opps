using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlStatement
{
    internal class gotostatement
    {
        static void Main()
        {
            Console.WriteLine("enter valid age");
        startloop:
            int age = Convert.ToInt32(Console.ReadLine());
            if( age >0 && age <=  120)
                    {
                Console.WriteLine($"Age is  {age}");
                goto startloop;
            }
            Console.WriteLine("age is not valid");
        }
    }
}
