using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class is made using the inheritance method.

namespace BankingProject
{
    class Savings : Account
    {
        private decimal IntRate { get; set; } = 0.01M;
        public override string Print()
        {
            return base.Print() + $" IntRate = {IntRate}";
        }
        public decimal GetIntRate()
        {
            return IntRate;
        }
        public void SetIntRate(decimal NewIntRate)
        {
            IntRate = NewIntRate;
        }
        public void PayIntrest()
        {
            var IntToBePaid = GetBalance() * IntRate;
            Deposit(IntToBePaid);
        }
        public Savings(string NewDescription) : base(NewDescription)
        {
            SetIntRate(0.01M);
        }
        public Savings() : this(null)
        {
        }
    }
}
