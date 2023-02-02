using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Person
    {
        public string fullname { get; private set; }
        public int age { get; private set; }
        public string job { get; private set; }
        public string identifyCard { get; private set; }
        public Person() { }
        public Person(string fullname, int age, string job, string identifyCard)
        {
            this.fullname = fullname;
            this.age = age;
            this.job = job;
            this.identifyCard = identifyCard;
        }
        public override string ToString()
        {
            return $" Hoten: {fullname}\n Tuoi: {age}\n Nghe nghiep: {job}\n IdentifyCard: {identifyCard}";
        }
    }
}
