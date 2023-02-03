using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManageStudent manage = new ManageStudent();
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 6");
                Console.WriteLine("1: De them moi sinh vien");
                Console.WriteLine("2: Hien thi thong tin sinh vien co tuoi = 20");
                Console.WriteLine("3: Hien thi thong tin sinh vien co tuoi = 23 va o Da Nang");
                Console.WriteLine("4: De thoat chuong trinh");
                Console.Write("Nhap chuc nang ban muon su dung: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.Write("Nhap so luong sinh vien ban muon them: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("Nhap Ten: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Nhap Tuoi");
                                int age = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Nhap Dia chi: ");
                                string address = Console.ReadLine();
                                Student cb = new Student(name,age, address);
                                manage.AddStudent(cb);
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Danh sach Sinh vien 20 tuoi : ");
                            manage.TwentyAge();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Danh sach Sinh vien 23 tuoi va song tai Da Nang : ");
                            manage.AtDaNang();
                            break;
                        }
                    case 4:
                        {
                            manage.LogOut();
                            break;
                        }
                }
            }
        }
    }
}
