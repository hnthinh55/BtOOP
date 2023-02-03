using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    class Worker : Officer
    {
        public int Rank { get; private set; }
        public Worker(string name, int age, string gender, string address, int rank) : base(name, age, gender, address)
        {
            this.Rank = rank;
        }
        public override String ToString()
        {
            return $"**Hoten: {FullName} \n Tuoi: {Age} \n GioiTinh: {Gender} \n DiaChi: {Address} \n Bac: {Rank}";
        }


    }
}
