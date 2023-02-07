using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP15
{
    class Department
    {
        public string DepartName { get; private set; }
        private IList<Student> students;
        public Department(string departName)
        {
            DepartName = departName;
            students = new List<Student>();
        }
        //Add new student into department
        public void AddStudent(Student student)
        {
            if (student != null)
            {
                students.Add(student);
                Console.WriteLine("Add successfull!");
            }
            else
                Console.WriteLine("Add fail");
        }
        //Remove student from department
        public void RemoveStudent(string studentId)
        {
            var check = from list in students
                        where list.StudentId == studentId
                        select list;
            if (check.Count() > 0)
            {
                students.Remove(check.FirstOrDefault());
                Console.WriteLine("Remove successfull");
            }
            else
            {
                Console.WriteLine("Invalid employee");
            }
        }
        //Show all student from department
        public void ShowStudents()
        {
            if (students.Count() < 0)
            {
                Console.WriteLine("This department has no student");
            }
            else
            {
                Console.WriteLine($"Department: {DepartName}    [");
                foreach (var student in students)
                {
                    student.OutPutInfo();
                }
                Console.WriteLine("]");
            }
        }
        //List Semester GPA of student
        public IDictionary<string, double[]> ListSemesterGPA(string semester)
        {
            if (semester == null)
            {
                Console.WriteLine("Invalid semester!!!");
                return null;
            }
            //
            //var listSemester = (from student in students
            //                    select new {, }).ToList();
            IDictionary<string, double[]> dict = new Dictionary<string, double[]>();
            foreach (var student in students)
            {
                var tmp = (from result in student.results
                           where result.Semester.Contains(semester)
                           select result.SemesterGPA).ToArray();
                dict.Add(student.Name, tmp);
            }
            return dict;
        }
        // List Inservice student
        public List<Student> ListInservice()
        {
            var listInservice = (from student in students
                                 where student.GetType() == typeof(InServiceStudent)
                                 select student).ToList();
            return listInservice;
        }
        // Get student have highest GPA
        public Student MaxGPA()
        {
            var maxGPA = (from student in students
                          orderby student.GPA descending
                          select student).First();
            return maxGPA;
        }
        // Get student have highest semester GPA
        public Student MaxSemesterGPA()
        {
            var goodStudent = (from student in students
                               orderby student.results.Max(item => item.SemesterGPA) descending
                               select student).First();
            return goodStudent;
        }
        // filter list student base on YearAmission
        public List<Student> Descending()
        {
            var filter = (from student in students
                          orderby student.YearAmission descending
                          select student).ToList();
            return filter;
        }
        // Group list student base on YearAmission
        public void YearGroup()
        {
            var filter = (from student in students
                          group student by student.YearAmission
                         );
            foreach (var group in filter)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine($"      {student.StudentId} - {student.Name}");
                }
            }
        }

    }
}
