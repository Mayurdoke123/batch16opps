using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
   
        class person1
    {
        public String Name { get; set; }
        public int id { get; set; }

        public void display()
        {
            Console.WriteLine($"name is{Name}");
            Console.WriteLine($"id is:{id}");

        }
        class teacher : person1
        {
            public string colgname { get; set; }
            public void info()
            {
                Console.WriteLine($"college name is{colgname}");
            }
        }
        class principle : teacher
        {
            public string name1 { get; set; }
            public void info()
            {
                Console.WriteLine($"name is{name1}");
            }

        }
    class Multilevelinheritance
        {
            static void Main()

            {
                principle p = new principle();
                p.Name = "Mayur Doke";
                p.id = 1;
                p.colgname = "abc";
                p.name1 = "xyz";
                p.display();
                p.info();
                p.info();




            }

        }

    }
}