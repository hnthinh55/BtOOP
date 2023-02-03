using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Staff : Officer
    {
        public string Task { get; private set; }
        public Staff(string name, int age, string gender, string address, string task) : base(name, age, gender, address)
        {
            this.Task = task;
        }
        public override String ToString()
        {
            return $"**Hoten: {FullName} \n Tuoi: {Age} \n GioiTinh: {Gender} \n DiaChi: {Address} \n CongViec: {Task}";
        }
    }
}
