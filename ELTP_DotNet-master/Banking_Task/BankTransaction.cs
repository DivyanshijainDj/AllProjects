using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Task
{
    public class BankTransaction
    {
        public decimal Deposit(Account account)
        {

            account.NetBalance = account.OpenBalance + account.TransacAmount;
            return account.NetBalance;
        }

        public decimal Withdrawl(Account account)
        {
            account.NetBalance = account.OpenBalance - account.TransacAmount;

            return account.NetBalance;
        }


    }
}
