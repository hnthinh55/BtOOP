using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Officer
    {
        public string FullName { get; set; }
        public int Age  { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Officer(string name, int age, string gender, string address)
        {
            FullName = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
        }
        
    }
}
