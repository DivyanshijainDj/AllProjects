// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using Banking_Task;

Console.WriteLine("Banking Application for Deposit and Withdrawl");

Banking bankaccount = new Banking();
BankTransaction transaction = new BankTransaction();
Account account = new Account();

Random random = new Random();


for (int i = 0; i < 2; i++)
{
    
    account.AccountNUmber = random.Next(10000, 20000);


    Console.WriteLine("Please enter Account Name: ");
    string accname = Console.ReadLine();

    Console.WriteLine("Please enter Open Balance: ");
    int openbal = Convert.ToInt32(Console.ReadLine());


    account.AccountName = accname;
    account.OpenBalance = openbal;
    bankaccount.CreateAccount(account, accname, openbal);


}


