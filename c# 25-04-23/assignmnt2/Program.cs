using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt2
{
    class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Substract(int x, int y)
         {
         return x - y;
        }
        public static int Multiplication(int x, int y)
         {
           return x * y;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> funcMath;
            Console.WriteLine("enter first numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second numbers");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("-----Calculation of two numbers------ ");


            funcMath = Sum;
            Console.WriteLine("Addition of two numbers: "  +funcMath(a, b));
            funcMath = Substract;
            Console.WriteLine("Substraction of two numbers: "  +funcMath(a, b));
            funcMath = Multiplication;
            Console.WriteLine("Multiplication of two numbers: "  +funcMath(a, b));



        }
}
}
