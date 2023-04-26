using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 29, 60, 31 };
            int biggestNumber = numbers.Max();
            Console.WriteLine(" Highest number is " + biggestNumber);
            Console.ReadLine();
        }
    }
}
