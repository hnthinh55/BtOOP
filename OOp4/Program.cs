using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            Console.WriteLine("Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Nhap dia chi nha");
                string address = Console.ReadLine();
                List<Person> persons= new List<Person>();
                Console.WriteLine("Nhap so nguoi trong gia dinh");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int j=0; j<num; j++)
                {
                    Console.WriteLine("Ho ten:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Tuoi: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nghe nghiep: ");
                    string job = Console.ReadLine();
                    // tu dong tao so CMND
                    string identifyCard = Guid.NewGuid().ToString();
                    persons.Add(new Person (name, age, job, identifyCard));
                }
                area.AddFamily(new Family(persons, address));
            }
            foreach (var element in area)
            {
                element.printPerson();
            }
            Console.ReadLine();
        }
    }
}
