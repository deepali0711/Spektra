using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt1
{
    internal class Program
    {
            
        static async Task<string> ReadAsync(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }

        }


        static async Task Main(string[] args)
        {
            string filePath = "D:\\Spektra\\c# 26-04-23\\file.txt";
            var text = await ReadAsync(filePath);
            Console.WriteLine("---------- Display the text from file.text--------------\n\n");
            
            Console.WriteLine("Text in the file.text                                     "+text.Length);
            Console.WriteLine("Length of the Characters present in the text file         "  +text);
           
        }

    }
}
