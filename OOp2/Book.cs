using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Book: Document
    {
        public string Author { get; private set; }
        public int NumberPage { get; private set; }
        public Book(string iD, string nxB, int So, string author,int numberPage) : base(iD, nxB, So)
        {
            this.Author= author;
            this.NumberPage = numberPage;
        }
        //public override void Input()
        //{
        //    Console.WriteLine("Nhap ID: ");
        //    string id = Console.ReadLine();
        //    Console.WriteLine("Nhap nha xuat ban: ");
        //    string nxb = Console.ReadLine();
        //    Console.WriteLine("Nhap so Ban xuat ban: ");
        //    int soBanXB = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Nhap so phat hanh: ");
        //    string TacGia = Console.ReadLine();
        //    Console.WriteLine("Nhap thang phat hanh: ");
        //    int thangPH = Convert.ToInt32(Console.ReadLine());
        //}
        public override String ToString()
        {
            return $"**ID: {ID} \n Nha xuat Ban: {Publisher} \n So ban xuat ban: {NumberPublish}\n Tac gia: {Author}\n thang phat hanh: {NumberPage}";
        }
    }
}
