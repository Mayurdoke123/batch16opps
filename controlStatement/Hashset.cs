using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace batch16opps
{
    internal class Hashset
    {
        static void Main()
        {
            HashSet<int> list = new HashSet<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            List<int> list2 = new List<int> { 6,7,8};
            Console.WriteLine("..........Display hash element..........");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //insert element
            

            //Remove element
            list.Remove(2);
            Console.WriteLine("....................Remove the element....................");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //clear element
            list.Clear();
            Console.WriteLine("..................Clear element in Hashset..................");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //unionwith

          //  list2.UnionWith(list);
            Console.WriteLine("...........list unionwith............");


            HashSet<int> vs = new HashSet<int> { 1,2,3,4,5,};
            HashSet<int> vs1 = new HashSet<int> { 2,3,5, };

            vs.UnionWith(vs1);
           
            Console.WriteLine(" " + string.Join(",", vs));

            //intraction
            Console.WriteLine("..........interaction of two set..........");
            vs.IntersectWith(new HashSet<int> { 4,5});
            Console.WriteLine(" " + string.Join(",", vs));
        }
    }
}
