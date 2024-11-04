using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_XunitTesting
{
    internal class InSufficientBalanceException:Exception
    {
        public InSufficientBalanceException(string message) : base(message) { }
    }
}
