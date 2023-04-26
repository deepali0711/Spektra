using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> list = new List<List<string>>();
    
            
            for (int i = 0; i < 3; i++)
            {
                List<string> list2 = new List<string>();
                Console.WriteLine("Enter the student name ");
                string name = Console.ReadLine();
                Console.Write("Enter the department ");
                string dept = Console.ReadLine();
                Console.Write("Enter the passout year:");
                string year = Console.ReadLine();
                list2.Add(name);
                list2.Add(dept);
                list2.Add(year);
                list.Add(list2);



            }
           
          
            foreach (var item in list)
            {
                foreach(var item2 in item) 
                Console.WriteLine(item2);
                
            }

            Console.ReadKey();
        }
    }
}
