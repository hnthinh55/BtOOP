using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string priority { get; set; }
        public Student() { }
        public Student(string id, string name, string address, string priority)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.priority = priority;
        }

    }
}
