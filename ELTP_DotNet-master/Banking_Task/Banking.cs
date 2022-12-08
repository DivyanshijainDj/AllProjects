using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banking_Task
{
    public class Banking
    {
       public static ConcurrentBag<Account> Details = new ConcurrentBag<Account>();

        public void CreateAccount(Account account, string name, int balance)
        {
           
             
            account.AccountName = name;
            account.OpenBalance = balance;

            Details.Add(account);            


        }

    }

   
}

