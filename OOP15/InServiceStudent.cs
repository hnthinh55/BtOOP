using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP15
{
    class InServiceStudent : Student
    {
        public string Associate { get; private set; }
        public InServiceStudent(string studentId, string name, string birthDay, int yearAmission, double gPA, List<LearnResult> results, string associate) : base(studentId, name,birthDay, yearAmission,  gPA,results)
        {
            Associate = associate;
        }
        public InServiceStudent() { }
        public InServiceStudent(InServiceStudent student)
        {
            Associate= student.Associate;
        }
        public override void InputInfo()
        {
            base.InputInfo();
            Console.WriteLine("Associate Location: ");
            Associate = Console.ReadLine();
        }
        public override void OutPutInfo()
        {
            base.OutPutInfo();
            Console.WriteLine($"Associate Location: {Associate}");
        }
    }
}
