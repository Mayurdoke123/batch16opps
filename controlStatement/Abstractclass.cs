using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace batch16opps
{
    public abstract class shape
    {
        public string Shape{ get; set; }
        //double length;
        //  double width;
        //double area;
        public abstract void Calculatearea();
        public void Display()
        {
            Console.WriteLine($"area of shape {Shape}");
           

        }
    }
    //derived class
    public class Circle : shape
    {
        public int r = 5;
        float pi = 3.14f, area;
        public override void Calculatearea()
        {
            area = pi * r * r;
            Console.WriteLine("area of circle is:" + area);
        }

    }
    public class Rectangle : shape
    {
        public int l = 6,b=3,area;
        public override void Calculatearea()
        {
            area = l * b;
            Console.WriteLine("area of rectangle is:"+area);
        }
        }
 internal class Abstractclass
    {
        static void Main()
        {Circle c = new Circle();
            c.Display();    
            c.Calculatearea();
            Rectangle r = new Rectangle();
           r.Display();
            r.Calculatearea();



        }
    }
}


