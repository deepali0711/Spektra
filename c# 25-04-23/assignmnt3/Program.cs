using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt3
{
    internal class Program
    {
        public static void Main()
        {
            Action<string,string,string>printActionDel=ConsolePrint;
            printActionDel("apple","orange","mango");

        }
        public static void ConsolePrint(string i,string f,string g)
        {
            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(g);

        }
    }
}
