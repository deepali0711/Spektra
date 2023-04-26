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
        static void Main(string[] args)
        {
            Directory.CreateDirectory("D:\\Spektra\\c# 20-04-23\\assignmnt2\\task");
            string file1 = @"D:\Spektra\c# 20-04-23\assignmnt2\task\file1.txt";
            string file2 = @"D:\Spektra\c# 20-04-23\assignmnt2\task\file2.txt";
            string file3 = @"D:\Spektra\c# 20-04-23\assignmnt2\task\file3.txt";
            File.WriteAllText(file1, "hello welcome in file1");
            File.WriteAllText(file2, "hello welcome in file2");
            File.Replace(file1, file2,file3);
            Console.WriteLine(File.ReadAllText(file2));
        }
    }
}
