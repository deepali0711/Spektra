using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string Empname { get; set; }
        public string Gender { get; set; }
    }
    public class Employeedetails
    {
        private List<EmployeeData> listEmployeeData;
        public Employeedetails()
        {
            listEmployeeData = new List<EmployeeData>();
            listEmployeeData.Add(new EmployeeData { Id = 1, Empname = "doma", Gender = "Female" });
            listEmployeeData.Add(new EmployeeData { Id = 2, Empname = "soma", Gender = "female" });
            listEmployeeData.Add(new EmployeeData { Id = 3, Empname = "toma", Gender = "female" });
        }
        //indexer
        public string this[int id ]
        {
            set
            {
                listEmployeeData.FirstOrDefault(x=>x.Id==id).Empname = value;
            }
            get
            {
               return listEmployeeData.FirstOrDefault(x => x.Id == id).Empname;

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employeedetails obj = new Employeedetails();
                Console.WriteLine("Name of employee-" + obj[3]);
            Console.ReadKey();
            }
        }
    } }

     
