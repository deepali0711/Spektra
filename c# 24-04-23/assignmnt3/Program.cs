using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double result ;

            result = Multiply(2, 4, 6);

            Console.WriteLine("Calculating operations");

            Console.WriteLine(result);
            Console.ReadKey();

            
        }
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Multiply(double num1, double num2, double num3 )
        {
            return num1 * num2 * num3;
        }
    }
}
