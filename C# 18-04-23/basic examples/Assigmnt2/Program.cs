using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmnt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> studentnames=new SortedList<int,string>();
            studentnames.Add(3, "chinto");
            studentnames.Add(1, "shree");
            studentnames.Add(4, "harish");
            studentnames.Add(2, "nitin");
            studentnames.Add(6, "anu");
            studentnames.Add(5, "nilesh");
            studentnames.Add(10, "pari");
            studentnames.Add(9, "siri");
            studentnames.Add(7, "sara");
            studentnames.Add(8, "nipun");

            Console.WriteLine("STUDENT DETAILS");
            foreach (var kvp in studentnames)
                Console.WriteLine("Id:{0}, Student Name:{1}", kvp.Key, kvp.Value);

        }
    }
}
