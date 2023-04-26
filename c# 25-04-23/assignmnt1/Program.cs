using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace assignmnt1
{
    interface IBankaccount
    {
        void AddMoney(double amount);
        void Substract(double amount);
        void getInfo();
         double total();

    }
    class Currentaccount : IBankaccount
    {

        private double Money = 500;
        private readonly String name="Deepali";


        public void AddMoney(double amount)
        {   
            Console.WriteLine("--------------Current Account Details-------------------------");


            Console.WriteLine("Added " + amount + "to the bank account succesfully");
            this.Money = Money + amount;
        }
        public void Substract(double amount)
        {
            Console.WriteLine("Withdrawl of " + amount + "from the bank account succesfully");
            this.Money = Money - amount;
        }
        public void getInfo()
        {
            Console.WriteLine( name +  " has "  + Money +  "in bank");
            
           
        }
        public double total()
        {
            return this.Money;
        }
        class Savingsaccount : IBankaccount
        {
            private double Money = 600;
            private readonly String name = "Deepali";



            public void AddMoney(double amount)
            {
                Console.WriteLine("-----------------------Saving Account Details-----------------");
                Console.WriteLine("Added " + amount + "to the bank account succesfully");
                this.Money = Money + amount;
            }
            public void Substract(double amount)
            {
                Console.WriteLine("Withdrawl of " + amount + "from the bank account succesfully");
                this.Money = Money - amount;
            }
            public void getInfo()
            {
                Console.WriteLine(name +  " has "  + Money+  "in bank");
            }
            public double total()
            {
                return this.Money;
            }
        }
        static void Main(string[] args)
        {
            IBankaccount account = new Currentaccount();
            account.AddMoney(100);
            account.getInfo();
            account.Substract(50);
            account.getInfo();
            IBankaccount bankaccount = new Savingsaccount();
            bankaccount.AddMoney(100);
            bankaccount.getInfo();
            bankaccount.Substract(400);
            bankaccount.getInfo();
            Console.WriteLine("---------------Total Balance of both account---------");
            Console.WriteLine(" Total balance in current account:" + (account.total()+bankaccount.total()));

        }
    }
}
    

