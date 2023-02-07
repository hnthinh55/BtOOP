using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP15
{
    class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public int YearAmission { get; set; }
        public double GPA { get; set; }
        public IList<LearnResult> results { get; set; }
        public Student() { }
        public Student(string studentId, string name, string birthDay, int yearAmission, double gPA, List<LearnResult> results)
        {
            StudentId = studentId;
            Name = name;
            BirthDay = birthDay;
            YearAmission = yearAmission;
            GPA = gPA;
            this.results = results;
        }
        public Student(Student student)
        {
            StudentId = student.StudentId;
            Name = student.Name;
            BirthDay = student.BirthDay;
            YearAmission = student.YearAmission;
            GPA = student.GPA;
            this.results = student.results;
        }
        //Input student information
        public virtual void InputInfo()
        {
            Console.Write("Student ID:");
            StudentId = Console.ReadLine();
            Console.Write("Name:");
            Name = Console.ReadLine();
            Console.Write("BirthDay:");
            BirthDay = Console.ReadLine();
            Console.Write("YearAmission:");
            YearAmission = Convert.ToInt32(Console.ReadLine());
            Console.Write("GPA:");
            GPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number learn result: ");
            int number = Convert.ToInt32(Console.ReadLine());
            this.results = new List<LearnResult>();
            for (int j = 0; j < number; j++)
            {
                LearnResult result = new LearnResult();
                result.InputResult();
                results.Add(result);
            }
        }
        //Ouput information of student
        public virtual void OutPutInfo()
        {
            Console.WriteLine($"Student ID:{StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"BirthDay: {BirthDay}");
            Console.WriteLine($"YearAmission: {YearAmission}");
            Console.WriteLine($"GPA: {GPA}");
            string tmp = string.Join(",", (from item in results
                                           select new { item.Semester, item.SemesterGPA }).ToList());
            Console.WriteLine($"Learn result : {tmp}");
        }
        //Get max semester GPA
        public double? MaxSemesterGPA()
        {
            var tmp = (from item in results
                      orderby item.SemesterGPA
                      select item).FirstOrDefault();
            if (tmp != null)
            {
                return tmp.SemesterGPA;
            }
            else
            {
                return null;
            }
        }
    }
}
