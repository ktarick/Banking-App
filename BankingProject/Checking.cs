using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Checking : Account
    {
        public override string Print()
        {
           return base.Print() + $", Next Check Number is {NextCheckNumber}";
        }
        public int NextCheckNumber { get; set; } = 1;
        public int GetNextCheckNumber()
        {
            return NextCheckNumber;
        }

        public Checking(string NewDescription) : base(NewDescription)
        {

        }
        public Checking() : this(null)
        {

        }
    }
}
