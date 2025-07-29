using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class averageofArray
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                avg = sum / array.Length;
            }
            Console.WriteLine("Average of Array value is= "+avg);

        }
    }

}