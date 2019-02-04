﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    interface IAccount
    {
        int GetId();
        string GetDescription();
        void SetDescription(string NewDescription);
        decimal GetBalance();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void TransferTo(Account account, decimal amount);
    }
}
