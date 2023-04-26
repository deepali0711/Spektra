using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SortedList<int, String> names = new SortedList<int, String>()
            {
                {4,"four" },
                {5,"five" },
                {6, "six" },
                {7, "four" }
             };
            Console.WriteLine("Numbers are");

            foreach (var kvp in names)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
}
