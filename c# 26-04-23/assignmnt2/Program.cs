using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string directoryPath = @"D:\Spektra\c# 26-04-23\assignmnt2";
            var fileExtensions = Directory.GetFiles(directoryPath)
                                         .GroupBy(file => Path.GetExtension(file).ToLower())
                                         .OrderBy(group => group.Count());
            Console.WriteLine("File extensions and their counts in {0}:", directoryPath);

            foreach (var m in fileExtensions)
            {
                Console.WriteLine("{0}: {1}", m.Key, m.Count());

            }
            Console.ReadLine();
        }
        
    }
}
