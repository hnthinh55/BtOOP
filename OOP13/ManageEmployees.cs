using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    internal class ManageEmployees
    {
        private IList<Employee> employees;
        public ManageEmployees()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Add successfull!");
        }
        public void RemoveEmployee(string id)
        {
            var check = from list in employees
                        where list.Id == id
                        select list;
            if (check.Count() > 0)
            {
                employees.Remove(check.FirstOrDefault());
                Console.WriteLine("Remove successfull");
            }
            else
            {
                Console.WriteLine("Invalid employee");
            }
        }
        public void EditEmployee (string id)
        {
            var check = (from list in employees
                        where list.Id == id
                        select list).FirstOrDefault();
            if (check != null)
            {
                Console.WriteLine("Please choose the field you want");
                string field = Console.ReadLine();
                Console.WriteLine("Please add the value you want to change");
                string value = Console.ReadLine();
                int index = employees.IndexOf(check);
                employees[index].UpdateInfo(field, value);
            }
            else
                Console.WriteLine("Can't find employee");
        }
        public void Show()
        {
            foreach(var emp in employees)
            {
                emp.ShowInfo();
            }
        }
        public void ShowIntern()
        {
            var interns = (from list in employees
                           where list.GetType() ==typeof(Intern)
                           select list
                           ).ToList();
            foreach (var intern in interns)
            {
                intern.ToString();
            }
        }
        public void ShowFresher()
        {
            var interns = (from list in employees
                           where list.GetType() == typeof(Fresher)
                           select list
                           ).ToList();
            foreach (var intern in interns)
            {
                intern.ToString();
            }
        }
        public void ShowExperience()
        {
            var interns = (from list in employees
                           where list.GetType() == typeof(Experience)
                           select list
                           ).ToList();
            foreach (var intern in interns)
            {
                intern.ToString();
            }
        }
    }
}
