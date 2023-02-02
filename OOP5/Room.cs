using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Room
    {
        public string category { get; set; }
        public double price { get; set; } 
        public Room(string category, double price)
        {
            this.category = category;
            this.price = price;
        }
        public Room() { }
        public override string ToString()
        {
            return $"Phong: {category}, Gia: {price}";
        }
    }
}
