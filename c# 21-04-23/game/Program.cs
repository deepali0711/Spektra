using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("-------");
            Console.WriteLine("Calculator");
            Console.WriteLine("-------");

            Console.WriteLine("Enter first number");
            num1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second no.");
            num2= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operation");
            Console.WriteLine("+: Addition");
            Console.WriteLine("-: Substraction");
            Console.WriteLine("*: Multiplication");
            Console.WriteLine("/: Division");

            switch(Console.ReadLine())
            {
                case  "+":
                    result = num1 + num2;
                    Console.WriteLine($"Addition of numbers: { num1} +{ num2}= " +result);
                    break;

                    case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Substraction of numbers:{num1}-{num2}=" + result);
                    break;

                    case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Multiplication of numbers:{num1}*{num2}=" + result);
                    break;

                    case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Division of numbers:{num1}/{num2}=" + result);
                    break;
                default:
                    Console.WriteLine(" not valid option");
                    break;
            }

            Console.ReadKey();
        }
    }
}
