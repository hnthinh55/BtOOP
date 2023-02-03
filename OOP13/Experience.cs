using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    internal class Experience : Employee
    {
        public int ExpInYear { get; private set; }
        public string ProSkill { get; private set; }

        public Experience(string id, string name, string birthDay, string phone, string email, int employee_Type , List<Certificate> certificates, int expInYear, string proSkill) : base(id, name, birthDay, phone, email, employee_Type, certificates)
        {
            ExpInYear = expInYear;
            ProSkill = proSkill;
        }
        public Experience() { }
        public override void ShowInfo()
        {
            var tmp = string.Join(",",(from item in certificates
                                       select item.CertificateName).ToArray());
            Console.WriteLine($"Experience[Id:{Id} \r\nName: {Name} \r\nBirthDay: {BirthDay} \r\nPhone:{Phone} \r\nEmail: {Email}\r\nType:{EmployeeType} \r\nCount:{EmployeeCount} \r\nExp In year: {ExpInYear} \r\nProSkill: {ProSkill}\r\nCertificate: {tmp}]");
        }
        public override void UpdateInfo(string field_name, string new_value)
        {
            Type obj = typeof(Experience);
            obj.GetProperty(field_name).SetValue(this, new_value);
        }
    }
}
