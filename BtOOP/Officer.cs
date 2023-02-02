using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Officer
    {
        public string fullname { get; set; }
        public int age  { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public Officer(string name, int age, string gender, string address)
        {
            fullname = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }
        
    }
    class Engineer : Officer
    {
        private string major { get; set; }
        public Engineer(string name, int age, string gender, string address, string major) : base(name, age, gender, address)
        {
            this.major = major;
        }
        public override String ToString()
        {
            return $"**Hoten: {fullname} \n Tuoi: {age} \n gioiTinh: {gender} \n diaChi: {address} \n nganh: {major}";
        }

    }
    class Worker : Officer
    {
        public int rank { get; private set; }
        public Worker(string name, int age, string gender, string address, int rank) : base(name, age, gender, address)
        {
            this.rank = rank;
        }
        public override String ToString()
        {
            return $"**Hoten: {fullname} \n Tuoi: {age} \n GioiTinh: {gender} \n DiaChi: {address} \n Bac: {rank}";
        }

        
    }
    class Staff : Officer
    {
        public string task { get; private set; }
        public Staff(string name, int age, string gender, string address, string task) : base(name, age, gender, address)
        {
            this.task = task;
        }
        public override String ToString()
        {
            return $"**Hoten: {fullname} \n Tuoi: {age} \n GioiTinh: {gender} \n DiaChi: {address} \n CongViec: {task}";
        }
    }
}
