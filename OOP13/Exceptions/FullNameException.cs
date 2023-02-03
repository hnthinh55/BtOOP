using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13.Exceptions
{
    internal class FullNameException : Exception
    {
        public FullNameException() { }
        public FullNameException(string exception)
       : base(String.Format(exception))
        {
        }
    }
}
