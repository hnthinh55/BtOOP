using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace OOP13
{
    class Fresher : Employee
    {
        public string GraduationDate { get; private set; }
        public string GraduationRank { get; private set; }
        public string Education { get; private set; }
        public Fresher(string id, string name, string birthDay, string phone, string email, int employee_Type, List<Certificate> certificates, string graduationDate, string graduationRank, string education) : base(id, name, birthDay, phone, email, employee_Type,certificates)
        {
            GraduationDate = graduationDate;
            GraduationRank = graduationRank;
            Education = education;
        }
        public Fresher() { }
        public override void ShowInfo()
        {
            var tmp = string.Join(",", (from item in certificates
                                        select item.CertificateName).ToArray());
            Console.WriteLine($"Fresher[Id:{Id} \r\nName: {Name} \r\nBirthDay: {BirthDay} \r\nPhone:{Phone} \r\nEmail: {Email}\r\nType:{EmployeeType} \r\nCount:{EmployeeCount} \r\nGraduation Date: {GraduationDate} \r\nGraduationRank: {GraduationRank} \r\nEducation:{Education}  \r\nCertificate: {tmp}]");
        }
        public override void UpdateInfo(string field_name, string new_value)
        {
            Type obj = typeof(Fresher);
            obj.GetProperty(field_name).SetValue(this, new_value);
        }
        public override void InputInfo()
        {
            base.InputInfo();
            Console.WriteLine("Enter GraduationDate:");
            GraduationDate = Console.ReadLine();
            Console.WriteLine("Enter GraduationRank");
            GraduationRank = Console.ReadLine();
            Console.WriteLine("Enter Education:");
            Education = Console.ReadLine();
        }
    }
}
