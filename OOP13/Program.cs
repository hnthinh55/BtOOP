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
        static void Main(string[] args)
        {
            ManageEmployees manage = new ManageEmployees();
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 13");
                Console.WriteLine("1: Add employee ");
                Console.WriteLine("2: Remove employee  ");
                Console.WriteLine("3: Edit employee information ");
                Console.WriteLine("4: Search employees");
                Console.WriteLine("5: Show list employees");
                Console.WriteLine("6: Exit");
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
                                Console.WriteLine("1: Add intern");
                                Console.WriteLine("2: Add fresher");
                                Console.WriteLine("3: Add experience");
                                Console.WriteLine("Enter type of employee: ");
                                int choose = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Enter ID: ");
                                string id = Console.ReadLine();
                                Console.WriteLine("Enter fullname: ");
                                string name = Console.ReadLine();
                                bool result = Regex.IsMatch(name, @"^[a-zA-Z]+$"); ;
                                if (result != true)
                                    throw new FullNameException("Ten khong duoc chua so!!");
                                Console.WriteLine("Enter birthday: ");
                                string birthday = Console.ReadLine();
                                Console.WriteLine("Enter phone: ");
                                string phone = Console.ReadLine();
                                bool isNumber = int.TryParse(phone, out int numericValue);
                                if (isNumber != true)
                                    throw new PhoneException(phone);
                                Console.WriteLine("Enter email: ");
                                string email = Console.ReadLine();
                                if(IsValid(email)!= true)
                                    throw new EmailException("Invalid email address");
                                    Console.WriteLine("Enter number certificate employee have: ");
                                int number= Convert.ToInt32(Console.ReadLine());
                                List<Certificate> certificates = new List<Certificate>();
                                for (int j = 0; j < number; j++)
                                {
                                    Console.WriteLine("Enter certificate id:");
                                    string certificateId= Console.ReadLine();
                                    Console.WriteLine("Enter certificate Name:");
                                    string certificateName = Console.ReadLine();
                                    Console.WriteLine("Enter certificate rank:");
                                    string certificateRank = Console.ReadLine();
                                    Console.WriteLine("Enter certificate Date:");
                                    string certificateDate = Console.ReadLine();
                                    certificates.Add(new Certificate(certificateId,certificateName, certificateRank, certificateDate));
                                }
                                switch (choose)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Enter major:");
                                            string majo = Console.ReadLine();
                                            Console.WriteLine("Enter Semester");
                                            int semester = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Enter UniversityName:");
                                            string university = Console.ReadLine();
                                            Employee emp = new Intern(id, name, birthday, phone, email, choose, certificates, majo, semester, university);
                                            manage.AddEmployee(emp);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Enter GraduationDate:");
                                            string graduationDate = Console.ReadLine();
                                            Console.WriteLine("Enter GraduationRank");
                                            string graduationRank = Console.ReadLine();
                                            Console.WriteLine("Enter Education:");
                                            string education = Console.ReadLine();
                                            Employee emp = new Fresher(id, name, birthday, phone, email, choose, certificates, graduationDate, graduationRank, education);
                                            manage.AddEmployee(emp);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Enter ExpInYear:");
                                            int ExpInYear = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Enter ProSkill");
                                            string ProSkill = Console.ReadLine();
                                            Employee emp = new Experience(id, name, birthday, phone, email, choose, certificates, ExpInYear, ProSkill);
                                            manage.AddEmployee(emp);
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
                            Console.WriteLine("1: intern");
                            Console.WriteLine("2: fresher");
                            Console.WriteLine("3: experient");
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
