using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Loop through each row and column index and display its value
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int column = 0; column < jaggedArray[row].Length; column++)
                {
                    Console.WriteLine("Index [{0}, {1}]: {2}", row, column, jaggedArray[row][column]);
                }
            }
        }
    }
}
