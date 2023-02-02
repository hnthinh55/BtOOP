using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ClassA :Student
    {
        public readonly string Math = "Mon Toan";
        public readonly string Physics = "Mon Ly";
        public readonly string Chemistry = "Mon Hoa";
        public ClassA(string id, string name, string adress, string priority) : base(id, name, adress, priority)
        {
        }
        public override String ToString()
        {
            return $"**Khoi A:\nID: {id} \n Ten hoc sinh : {name}\n Dia chi: {address}\n Muc uu tien: {priority} \n Mon thi: {Math}, {Physics}, {Chemistry}";
        }
    }
}
