using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Customer
    {
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public string IdentifyCard { get; set; }
        public Room room { get; set; }
        public int SoNgayThue { get; set; }
        public Customer() { }
        public Customer(string hoten, int tuoi, string indentifyCard, int soNgayThue, Room _room)
        {
            Hoten = hoten;
            Tuoi = tuoi;
            IdentifyCard = indentifyCard;
            SoNgayThue = soNgayThue;
            room = _room;
        }
        public override String ToString()
        {
            return $"Khach hang: {Hoten}\n" +
                $"Tuoi: {Tuoi}\n" +
                $"IdentifyCard: {IdentifyCard}\n" +
                $"Phong: {room.ToString()}\n" +
                $"So Ngay Thue:{SoNgayThue}\n";
        }
    }
}
