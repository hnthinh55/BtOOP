using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP15
{
    class LearnResult
    {
        public string Semester { get; private set; }
        public double SemesterGPA { get; private set; }
        public LearnResult(string semester, double semesterGPA)
        {
            Semester = semester;
            SemesterGPA = semesterGPA;
        }
        public LearnResult() { }
        public void InputResult()
        {
            Console.WriteLine("Semester: ");
            Semester= Console.ReadLine();
            Console.WriteLine("GPA in Semester: ");
            SemesterGPA = Convert.ToDouble(Console.ReadLine());
        }
    }
}
