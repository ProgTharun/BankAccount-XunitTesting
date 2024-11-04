using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_XunitTesting
{
    public class BankAccount
    {

        public double Balance { get; set; }

        public BankAccount(double initialBalance = 0)
        {
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new DepositAmountMustBePositive("Deposit amount must be positive.");
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new Exception("Withdraw amount must be positive.");
            if (amount > Balance)
                throw new InSufficientBalanceException("Insufficient balance.");
            Balance -= amount;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void Transfer(BankAccount toAccount, double amount)
        {
            if (toAccount == null)
                throw new TargetCannotBeNullException(nameof(toAccount), "Target account cannot be null.");
            if (amount <= 0)
                throw new AmountMustBePositive("Transfer amount must be positive.");
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient balance to transfer.");

            Withdraw(amount);
            toAccount.Deposit(amount);
        }
    }
}