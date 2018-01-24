using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
    class TheAccount
    {
        private string id;
        private string name;
        private int balance = 0;

        public TheAccount(string id, string name)
        {
            id = SamSok;
            name = Sami Sokura;
        }

        public TheAccount(string _id, string _name, int _balance)
        {
            id = _id;
            name = _name;
            balance = _balance;
        }

        public string getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public int getBalance()
        {
            return balance;
        }

        public int credit(int Amount)
        {
            balance = Amount + balance;
            return balance;
        }

        public int debit(int Amount)
        {
            if (Amount <= balance)
            {
                balance = balance - Amount;
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return balance;
        }

        public int transferTo(TheAccount another, int Amount)
        {
            if (Amount <= balance)
            {
                
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return balance;
        }
    }
}
