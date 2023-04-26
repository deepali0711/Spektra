using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt4
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<List<string>> list = new List<List<string>>();

            for (int i = 0; i < 2; i++)
            {

                List<string> list2 = new List<string>();

                Console.WriteLine("Enter the  name ");
                string customername = Console.ReadLine();
                Console.Write("Enter the address ");
                string address = Console.ReadLine();
                Console.Write("Enter the city name:");
                string city = Console.ReadLine();
                list2.Add(customername);
                list2.Add(address);
                list2.Add(city);
                list.Add(list2);
            }

            string input = Console.ReadLine();
            Predicate<string> val = delegate(string inp){

                if (inp == "y")
                {
                    return true;
                }
                else if (inp == "n")
                {
                    return false;
                }
                else
                {
                    return false;
                }
            };

            if (val(input))

            {
                foreach (var item in list)
                {
                    foreach (var item2 in item)
                        Console.WriteLine(item2);

                }
            }
        }
    }
}
