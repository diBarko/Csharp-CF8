using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class InsufficientAmountException : Exception
    {
        public InsufficientAmountException() : base("Insufficient amount for the transaction")
        {   // base is like super() in java
        }

        public InsufficientAmountException(string message) : base(message)
        {
        }

        public InsufficientAmountException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}