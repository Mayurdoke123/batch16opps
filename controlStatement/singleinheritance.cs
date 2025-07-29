using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    class person
    {
        public String Name;
        public int age;
        public void Display()
        {
            Console.WriteLine($"person name is:{Name}");
            Console.WriteLine($"person age is{age}");
        }


    }
class student:person
{
    public student()
    {
        Name = "mayur doke";
            age = 21;
    }
        public void info()
        {
            Display();
        }

}

    internal class singleinheritance
    {
        static void Main()
        {
            student st = new student();
            st.info();
        }
    }
}
