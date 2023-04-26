using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SortedList mylist = new SortedList();

            mylist.Add("Key1", "black");
            mylist.Add("Key2", "purple");
            mylist.Add("Key3", "green");
            mylist.Add("Key4", "pink");
            mylist.Add("Key5", "white");

            int i = 3;
            Console.WriteLine("key at index {0} is {1}",
                         i, mylist.GetKey(i));

        }
       
    }
}
