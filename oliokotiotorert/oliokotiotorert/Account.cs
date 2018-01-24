using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
   public class Account
    {
        private string id;
        private string name;
        private int Balance = 0;

        public Account()
        {
            id = "ID";
            name = "Name";
        }

        public void  _Account(string _id, string _name, int _Balance)
        {
            id = _id;
            name = _name;
            Balance = _Balance;
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
            return Balance;
        }

        public void setBalance(int newBalance)
        {
            Balance = newBalance;
        }

        public int credit(int Amount)
        {
            return Amount + Balance;
        }

        public int debit(int Amount)
        {
            if (Amount <= Balance)
            {
                Balance = Balance - Amount;
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return Balance;
        }

        public int transferTo(Account another, int Amount)
        {
            if (Amount <= Balance)
            {
                another.Balance += Amount;
            }
            else
            {
                Console.WriteLine("Amount exceeded balance");
            }
            return another.Balance;
        }

        public string toString()
        {
            return "Account[id: " + id + ", name: " + name + ", balance: " + Balance;
        }
    }
}
