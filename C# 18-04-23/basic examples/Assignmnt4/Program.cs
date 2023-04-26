using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p, t, r, output;

            Console.WriteLine("Enter 1st number");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            r = Convert.ToInt32(Console.ReadLine());

            output = p * t * r / 100;

            Console.Write("Simple intrest is" + output);

            Console.ReadKey();
        }
    }
}
