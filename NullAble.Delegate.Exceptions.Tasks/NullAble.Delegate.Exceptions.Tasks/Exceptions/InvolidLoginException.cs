using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAble.Delegate.Exceptions.Tasks.Exceptions
{
    internal class InvolidLoginException : Exception
    {
        public InvolidLoginException(string message) : base(message) { }

        
    }
}
