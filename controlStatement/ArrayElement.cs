using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class ArrayElement
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            for (int i = 0; i < array.Length; i+=2)
            {
                //if (array[i] == 2)
                //{
                //////     Console.WriteLine(array[i]);
                //  }
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("print the number of element");    

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);

            }
            int[] arr2 = { 1,2, 3, 4,4, 5, 6,7, 8, 9, 10};
            int smallest = arr2[0];
            for (int z = 0;z < arr2.Length; z++)
            {
                if (arr2[0]<smallest )
                {
                    smallest = arr2[z];

                }
            }
            Console.WriteLine("small number in array = "+smallest);



            int[] arr3 = { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            int largest = arr3[0];
            for (int z = 1; z < arr3.Length; z++)
            {
                if (arr2[z] > largest)
                {
                   largest = arr3[z];

                }
            }
            Console.WriteLine("small number in array = " + largest);
        }
    }
}