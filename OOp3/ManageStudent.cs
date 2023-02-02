using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ManageStudent
    {
        private IList<Student> students;
        public ManageStudent()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student manage)
        {
            students.Add(manage);
        }
        public List<Student> SearchStudent(string id)
        {
            return (from list in students
                        where list.id == id
                        select list).ToList();
        }
        public void Show()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void EXIT()
        {
            Environment.Exit(0);
        }
    }
}
