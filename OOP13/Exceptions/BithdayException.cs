using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13.Exceptions
{
    [Serializable]
    internal class BithdayException : Exception
    {
        public BithdayException() { }
        public BithdayException(string birthday)
        : base(String.Format("Birthday is wrong: {0}", birthday))
        {

        }
    }
}
