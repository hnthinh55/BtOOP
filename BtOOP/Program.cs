using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLCB qualy = new QLCB();
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
                                string gioitinh = Console.ReadLine();
                                Console.WriteLine("Nhap DiaChi: ");
                                string DiaChi = Console.ReadLine();
                                switch (chon)
                                {
                                    case "a":
                                        {
                                            Console.WriteLine("Nhap Nganh: ");
                                            string Nganh = Console.ReadLine();
                                            CanBo cb = new Nhanvien(name, age, gioitinh, DiaChi, Nganh);
                                            qualy.ThemMoi(cb);
                                            break;
                                        }
                                    case "b":
                                        {
                                            Console.WriteLine("Nhap Bac: ");
                                            string bac = Console.ReadLine();
                                            CanBo cb = new Nhanvien(name, age, gioitinh, DiaChi, bac);
                                            qualy.ThemMoi(cb);
                                            break;
                                        }
                                    case "c":
                                        {
                                            Console.WriteLine("Nhap cong viec: ");
                                            string CongViec = Console.ReadLine();
                                            CanBo cb = new Nhanvien(name, age, gioitinh, DiaChi, CongViec);
                                            qualy.ThemMoi(cb);
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
                            Console.WriteLine("Danh sach nhan vien : ");
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
