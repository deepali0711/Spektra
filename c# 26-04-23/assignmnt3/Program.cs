using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignmnt3.Program;

namespace assignmnt3
{
    internal class Program
    {
        public class Student
        {
            public int rollno { get; set; }
            public string Name { get; set; }
            public int age { get; set; }
        }

        public class Class
        {
            public int rollno { get; set; }

            public string sub { get; set; }
            public string Teacher { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Students age greater than 18 \n");
            var student = new List<Student>
            {
            new Student {rollno=101, Name = "John", age = 20 },
            new Student { rollno=102,Name = "Mary", age = 18 },
            new Student { rollno=203, Name = "Peter", age = 22 },
            new Student { rollno=567, Name = "Jane", age = 17 },
            };
            var staff = new List<Class>
            {
                new Class {rollno=101,sub="physics",Teacher="Deepali"},
                new Class {rollno=102,sub="chemistry",Teacher="Pankaj"},
                new Class {rollno=203,sub="maths",Teacher="Shubham"},
                new Class {rollno=567,sub="bio",Teacher="Ayush"},
            };
            var result = from st in student
                         join Class in staff on st.rollno equals Class.rollno
                         where st.age > 18
                         select new {stName= st.Name, ClassName = Class.rollno,stage=st.age };
            
            foreach (var group in result)
            {
                Console.WriteLine("{0}-{1}-{2}", group.stName, group.ClassName,group.stage);
            }

        }
    }
}
