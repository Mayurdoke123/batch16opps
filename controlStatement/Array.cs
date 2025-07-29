using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class Array
    {
        static void Main()
        {
            //1D array
            Console.WriteLine("1-D Array declaring way one");

            String[] name = new String[4];
            {
                name[0] = "Mayur";
                name[1] = "rohit";
                name[2] = "kiran";
                name[3] = "rahul";
            }
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);


            }
            //opction two
            Console.WriteLine("1-D Array declaring way two");
            String[] na = { "mayur", "kiran", "rohit", "rahul" };
            for (int i = 0; i < na.Length; i++)
            {
                Console.WriteLine(na[i]);
            }
            //multi array
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int x, y;
            for (x = 0; x < 2; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    Console.Write(arr [ x  ,  y] );
                }
                Console.WriteLine();
            }

        
       
        }
    }

}