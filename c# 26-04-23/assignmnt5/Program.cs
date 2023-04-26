using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt5
{
    internal class Program
    {    
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }    
        }
        static void Main(string[] args)

        {
            IList<Employee> employeeList = new List<Employee>()
            {
                new Employee {Id=1, Name="pia"},
                new Employee {Id=2, Name="ram"},
                new Employee {Id=3, Name="nitya"},
                new Employee {Id=4, Name="nitish"}
            };

            var orderByResult = from s in employeeList
                                orderby s.Name
                                select s;

            var orderByDescendingResult = from s in employeeList
                                          orderby s.Name descending
                                          select s;

        }

    }
}
