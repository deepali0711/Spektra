using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, output, input;

            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());
            output=average(num1, num2, num3);
            input = sum(num1, num2);
            Console.Write("is the Average of entered numbers" + output );
            Console.Write('\n');
            Console.Write("is the Addition of entered numbers" + input);

            Console.ReadKey();
        }
        static float average (float num1, float num2, float num3)
            {
            float result = (num1 + num2 + num3 / 3);
            return result;
            }
        static float sum (float num1, float num2)
        {
            float submit = (num1 + num2);
            return submit;
        }
    }
}
