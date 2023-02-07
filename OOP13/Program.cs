using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using OOP13.Exceptions;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Globalization;

namespace OOP13
{
    internal class Program
    {
        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        // Check Name exception
        private static void CheckName(string name) {
            if (!String.IsNullOrEmpty(name) ){
                bool result = Regex.IsMatch(name, @"^[a-zA-Z]+$"); ;
                if (result != true)
                    throw new FullNameException("Name can not contains number!!");
            }
            else
            {
                throw new FullNameException("Name can not empty");
            }
        }
        // Check Phone exception
        private static void CheckPhone(string phone)
        {
            if (!String.IsNullOrEmpty(phone))
            {
                bool isNumber = int.TryParse(phone, out int numericValue);
                if (isNumber != true)
                throw new PhoneException($"Phone is wrong: {phone}");
            }
            else
            {
                throw new PhoneException("Phone can not empty");
            }
        }
        // Check Email exception
        private static void CheckEmail(string email)
        {
            if (!String.IsNullOrEmpty(email))
            {
                if (IsValid(email) != true)
                    throw new EmailException("Invalid email address");
            }
            else
            {
                throw new EmailException("Email can not empty");
            }
        }
        //Check day of birth
        private static void CheckBirthDay(string birthday)
        {
            if (!String.IsNullOrEmpty(birthday))
            {
                DateTime dt;
                bool checkDay= DateTime.TryParseExact(birthday,"dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt) ;
                if (checkDay != true)
                    throw new BithdayException(@"Not correct format (dd/MM/yyyy)");
            }
            else
            {
                throw new BithdayException("BirthDay can not empty");
            }
        }
        //Check Information exception  
        private static void CheckInfo(Employee employee)
        {
            CheckName(employee.Name);
            CheckPhone(employee.Phone);
            CheckEmail(employee.Email);
            CheckBirthDay(employee.BirthDay);
        }
        //Add employees
        public static void AddEmployees(ManageEmployees manage)
        {
            Console.Write("Enter number employee to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("1: Add intern\n2: Add fresher \n3: Add experience");
                int choose = Convert.ToInt16(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Employee intern = new Intern();
                            intern.InputInfo();
                            CheckInfo(intern);
                            manage.AddEmployee(intern);
                            break;
                        }
                    case 2:
                        {
                            Employee fresher = new Fresher();
                            fresher.InputInfo();
                            CheckInfo(fresher);
                            manage.AddEmployee(fresher);
                            break;
                        }
                    case 3:
                        {
                            Employee experience = new Experience();
                            experience.InputInfo();
                            CheckInfo(experience);
                            manage.AddEmployee(experience);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid type of employee");
                            break;
                        }
                }
            }
        }
        //Show employees base on type of employee
        public static void ShowType(ManageEmployees manage)
        {
            Console.WriteLine("Enter employee type: ");
            Console.WriteLine("1: intern\n2: fresher\n3: experient");
            int ten = Convert.ToInt16(Console.ReadLine());
            switch (ten)
            {
                case 1:
                    {
                        manage.ShowIntern();
                        break;

                    }
                case 2:
                    {
                        manage.ShowFresher();
                        break;
                    }
                case 3:
                    {
                        manage.ShowExperience();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid employee type");
                        break;
                    }
            }  
        }
        public static void RunProject(ManageEmployees manage)
        {
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 13\n1: Add employee \n2: Remove employee\n3: Edit employee information\n4: Search employees\n5: Show list employees\n6: Exit");
                Console.Write("Enter the function you choose: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            AddEmployees(manage);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter emplyee id: ");
                            string id = Console.ReadLine();
                            manage.RemoveEmployee(id);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter emplyee id: ");
                            string id = Console.ReadLine();
                            manage.EditEmployee(id);
                            break;
                        }
                    case 4:
                        {
                            ShowType(manage);
                            break;
                        }
                    case 5:
                        {
                            manage.Show();
                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            ManageEmployees manage = new ManageEmployees();
            RunProject( manage);
            Console.ReadLine();
        }
    }
}
