using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Room
    {
        public string Category { get; set; }
        public double Price { get; set; } 
        public Room(string category, double price)
        {
            this.Category = category;
            this.Price = price;
        }
        public Room() { }
        public override string ToString()
        {
            return $"Phong: {Category}, Gia: {Price}";
        }
    }
}
