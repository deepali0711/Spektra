using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt2
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            SortedList<int, String> names = new SortedList<int, String>()
            {
                {1,"chinto" },
                {2,"bitto" },
                {4, "shiva" },
                {3, "shree" },
                { 7,"Deepu" },
                { 5,"likita" },
                { 6, "pankaj" },
                { 8, "niva" },
                { 10, "alia" },
                { 9, "siri" }
            };
            Console.WriteLine("Student details");
            foreach (var kvp in names)
                Console.WriteLine("Id: {0}, Name: {1}", kvp.Key, kvp.Value);

        }
    }
}
