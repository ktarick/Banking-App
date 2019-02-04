using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] accounts =
            {
                new Account("An Account"),
                new Savings("A Savings"),
                new Checking("A Checking"),
                new Customer("A bank customer")
            };
            foreach(var account in accounts)
            {
                Console.WriteLine(account.Print());
            }

            //Account acctAbc = new Account("abc");
            //Account acctXyz = new Account("xyz");
            //Account[] accounts = { acctXyz, acctAbc };
            //Array.Sort(accounts);
            //foreach(var account in accounts)
            //{
            //    Console.WriteLine(account.GetDescription());
            //}
            //Console.ReadKey();

            //Checking chk0 = new Checking();
            //Console.WriteLine(chk0.Print());
            //chk0.Deposit(300);
            //Console.WriteLine(chk0.Print());
            //chk0.Withdraw(100);
            //Console.WriteLine(chk0.Print());

            //Checking chk01 = new Checking("Checking 01");
            //Console.WriteLine(chk01.Print());

            //var chk1 = new Checking("First Checking Acct");
            //Console.WriteLine(chk1.Print());

            //var chk2 = new Checking();
            //chk2.Deposit(500);
            //Console.WriteLine(chk2.Print());

            //var sav1 = new Savings();
            //sav1.SetDescription("Savings");
            //sav1.Deposit(1500);
            //sav1.Withdraw(500);
            //sav1.PayIntrest();
            //Console.WriteLine(sav1.Print());

            //var sav2 = new Savings();
            //sav2.SetDescription("From Savings Acount");
            //sav2.Deposit(1000);
            //Console.WriteLine(sav2.Print());

            //var sav3 = new Savings();
            //sav3.SetDescription("To Saving Account");
            //sav3.Deposit(100);
            //Console.WriteLine(sav3.Print());

            //List<Account> accounts = new List<Account>();
            //accounts.Add(chk1);
            //accounts.Add(chk2);
            //accounts.Add(sav1);
            //accounts.Add(sav2);
            //accounts.Add(sav3);

            //foreach(var account in accounts)
            //{
            //    Console.WriteLine(account.Print());
            //}

            //sav2.TransferTo(200, sav3);
            //Console.WriteLine(sav2.Print());
            //Console.WriteLine(sav3.Print());

            //sav3.TransferTo(500, sav2);
            //Console.WriteLine(sav2.Print());
            //Console.WriteLine(sav3.Print());

            //var acct1 = new Account("Test 1");

            //acct1.Deposit(1000);
            //acct1.Withdraw(100);
            //Console.WriteLine(acct1.Print());

            //var acct2 = new Account("Test 2");
            //acct2.Deposit(100);
            //acct2.Withdraw(50);
            //Console.WriteLine(acct2.Print());

            //var acct3 = new Account();
            //acct3.Deposit(1000);
            //acct3.Withdraw(500);
            //Console.WriteLine(acct3.Print());

        }
    }
}
