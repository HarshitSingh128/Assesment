using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public delegate void MyBankDelete();
    public class Bank
    {
        //delete event name
        public event MyBankDelete lowBalance;
        private double balance;
        public Bank()
        {
            balance = 5000;
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                lowBalance();//call or raise an event

            }
            else
            {
                balance -= amount;
            }

        }
        public override string ToString()
        {
            return $"Your Balance is {balance}";

        }
    }



    public class Mymessage
    {
        public void BalanceMsg()
        {
            Console.WriteLine("You have low balance");
        }
    }
}