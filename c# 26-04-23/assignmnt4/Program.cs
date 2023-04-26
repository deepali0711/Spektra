using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt4
{
    internal class Program
    {
        public class employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class salary
        {
            public int pay { get; set; }
            public int Id { get;set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Employees having Salary between 800 and 6000 \n");

            var employee = new List<employee>
            {
                new employee {Id=1, Name="pia"},
                new employee {Id=2, Name="ram"},
                new employee {Id=3, Name="nitya"},
                new employee {Id=4, Name="nitish"}
            };
            var payment = new List<salary>
            {
                new salary {pay=3000,Id=1 },
                new salary {pay=1000,Id=2 },
                new salary {pay=8000,Id=3 },
                new salary {pay=9000,Id=4 },
            };
            var result = from st in employee
                         join salary in payment on st.Id equals salary.Id
                         where  salary.pay>800 && salary.pay<6000 && st.Name.Length<4
                         orderby salary.pay
                         select new { stName = st.Name, salary= salary.pay};

            foreach (var group in result)
            {
                Console.WriteLine("{0}-{1}", group.stName, group.salary);
            }

        }
    }
}
