using System;

namespace OOP15
{
    internal class Program
    {
        public static void AddStudentts(Department department)
        {
            Console.WriteLine("input number student");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("1. Regular student\n2. In service student");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    Student student = new Student();
                    student.InputInfo();
                    department.AddStudent(student);
                }
                else if (choose == 2)
                {
                    Student student = new InServiceStudent();
                    student.InputInfo();
                    department.AddStudent(student);
                }
                else
                    throw new Exception("Invalid studetn type");
            }
        }

        
        public static void AddDeparts(ManageDepartment manage)
        {
            Console.WriteLine("input number department");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Department name:");
                string departName = Console.ReadLine();
                Department department = new Department(departName);
                AddStudentts(department);
                manage.AddDepart(department);
            }
            
        }

        public static void RunProject(ManageDepartment manage)
        {
            AddDeparts(manage);
            //manage.ShowDeparts();
            manage.SemesterGPA("hocky1"); // GET semester GPA base on input semester
            //manage.ShowListInservice();
            //manage.HigestGPA();
            //manage.HigestSemesterGPA();
            //manage.ListFilter();
            //manage.GroupYear();
            manage.RegularStudents();

        }
        static void Main(string[] args)
        {
            ManageDepartment manage = new ManageDepartment();
            RunProject(manage);
            Console.ReadLine();
        }
    }
}
