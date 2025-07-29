using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlStatement
{
    internal class jumpingstatement
    {
        static void Main()
        {
            String[] mobile = {"Vivo","Apple","Samsung","Oneplus",
                "Realme","Motorola","Nokia","Lava","Lenovo","Poco","Tecno"};
            foreach (String s in mobile)
            {
                Console.WriteLine($"mobile brand list:  {s}");
            }
            //Break statement
           
            int n = 0;
            int Sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter number");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 0)
                {
                    break;


                }

                else
                     Sum= n + n;
               
            }
            Console.WriteLine("Sum of number = " +  Sum); 
        }


    }
}
