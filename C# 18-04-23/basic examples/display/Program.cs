using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Orange");
            al.Add("Mango");
            al.Add("Banana");
            al.Add("Apple");
            al.Add("Guava");

            foreach (object obj in al)
                Console.WriteLine(obj + "");
        }
    }
  }
        





          