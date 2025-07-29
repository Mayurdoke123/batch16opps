using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class stringbuffer
    {
        static void Main()
        {
            //string 
            String str = "hello";
            Console.WriteLine(str);
           String firstName = "Mayur";
            String LastName = "Doke";
            String s=firstName + LastName;
            Console.WriteLine(s);
            //stringbuffer
            StringBuilder sb = new StringBuilder();
            sb.Append(" my  ");
            sb.Append(" Name ");
            sb.Append("  is ");
            sb.Append(" Mayur ");
            sb.Append(" Doke");
            Console.WriteLine(sb);

            //replace
            sb.Replace("Doke","patil");
            //sb.Clear();
            Console.WriteLine(sb.ToString());
            sb.Clear();

            //Boxing
            int a = 10;
            object b = new object();
            Console.WriteLine("Boxing value"+a);
            //unboxing
            object c = 10;
            int m= (int)c;
            Console.WriteLine("Unboxing value"+m);
        }
    }














        
    }

