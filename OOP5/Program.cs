﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KhachSan qualy = new KhachSan();
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 5");
                Console.WriteLine("1: De them moi thong tin khach hang");
                Console.WriteLine("2: De xoa thong tin khach hang");
                Console.WriteLine("3: De tinh tien thue phong cua khach hang");
                Console.WriteLine("4: Hien thi thong tin  theo danh sach");
                Console.WriteLine("5: Thoat khoi chuong trinh");
                Console.Write("Nhap chuc nang ban muon su dung: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                                Console.WriteLine("Nhap Hoten: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Nhap Tuoi: ");
                                int age = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Nhap identify card ");
                                string iden = Console.ReadLine();
                                Console.WriteLine("Chon loai phong: ");
                                Console.WriteLine("a: Loai A");
                                Console.WriteLine("b: Loai B");
                                Console.WriteLine("c: Loai C");
                                string chon = Console.ReadLine();
                                Console.WriteLine("Nhap so ngay thue: ");
                                int num = Convert.ToInt16(Console.ReadLine());
                                Room[] tmp =
                                {
                                    new Room("A",500.0),
                                    new Room("B",500.0),
                                    new Room("C",500.0),
                                };
                            if (chon.ToLower() == "a")
                            {
                                qualy.Add(new Customer(name, age, iden, num, tmp[0]));
                            }
                            else if (chon.ToLower() == "b")
                            {
                                qualy.Add(new Customer(name, age, iden, num, tmp[1]));
                            }
                            else if (chon.ToLower() == "c")
                            {
                                qualy.Add(new Customer(name, age, iden, num, tmp[2]));
                            }
                            else
                            {
                                Console.WriteLine("Khong co loai phong nhu vay");
                            }

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Moi ban nhap ma khach hang: ");
                            string id = Console.ReadLine();
                            var search = qualy.Remove(id);
                            if(search== true)
                            {
                                Console.WriteLine("xoa thanh cong");
                            }
                            else
                            {
                                Console.WriteLine("xoa that bai");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Moi ban nhap ma khach hang: ");
                            string id = Console.ReadLine();
                            Console.WriteLine("Tien thua cua khach la: "+qualy.RentPrice(id));
                            break;
                        }
                    case 4:
                        {
                            qualy.Ouput();
                            break;
                        }
                    case 5:
                        {
                            qualy.EXIT();
                            break;
                        }
                }
            }
        }
    }
}