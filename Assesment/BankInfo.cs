using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class BankInfo
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            Mymessage m1 = new Mymessage();
            // if lowbalance event raised than call the MyBankDelegate &
            // delete will call balacemsg method
            b1.lowBalance += new MyBankDelete(m1.BalanceMsg);
            Console.WriteLine("Initial Balance");
            Console.WriteLine(b1);

            b1.Withdraw(1000);
            Console.WriteLine("balance after withdraw 1000");
            Console.WriteLine(b1);

            b1.Withdraw(6000);
            Console.WriteLine("balance after withdraw 6000");
            Console.WriteLine(b1);


        }
    }
}
