using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exception
{
    internal class OutOfLimitException : Exception
    {
        public OutOfLimitException(string? message) : base(message)
        {

        }
    }
}
