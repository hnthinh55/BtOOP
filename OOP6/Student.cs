using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    internal class Student
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Student() { }
        public Student(string fullname, int age,string address) { 
            this.Fullname = fullname;
            this.Age = age;
            this.Address = address;
        }
        public override String ToString()
        {
            return $"* Hoc sinh: {Fullname} \n  Age:{Age} \n  Address: {Address}\n";
        }
    }
}
