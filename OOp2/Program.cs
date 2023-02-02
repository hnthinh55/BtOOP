using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManageDocument manage = new ManageDocument();
            while (true)
            {
                Console.WriteLine("Wellcome to Excercise 1");
                Console.WriteLine("1: De them moi tai lieu ");
                Console.WriteLine("2: De xoa tai lieu ");
                Console.WriteLine("3: De tim kiem tai lieu");
                Console.WriteLine("4: Hien thi thong tin theo danh sach");
                Console.WriteLine("5: Thoat khoi chuong trinh");
                Console.Write("Nhap chuc nang ban muon su dung: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.Write("Nhap so luong sach ban muon them: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("a: De them moi sach");
                                Console.WriteLine("b: De them moi tap chi");
                                Console.WriteLine("c: De them moi bao");
                                Console.Write("Nhap chuc nang ban muon su dung: ");
                                string chon = Console.ReadLine();
                                Console.WriteLine("Nhap ID: ");
                                string id = Console.ReadLine();
                                Console.WriteLine("Nhap nha xuat ban: ");
                                string publisher = Console.ReadLine();
                                Console.WriteLine("Nhap so Ban xuat ban: ");
                                int numberPublish = Convert.ToInt32(Console.ReadLine());
                                switch (chon)
                                {
                                    case "a":
                                        {
                                            Console.WriteLine("Nhap so tac gia: ");
                                            string author = Console.ReadLine();
                                            Console.WriteLine("Nhap so trang: ");
                                            int numberPage = Convert.ToInt32(Console.ReadLine());
                                            Document document = new Book(id, publisher, numberPublish, author, numberPage);
                                            manage.AddDocument(document);
                                            break;
                                        }
                                    case "b":
                                        {
                                            Console.WriteLine("Nhap So Phat Hanh: ");
                                            int issueNo = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Nhap  Thang Phat Hanh: ");
                                            int releaseMonth = Convert.ToInt32(Console.ReadLine());
                                            Document document = new Magazine(id, publisher, numberPublish, issueNo, releaseMonth);
                                            manage.AddDocument(document);
                                            break;
                                        }
                                    case "c":
                                        {
                                            Console.WriteLine("Nhap so ngay xuat ban: ");
                                            string releaseDate = Console.ReadLine();
                                            Document document = new Newspaper(id, publisher, numberPublish, releaseDate);
                                            manage.AddDocument(document);
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
                            Console.WriteLine("Moi ban nhap ma Id cua tai lieu can xoa: ");
                            string ten = Console.ReadLine();
                            var check = manage.RemoveDocument(ten);
                            if(check == true)
                            {
                                Console.WriteLine("xoa thanh cong");
                            }
                            else
                            {
                                Console.WriteLine("khong the xoa, hay kiem tra lai id ban dien");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Moi ban nhap danh muc can tim: ");
                            Console.WriteLine("1: sach");
                            Console.WriteLine("2: tap chi");
                            Console.WriteLine("3: bao");
                            int ten = Convert.ToInt16(Console.ReadLine());
                            switch (ten)
                            {
                                case 1:
                                    {
                                        manage.SearchDocument("Sach");
                                        break;
                                        
                                    }
                                case 2:
                                    {
                                        manage.SearchDocument("TapChi");
                                        break;
                                    }
                                case 3:
                                    {
                                        manage.SearchDocument("Bao");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("khong ton tai danh muc ban muon tim");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Danh sach nhan vien : ");
                            manage.ShowList();
                            break;
                        }
                    case 5:
                        {
                            manage.EXIT();
                            break;
                        }
                }
            }
        }
    }
}
