using OOP13.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        // Show informatiuon method
        public abstract void ShowInfo();
        // Update Information of employee
        public abstract void UpdateInfo(string field_name, string new_value);
        //Input information of Employee
        public virtual void InputInfo()
        {
            
            Console.WriteLine("Enter ID: "); //Enter Id
            Id = Console.ReadLine();
            Console.WriteLine("Enter fullname: "); //Enter Fullname
            Name = Console.ReadLine();        
            Console.WriteLine("Enter birthday: "); //Enter Day of birth 
            BirthDay = Console.ReadLine();
            Console.WriteLine("Enter phone: "); //Enter phone
            Phone = Console.ReadLine();           
            Console.WriteLine("Enter email: "); //Enter email
            Email = Console.ReadLine();
            Console.WriteLine("Enter number certificate employee have: ");
            int number = Convert.ToInt32(Console.ReadLine());
            certificates = new List<Certificate>();
            for (int j = 0; j < number; j++)
            {
                certificates[j].InputCertificate();
            }
        }
    }
}
