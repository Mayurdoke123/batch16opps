using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlStatement
{
    internal class loopingStatement
    {
        static void Main()
        {
            int i = 1;
            //forloop
            Console.WriteLine("for loop Statement");
            for ( i = 0; i <= 10; i++)
            {
                Console.WriteLine("student " + i);
            }
            //while loop
            Console.WriteLine("while loop Statement" );
            int j = 1;
            while(j<=10)
            {
                Console.WriteLine("student " +j );
                j++;
            }
            //Do while loop
            int m = 1;
            Console.WriteLine("Do While loop Statement");
            do 
            {
                Console.WriteLine("student "  +  m);
                m++;  
            }
            while(m<=10);
            }
    }
}
