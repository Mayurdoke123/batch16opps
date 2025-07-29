using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    class vehical
    {
        public virtual void startengine()
        {
            Console.WriteLine("vehical startengine");
        }

    }
    class car:vehical
    {
        public override void startengine()
        {
            Console.WriteLine("car startengine");
        }
    }
    class truck:vehical
    {
        public override void startengine()
        {
            Console.WriteLine("truck startengine");
        }
    }
    internal class Dynamicpoly
    {

        static void Main()
        {
            vehical v = new vehical();
            vehical v1 = new car();
            vehical v2 = new truck();
            v.startengine();
            v1.startengine();
            v2.startengine();


        }
    }
}