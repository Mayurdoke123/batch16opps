using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class GenericList
    {
        static void Main()
        {
            List<int> mylist = new List<int>();
            mylist.Add(111);
            mylist.Add(222);
            mylist.Add(333);
            mylist.Add(444);
            mylist.Add(555);
            Console.WriteLine("Add the element in the list");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            mylist.Remove(444);
            Console.WriteLine("Remove the element in the list ");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            mylist.Insert(4, 888);
            Console.WriteLine("Insert the element in the list");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            mylist.Clear();
            Console.WriteLine("Clear the All List");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
