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

namespace OOP13
{
    internal class Program
    {
        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        private static void CheckName(string name) {
            bool result = Regex.IsMatch(name, @"^[a-zA-Z]+$"); ;
            if (result != true)
                throw new FullNameException("Ten khong duoc chua so!!");
        }
        private static void CheckPhone(string phone)
        {
            bool isNumber = int.TryParse(phone, out int numericValue);
            if (isNumber != true)
                throw new PhoneException(phone);
        }
        private static void CheckEmail(string email)
        {
            if (IsValid(email) != true)
                throw new EmailException("Invalid email address");
        }
        private static void CheckInfo(Employee employee)
        {
            CheckName(employee.Name);
            CheckPhone(employee.Phone);
            CheckEmail(employee.Email);
        }
        static void Main(string[] args)
        {
            ManageEmployees manage = new ManageEmployees();
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 13\n1: Add employee \n2: Remove employee\n3: Edit employee information\n4: Search employees\n5: Show list employees\n6: Exit");
                Console.Write("Enter the function you choose: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
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
    }
}
