using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[] cars = new string[3];

            cars[0] = "tesla";
            cars[1] = "mustang";
            cars[2] = "tcorvete";

            

                foreach (String car in cars)
                {
                    Console.WriteLine(car);
                }
            
            
          
            Console.ReadKey();
        }
    }
}
