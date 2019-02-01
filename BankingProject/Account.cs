using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account
    {
        private static int nextId = 1;
        private int Id { get; set; }
        private string Description { get; set; }
        private decimal Balance { get; set; }
        public void TransferTo(decimal Amount, Account Acct)
        {
            var BalanceBeforeWithDraw = GetBalance();
            Withdraw(Amount);
            var BalanceAfterWithdraw = GetBalance();
            if (BalanceBeforeWithDraw == BalanceAfterWithdraw)
            {
                Console.WriteLine("Insufficient Funds.");
                return;
            }   
            Acct.Deposit(Amount);
        }
        public int GetId()
        {
            return Id;
        }
        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string NewDescription)
        {
            Description = NewDescription;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public void Deposit(decimal Amount)
        {
            if(Amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
            } else
            {
                Balance += Amount;
            }
        }
        public void Withdraw(decimal Amount) // Withdraw must be positive and
        {                                   // also must be less than balance.
            if(Amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }
            if (Amount > Balance)
            {
                Console.WriteLine("Insuficiant Funds");
                return;
            }
            else
            {
                Balance -= Amount;
            }
        }
        public virtual string Print()
        {
            return $"Id = {Id}, Description = {Description}, Balance = {Balance}";
        }
        public Account(string NewDescription)
        {
            Id = nextId++;
            if(NewDescription == null)
            {
                Description = "New Account";
            } else
            {
                Description = NewDescription;
            }
            Balance = 0;
        }
        // This constructor calls the other constructor
        // and passes in a null value for NewDescription
        public Account() : this(null)
        {
        }
    }
}