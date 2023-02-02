using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerOfficer manage = new ManagerOfficer();
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 1");
                Console.WriteLine("1: De them moi can bo");
                Console.WriteLine("2: De tim kiem can bo");
                Console.WriteLine("3: Hien thi thong tin  theo danh sach");
                Console.WriteLine("4: Thoat khoi chuong trinh");
                Console.Write("Nhap chuc nang ban muon su dung: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.Write("Nhap so luong can bo ban muon them: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("a: De them moi Ky su");
                                Console.WriteLine("b: De them moi Cong Nhan");
                                Console.WriteLine("c: De them moi Nhan vien");
                                Console.Write("Nhap chuc nang ban muon su dung: ");
                                string chon = Console.ReadLine();
                                Console.WriteLine("Nhap Hoten: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Nhap Tuoi: ");
                                int age = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Nhap GioiTinh: ");
                                string gender = Console.ReadLine();
                                Console.WriteLine("Nhap DiaChi: ");
                                string address = Console.ReadLine();
                                switch (chon)
                                {
                                    case "a":
                                        {
                                            Console.WriteLine("Nhap Nganh: ");
                                            string major = Console.ReadLine();
                                            Officer cb = new Engineer(name, age, gender, address, major);
                                            manage.Add(cb);
                                            break;
                                        }
                                    case "b":
                                        {
                                            Console.WriteLine("Nhap Bac: ");
                                            int rank = Convert.ToInt16(Console.ReadLine());
                                            Officer cb = new Worker(name, age, gender, address, rank);
                                            manage.Add(cb);
                                            break;
                                        }
                                    case "c":
                                        {
                                            Console.WriteLine("Nhap cong viec: ");
                                            string task = Console.ReadLine();
                                            Officer cb = new Staff(name, age, gender, address, task);
                                            manage.Add(cb);
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Khong ton tai chuc vu nay, moi ban chon lai");
                                            break;
                                        }
                                }

                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Moi ban nhap Ten cua nhan vien muon tim: ");
                            string name = Console.ReadLine();
                            var search = manage.Search(name);
                            if (search != null)
                            {
                                foreach (var t in search)
                                {
                                    Console.WriteLine(t.ToString());
                                }
                            }
                            else
                                Console.WriteLine("Khong tim thay nhan vien");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Danh sach nhan vien : ");
                            manage.Show();
                            break;
                        }
                    case 4:
                        {
                            manage.EXIT();
                            break;
                        }
                }
            }
        }
    }
}
