using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class NongenericArraylist
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(111);
            list.Add("Mayur");
            list.Add("abhi");
            list.Add(222);
            list.Add("sai");
            list.Add("sushant");
            list.Add(333);
            list.Add("rohit");
            list.Add(99.9);
            list.Add(10.00);
            Console.WriteLine("..........Add the element in the Arraylist.........");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            
           list.Remove("rohit");
          Console.WriteLine("...............Remove element...............");
          foreach (var item in list)
           {
            Console.WriteLine(item);
          }
          list.Clear();
            Console.WriteLine("................Clear the All element..............");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
