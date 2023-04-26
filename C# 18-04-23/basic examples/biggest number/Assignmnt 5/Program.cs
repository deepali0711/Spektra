using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnt_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 29, 60, 31 };
            int biggestNumber = numbers.Max();
            int lowestNumber = numbers.Min();
            Console.WriteLine(" Highest number is " +biggestNumber);
            Console.WriteLine(" lowest number is " +lowestNumber);
            Console.ReadLine();
         }
    }
}
