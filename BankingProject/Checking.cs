using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class is made using the composition method.

namespace BankingProject
{
    class Checking
    {
        private Account acccount { get; set; }
        public int NextCheckNumber { get; set; } = 1;
        public int GetId()
        {
            return acccount.GetId();
        }
        public double GetBalance()
        {
            return (double) acccount.GetBalance();
        }
        public string GetDescription()
        {
            return acccount.GetDescription();
        }
        public void SetDescription(string NewDescription)
        {
            acccount.SetDescription(NewDescription);
        }
        public void Deposit(decimal Amount)
        {
            acccount.Deposit(Amount);
        }
        public void Withdraw(decimal Amount)
        {
            acccount.Withdraw(Amount);
        }
        public string Print()
        {
           return acccount.Print() + $", Next Check Number is {NextCheckNumber}";
        }
        public int GetNextCheckNumber()
        {
            return NextCheckNumber;
        }
        public Checking(string NewDescription)
        {
            acccount = new Account(NewDescription);
        }
        public Checking() : this(null)
        {
        }
    }
}
