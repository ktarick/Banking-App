using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account
    {
        private int Id { get; set; }
        public int GetId()
        {
            return Id;
        }
        private string Description { get; set; }
        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string NewDescription)
        {
            Description = NewDescription;
        }
        private double Balance { get; set; }
        public double GetBalance()
        {
            return Balance;
        }
        public void Deposit(double Amount)
        {
            Balance += Amount;
        }
        public void Withdraw(double Amount)
        {
            Balance -= Amount;
        }
        public void Print()
        {
            Console.WriteLine($"Id = {Id}, Description = {Description}, Balance = {Balance}");
        }
        public Account(string NewDescription)
        {
            Id = -1;
            Description = NewDescription;
            Balance = 0;
        }
        public Account()
        {
            Id = -1;
            Description = "New Account";
            Balance = 0;
        }
    }
}
