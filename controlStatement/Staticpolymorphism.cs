using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    class calculater
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public double add(double x, double y)
        {
            return x - y;
        }
        public float add(float x, float y)
        {
            return x + y;
        }
        }
    internal class Staticpolymorphism
    {
        static void Main()
        {
            calculater obj = new calculater();
            int sum = obj.add(11, 13);
            double sum1 = obj.add(11.5, 3.4);
            float sum2 = obj.add(12.2f, 11.2f);
            Console.WriteLine(sum);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);



        }

    }
}
