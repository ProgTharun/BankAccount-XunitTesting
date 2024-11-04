using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_XunitTesting
{
    internal class DepositAmountMustBePositive:Exception
    {
        public DepositAmountMustBePositive(string message) : base(message) { }
    }
}
