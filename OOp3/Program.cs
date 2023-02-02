using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TuyenSinh qualy = new TuyenSinh();
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 3");
                Console.WriteLine("1: De them moi sinh vien");
                Console.WriteLine("2: De tim kiem ");
                Console.WriteLine("3: Hien thi thong tin");
                Console.WriteLine("4: Thoat khoi chuong trinh");
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
                                Console.WriteLine("a: De them moi Hoc sinh khoi A");
                                Console.WriteLine("b: De them moi Hoc sinh khoi B");
                                Console.WriteLine("c: De them moi Hoc sinh khoi C");
                                Console.Write("Nhap chuc nang ban muon su dung: ");
                                string chon = Console.ReadLine();
                                Console.WriteLine("Nhap ID: ");
                                string id = Console.ReadLine();
                                Console.WriteLine("Nhap Ten: ");
                                string name =Console.ReadLine();
                                Console.WriteLine("Nhap Dia chi: ");
                                string address = Console.ReadLine();
                                Console.WriteLine("Nhap Khu Vuc Uu Tien: ");
                                string prio = Console.ReadLine();
                                switch (chon)
                                {
                                    case "a":
                                        {
                                            Student cb = new ClassA(id, name, address, prio);
                                            qualy.ThemMoi(cb);
                                            break;
                                        }
                                    case "b":
                                        {
                                            Student cb = new ClassB(id, name, address, prio);
                                            qualy.ThemMoi(cb);
                                            break;
                                        }
                                    case "c":
                                        {
                                            Student cb = new ClassC(id, name, address, prio);
                                            qualy.ThemMoi(cb);
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Khong ton tai Khoi thi nay, moi ban chon lai");
                                            break;
                                        }
                                }

                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Moi ban nhap Ten cua sinh vien muon tim: ");
                            string ten = Console.ReadLine();
                            var search = qualy.TimKiem(ten);
                            foreach (var t in search)
                            {
                                Console.WriteLine(t.ToString());
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Danh sach Sinh vien : ");
                            qualy.HienThi();
                            break;
                        }
                    case 4:
                        {
                            qualy.EXIT();
                            break;
                        }
                }
            }
        }
    }
}
