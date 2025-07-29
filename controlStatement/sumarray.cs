using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class sumarray
    {
        static void Main()
        {
            int[] array = { 10,20,30,40,50 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                sum=sum+array[i];
               // Console.WriteLine("sum of array= "+sum); 
                    
            }
            Console.WriteLine("sum of array= " + sum);
        }
    }
}
