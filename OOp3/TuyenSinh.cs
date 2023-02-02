using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp3
{
    internal class TuyenSinh
    {
        private IList<Student> students;
        public TuyenSinh()
        {
            students = new List<Student>();
        }
        public void ThemMoi(Student manage)
        {
            students.Add(manage);
        }
        public List<Student> TimKiem(string tensearch)
        {
            return (from list in students
                        where list.Id == tensearch
                        select list).ToList();
        }
        public void HienThi()
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
