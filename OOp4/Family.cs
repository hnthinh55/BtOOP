using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Family
    {
        public List<Person> persons { get; set; }
        public string address { get; set; }
        public Family(List<Person> persons, string address)
        {
            this.persons = persons;
            this.address = address;
        }
        public void printPerson()
        {
            Console.WriteLine("***Ho Gia Dinh:");
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("Dia chi ho gia dinh: "+address);
        }

    }
}
