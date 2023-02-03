using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Person
    {
        public string Fullname { get; private set; }
        public int Age { get; private set; }
        public string Job { get; private set; }
        public string IdentifyCard { get; private set; }
        public Person() { }
        public Person(string fullname, int age, string job, string identifyCard)
        {
            this.Fullname = fullname;
            this.Age = age;
            this.Job = job;
            this.IdentifyCard = identifyCard;
        }
        public override string ToString()
        {
            return $" Hoten: {Fullname}\n Tuoi: {Age}\n Nghe nghiep: {Job}\n IdentifyCard: {IdentifyCard}";
        }
    }
}
