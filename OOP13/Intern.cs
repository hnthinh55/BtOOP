using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace OOP13
{
    class Intern : Employee
    {
        public string Major { get; private set; }
        public int Semester { get; private set; }
        public string UniversityName { get; private set; }

        public Intern() { }
        public Intern(string id, string name, string birthDay, string phone, string email, int employee_Type, List<Certificate> certificates, string major, int semester, string universityName) : base(id, name, birthDay, phone, email, employee_Type, certificates)
        {
            Major = major;
            Semester = semester;
            UniversityName = universityName;
        }
        public override void ShowInfo()
        {
            var tmp = string.Join(",", (from item in certificates
                                        select item.CertificateName).ToArray());
            Console.WriteLine($"Intern[Id:{Id} \r\nName: {Name} \r\nBirthDay: {BirthDay} \r\nPhone:{Phone} \r\nEmail: {Email}\r\nType:{EmployeeType} \r\nCount:{EmployeeCount} \r\nMojor: {Major} \r\nSemester: {Semester} \r\nUniversity Name:{UniversityName}  \r\nCertificate: {tmp}]");
        }

        public override void UpdateInfo(string field_name, string new_value)
        {
            Type obj = typeof(Intern);
            obj.GetProperty(field_name).SetValue(this, new_value);
        }
        public override void InputInfo()
        {
            base.InputInfo();
            Console.WriteLine("Enter major:");
            Major = Console.ReadLine();
            Console.WriteLine("Enter Semester");
            Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter UniversityName:");
            UniversityName = Console.ReadLine();
        }
    }
}

