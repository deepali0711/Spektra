using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt5
{
    public class EmployeeData
    {
       private string[] array = new string[4];
        private int empId;
        private string empName;
        private string empDept;
        public object this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return this.empId;
                }
                else if (i == 1)
                {
                    return this.empName;  
                }
                else if (i == 2)
                {
                    return this.empDept;
                }
                else
                {
                    return null;
                }
            }
          set { 
                if (i == 0) {
                    empId = (int)value; 
                } 
                else if(i==1){ 
                    empName = (string)value; 
                }
                else if(i == 2){
                    empDept = (string)value; 
                }
          } 
        }
    }
    public class program
    {
        public static void Main(string[] args)
        {
            EmployeeData emp = new EmployeeData();
            emp[0] = 1;
            emp[1] = "Dipali";
            emp[2] = "Dev Team";

            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            
        }
    }
}
