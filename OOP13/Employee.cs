using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    abstract class Employee
    {
        public string Id { get;protected set; }
        public string Name { get; protected set; }
        public string BirthDay { get; protected set; }
        public string Phone { get; protected set; }
        public string Email { get; protected set; }
        public int EmployeeType { protected get; set; }
        public static int EmployeeCount { get; protected set; }
        public IList<Certificate> certificates;
        public Employee(string id, string name, string birthDay, string phone, string email, int employee_Type, List<Certificate> certificates)
        {
            Id = id;
            Name = name;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            EmployeeType = employee_Type;
            EmployeeCount ++;
            this.certificates = certificates;
        }
        public Employee() { }
        public abstract void ShowInfo();
        public abstract void UpdateInfo(string field_name, string new_value);
    }
}
