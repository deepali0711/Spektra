using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt_1
{
    internal class Math
    {
        
         static void Main(string[] args)
        {
 
            Circle c = new Circle(4);
            Rectangle d = new Rectangle(4,6);
            Square e = new Square(8);
            Console.WriteLine("Area of circle is"+ c.Area());
            Console.WriteLine("Area of Rectangle is"+ d.Area());
            Console.WriteLine("Area of Square is"+ e.Area());
            
        }
    }
    abstract class Calculate
    {
        public abstract double Area();
    }
     class Circle :Calculate
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            double result = (3.14 * radius * radius);
            return result;
        }
    }
    class Rectangle : Calculate
    {
        double Length;
        double Breadth;
        public Rectangle(double Length,double Breadth)
        {
            this.Length = Length;
            this.Breadth = Breadth;
        }
        public override double Area()
        {
            double submit = (Length*Breadth);
            return submit;

        }
    }
    class Square : Calculate
    {
        float Side;
        public Square(float Side)
        {
            this.Side = Side;
        }
        public override double Area()
        {
            double succesful = (Side*Side);
            return succesful;

        }
    }
}
