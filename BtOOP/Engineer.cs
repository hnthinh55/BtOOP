using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    class Engineer : Officer
    {
        public string Major { get; private set; }
        public Engineer(string name, int age, string gender, string address, string major) : base(name, age, gender, address)
        {
            this.Major = major;
        }
        public override String ToString()
        {
            return $"**Hoten: {FullName} \n Tuoi: {Age} \n gioiTinh: {Gender} \n diaChi: {Address} \n nganh: {Major}";
        }

    }
}
