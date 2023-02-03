using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    internal class ManageStudent
    {
        private IList<Student> _students;
        public  ManageStudent() {
                _students= new List<Student>();
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public void TwentyAge()
        {
            var list = (from st in _students
                       where st.Age == 20
                       select st).ToList();
            if(list!= null)
            {
                foreach(var student in list)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            else
            {
                Console.WriteLine("Khong ton tai hoc sinh 20 tuoi");
            }
        }
        public void AtDaNang()
        {
            string[] temporary = { "DN","Da Nang" };
            var list = (from st in _students
                       where st.Age == 23 && (st.Address.Contains(temporary[0].ToLower())|| st.Address.Contains(temporary[1].ToLower()))
                       select st).ToList();
            if(list!= null )
            {
                foreach (var student in list)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            else
            {
                Console.WriteLine("Khong ton tai hoc sinh 23 tuoi o da nang");
            }
        }
        public void LogOut()
        {
            Environment.Exit(0);
        }
    }
}
