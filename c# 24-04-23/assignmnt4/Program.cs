using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt4
{
    internal class Program
    {



        class employee
        {
            public int empID;
            public string department;
            public string name;

            public employee(int ID, string dept, string ename)
            {
                this.empID = ID;
                this.department = dept;
                this.name = ename;
            }

        }
        static void Main()
        {
            List<employee> employees = new List<employee>();
            employees.Add(new employee(1, "Deep", "ENTC"));
            employees.Add(new employee(2, "Ashish", "CS"));
            employees.Add(new employee(3, "Aftab", "Civil"));

            Console.WriteLine("\nPlease Enter employee");
            
            foreach (employee e in employees)
            {
                Console.Write(e.empID+"\t"+e.name+"\t"+e.department+"\n");
                
            }
            Console.WriteLine("Enter Id to find");
            int id=Convert.ToInt32(Console.ReadLine());
            int flag = 1;
            foreach (employee e in employees)
            {
                if (e.empID == id)
                {
                    flag = 0;
                    Console.Write(e.empID + "\t" + e.name + "\t" + e.department + "\n");
                }
            }
            if(flag == 1)
            {
                Console.WriteLine("Id is not mention in the list");

            }

        }
    }
}

