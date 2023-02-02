using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp4
{
    internal class HoGiaDinh
    {
        public List<Nguoi> nguois { get; set; }
        public string SoNha { get; set; }
        public HoGiaDinh(List<Nguoi> hoGiaDinh, string sonha)
        {
            nguois = hoGiaDinh;
            SoNha = sonha;
        }
        public void printPerson()
        {
            Console.WriteLine("***Ho Gia Dinh:");
            foreach (var person in nguois)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("Dia chi ho gia dinh: "+SoNha);
        }

    }
}
