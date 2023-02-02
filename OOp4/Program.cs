using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KhuPho block = new KhuPho();
            Console.WriteLine("Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Nhap dia chi nha");
                string address = Console.ReadLine();
                List<Nguoi> nguois= new List<Nguoi>();
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
                    nguois.Add(new Nguoi (name, age, job, identifyCard));
                }
                block.ThemHoGiaDinh(new HoGiaDinh(nguois, address));
            }
            foreach (var element in block)
            {
                element.printPerson();
            }
            Console.ReadLine();
        }
    }
}
