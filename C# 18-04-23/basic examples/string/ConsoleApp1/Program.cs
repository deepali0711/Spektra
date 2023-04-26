using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info= "Welcome to spektra systems";
            int wordCount = 0;

            for(int i=0; i<info.Length-1; i++)
            {
                if (info[i] ==  'e' &&Char.IsLetter(info[i + 1]))

                  wordCount++;
            }
            wordCount++;
            Console.WriteLine("Count of words"  + wordCount);
        }
        
    }
}
