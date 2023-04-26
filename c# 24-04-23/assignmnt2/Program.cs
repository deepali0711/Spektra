using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt2
{
    internal class Program
    {
        public class Rectangle
        {
            public int Width = 0;
            public int Height=0;

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public static Rectangle operator + (Rectangle r1,Rectangle r2)
            {
                Rectangle result = new Rectangle(r1.Width + r2.Width, r2.Height + r2.Height);
                return result;
            }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(3, 4);
            Rectangle r2 = new Rectangle(2, 6);

            Rectangle result= r1+ r2;

            Console.WriteLine($"'r1(3,4)'+'r2(2,6)'='result{result.Width},{result.Height}'");
              Console.ReadKey();

        }
    }
}
