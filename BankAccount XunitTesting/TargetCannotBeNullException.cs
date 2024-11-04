using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_XunitTesting
{
    internal class TargetCannotBeNullException:Exception
    {
        public TargetCannotBeNullException(string message,string messages) : base(message) { }
    }
}
