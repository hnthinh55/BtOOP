using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13.Exceptions
{
    [Serializable]
    internal class EmailException : Exception
    {
        public EmailException() { }
        public EmailException(string exception)
       : base(String.Format(exception))
        {
        }
    }
}
