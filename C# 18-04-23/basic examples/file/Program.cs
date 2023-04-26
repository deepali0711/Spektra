using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file
{
    internal class Program
    {
       public static void Main()
        {
            Directory.CreateDirectory("D:\\Spektra\\c# 20-04-23\\directory\\project");
            string file1 = @"D:\Spektra\c# 20-04-23\directory\project\file1.txt";
            string file2 = @"D:\Spektra\c# 20-04-23\directory\project\file2.txt";

            File.WriteAllText(file1, "hello welcome in file1");
            File.WriteAllText(file2, "hello welcome in file2");
            Console.WriteLine(File.ReadAllText(file1));
            Console.WriteLine(File.ReadAllText(file2));
        }
    }
}
