using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Room
    {
        public string LoaiPhong { get; set; }
        public double Gia { get; set; } 
        public Room(string loaiPhong, double gia)
        {
            LoaiPhong = loaiPhong;
            Gia = gia;
        }
        public Room() { }
        public override string ToString()
        {
            return $"Phong: {LoaiPhong}" +
                $", Gia: {Gia}";
        }
    }
}
