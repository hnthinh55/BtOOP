using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Customer
    {
        public string Fullname { get; private set; }
        public int Age { get; private set; }
        public string IdentifyCard { get; private set; }
        public Room Room { get; private set; }
        public int NumberRent { get; private set; }
        public Customer() { }
        public Customer(string fullname, int age, string identifyCard, int numberRent, Room _room)
        {
            this.Fullname = fullname;
            this.Age = age;
            this.IdentifyCard = identifyCard;
            this.NumberRent = numberRent;
            Room = _room;
        }
        public override String ToString()
        {
            return $"Khach hang: {Fullname}\n Tuoi: {Age}\n IdentifyCard: {IdentifyCard}\n Phong: {Room.ToString()}\n So Ngay Thue:{NumberRent}\n";
        }
    }
}
