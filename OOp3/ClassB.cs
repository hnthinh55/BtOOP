using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp3
{
    class ClassB : Student
    {
        public readonly string Math = "Mon Toan";
        public readonly string Biology = "Mon Sinh";
        public readonly string Chemistry = "Mon Hoa";
        public ClassB(string id, string name, string adress, string priority) : base(id, name, adress, priority)
        {
        }
        public override String ToString()
        {
            return $"**Khoi B:\nID: {Id} \n" +
                $" Ten hoc sinh : {Name}\n" +
                 $" Dia chi: {Address}\n" +
                  $" Muc uu tien: {Priority} \n"
                +$"Mon thi: {Math}, {Biology}, {Chemistry}";
        }
    }
}
