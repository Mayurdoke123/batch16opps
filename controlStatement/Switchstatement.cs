using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlStatement
{
    internal class Switchstatement
    {
        static void Main()
        {
            Console.WriteLine("chousing food Item");
            int food=Convert.ToInt32(Console.ReadLine());   
            switch(food)
            { 
                case 1:
                    Console.WriteLine("Burger Rs.:100");
                    break;
                    case 2:
                    Console.WriteLine("pizza rs.:200");
                    break;
                    case 3:
                    Console.WriteLine("salad Rs.:90");
                    break;
                default:
                    case 4:
                    Console.WriteLine("invalid Item");
                    break;
               
            }
        }
    }
}
