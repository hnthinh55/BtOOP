using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP15
{
    internal class ManageDepartment
    {
        public IList<Department> departments;
        public ManageDepartment()
        {
            departments = new List<Department>();
        }
        //Add new department
        public void AddDepart(Department department)
        {
            departments.Add(department);
        }
        // Remove department from thi list
        public void RemoveDepart(string department)
        {
            var check = from list in departments
                        where list.DepartName.Contains(department)
                        select list;
            if (check.Count() > 0)
            {
                departments.Remove(check.FirstOrDefault());
                Console.WriteLine("Remove successfull");
            }
            else
            {
                Console.WriteLine("Invalid employee");
            }
        }
        //Show all department
        public void ShowDeparts()
        {
            foreach(var department in departments)
            {
                department.ShowStudents();
            }
        }
        public void SemesterGPA(string semester)
        {
            foreach (var department in departments)
            {
                foreach (KeyValuePair<string, double[]> kvp in department.ListSemesterGPA(semester))
                    Console.WriteLine("Student: {0}, Value: {1}", kvp.Key, string.Join(",", kvp.Value));
            }
        }
        //Show list Inservice student
        public void ShowListInservice()
        {
            Console.WriteLine("List Inservice student: ");
            foreach (var department in departments)
            {
                Console.WriteLine($"  Department: {department.DepartName}\r\n [");
                foreach(var student in department.ListInservice())
                {
                    Console.WriteLine(student.Name);
                }
                Console.WriteLine(" ]");
            }
        }
        public void HigestGPA()
        {
            Console.WriteLine("Student have highest GPA: ");
            foreach (var department in departments)
            {
                Console.WriteLine($"  Department: {department.DepartName}\r\n [");
                Student student = department.MaxGPA();
                student.OutPutInfo();
                Console.WriteLine("]");
            }
        }
        //Student have highest semester GPA
        public void HigestSemesterGPA()
        {
            Console.WriteLine("Student have highest semester GPA: ");
            foreach (var department in departments)
            {
                Console.WriteLine($"  Department: {department.DepartName}\r\n [");
                Student student = department.MaxSemesterGPA();
                student.OutPutInfo();
                Console.WriteLine("]");
            }
        }
        // List student filter base on year
        public void ListFilter()
        {
            Console.WriteLine("List student filter base on year: ");
            foreach (var department in departments)
            {
                Console.Write($"**Department: {department.DepartName}\r\n [");
                foreach (var student in department.Descending())
                {
                    Console.WriteLine($"Year: {student.YearAmission} -- Name: {student.Name}");
                }
                Console.WriteLine("]");
            }
        }
        // Group student filter base on year
        public void GroupYear()
        {
            Console.WriteLine("Group student filter base on year: ");
            foreach (var department in departments)
            {
                Console.Write($"  Department: {department.DepartName}\r\n [");
                department.YearGroup();
                Console.WriteLine(" ]");
            }
        }
        //Count regular student in each department
        public void RegularStudents()
        {
            Console.WriteLine("Regular student in each department");
            foreach (var department in departments)
            {
                Console.Write($"  Department: {department.DepartName} have {department.CountRegular()} regular student");
            }
        }

    }
}
