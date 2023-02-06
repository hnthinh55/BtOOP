using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13.Exceptions
{
    internal class PhoneException : Exception
    {
        public PhoneException() { }
        public PhoneException(string phone)
        : base(String.Format(phone))
        {

        }
    }
}
