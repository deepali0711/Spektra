using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt1
{
    public class LinkedList
    {
       public static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddFirst("shiva");
            names.AddFirst("niva");
            names.AddFirst("pankaj");
            names.AddFirst("santosh");
            names.AddFirst("shuhbham");
            names.Remove("shiva");
            
            foreach(var name  in names)
            { 
            Console.WriteLine(name);
            }
        }
    }
}
