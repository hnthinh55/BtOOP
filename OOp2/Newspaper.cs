using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Newspaper : Document
    {
        public string releaseDate { get; private set; }
        public Newspaper(string iD, string nxB, int So, string releaseDate) : base(iD, nxB, So)
        {
            this.releaseDate = releaseDate;
        }
        public override String ToString()
        {
            return $"**ID: {ID} \n Nha xuat Ban: {publisher}\n So ban xuat ban: {numberPublish}\n Ngay xuat ban: {releaseDate}"; 
        }
    }
}
