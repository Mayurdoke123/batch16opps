using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    internal class NongenericHashtable
    {
        static void Main()
        {
            Hashtable myhashtable = new Hashtable();
            myhashtable.Add("Mayur", 1);
            myhashtable.Add("abhi", 2);
            myhashtable.Add("rohit",3);
            myhashtable.Add("kiran",4);
            myhashtable.Add("rahul",5);
            Console.WriteLine("............Add the key & value in the Hashtable..............");

            foreach (DictionaryEntry en  in myhashtable)
            {
                Console.WriteLine($"{en.Key},{en.Value}");
            }

            myhashtable["rohit"] = 20;
            Console.WriteLine("............modified Hashtable...........");
            foreach (DictionaryEntry en in myhashtable)
            {
                Console.WriteLine($"{en.Key},{en.Value}");
            }
            myhashtable.Remove("rahul");
            Console.WriteLine("Remove element in the hashtable");
            foreach (DictionaryEntry en in myhashtable)
            {
                Console.WriteLine($"{en.Key},{en.Value}");
            }
        }
    }
}
