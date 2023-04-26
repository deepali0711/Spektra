using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignmnt2
{
    internal class Program
    {
        class Employee
        {
            int Sales, Amount = 34000;
            public int getNumberOfSales()
            {
                return Sales;

            }
            public void setNumberofSales(int x)
            {
                Sales = x;
            }
            public int getSalary()
            {
                return Amount;
            }
        }
        class SalesAssociates : Employee
        {

            public SalesAssociates(int y)
            {
                setNumberofSales(y);
            }
            public float SalesBonus()
            {
                int monthly = getNumberOfSales();

                if (monthly >= 10 && monthly <20)
                {
                    float output = ((getSalary()* ((float)5/ 100)) + getSalary());
                    return output;
                }
                else if (monthly >=20 && monthly <30)
                {
                    float result = ((getSalary() * ((float)10 / 100)) + getSalary());
                    return result;
                }
                else if (monthly >= 30)
                {
                    float input = ((getSalary()* ((float)20/ 100)) + getSalary());
                    return input;
                }
                else
                {
                    return (0);
                }


            }
        }

        public static void Main(string[] args)
        {
            SalesAssociates data = new SalesAssociates(10);
            Console.WriteLine(data.SalesBonus());

        }
    }
}

