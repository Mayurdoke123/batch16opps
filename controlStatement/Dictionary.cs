using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class Dictionary
    {
        static void Main()
        {
            Dictionary<String,int > obj = new Dictionary<String,int>();
            obj.Add("Mayur",1);
            obj.Add("abhishik",2);
            obj.Add("Gargi",3);
            obj.Add("sai",4);
            obj.Add("umesh",5);
            obj.Add( "rohit",6);
            obj.Add("sushant",7);
            obj.Add("Vishwas",8);
            obj.Add("jyoti",9);
            obj.Add("Aishu",10);
            Console.WriteLine("....................Display the dictoinary element....................");

            foreach (KeyValuePair<String,int> ele in obj)
            {
                Console.WriteLine($"{ele.Key}:{ele.Value}");
            
            
            }
            obj[ "rohit"] = 66;
            Console.WriteLine("....................element are modify....................");

            foreach (var item in obj)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");

            }
            obj.Remove("rohit");//Removing element
            Console.WriteLine(".....................Remove the element.......................");

            foreach (var item in obj)
            {
               Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
