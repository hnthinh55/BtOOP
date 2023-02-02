using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp2
{
    class Book: ManageDocument
    {
        private string TacGia { get; set; }
        private int SoTrang { get; set; }
        public Book(string iD, string nxB, int So, string tacGia,int soTrang) : base(iD, nxB, So)
        {
            TacGia= tacGia;
            SoTrang = soTrang;
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
            return $"**ID: {ID} " +
                $" Nha xuat Ban: {NXB}" +
                 $" So ban xuat ban: {SoBanXB}" +
                  $" Tac gia: {TacGia}" +
                   $" thang phat hanh: {SoTrang}";
        }
    }
}
