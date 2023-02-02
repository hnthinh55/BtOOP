using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Customer
    {
        public string fullname { get; private set; }
        public int age { get; private set; }
        public string identifyCard { get; private set; }
        public Room room { get; private set; }
        public int numberRent { get; private set; }
        public Customer() { }
        public Customer(string fullname, int age, string identifyCard, int numberRent, Room _room)
        {
            this.fullname = fullname;
            this.age = age;
            this.identifyCard = identifyCard;
            this.numberRent = numberRent;
            room = _room;
        }
        public override String ToString()
        {
            return $"Khach hang: {fullname}\n Tuoi: {age}\n IdentifyCard: {identifyCard}\n Phong: {room.ToString()}\n So Ngay Thue:{numberRent}\n";
        }
    }
}
