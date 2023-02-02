using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp3
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Priority { get; set; }
        public Student() { }
        public Student(string id, string name, string adress, string priority)
        {
            Id = id;
            Name = name;
            Address = adress;
            Priority = priority;
        }

    }
}
