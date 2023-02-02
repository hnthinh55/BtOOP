using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp2
{
    class Newspaper : ManageDocument
    {
        private string NgayXB { get; set; }
        public Newspaper(string iD, string nxB, int So, string ngayXB) : base(iD, nxB, So)
        {
            NgayXB = ngayXB;
        }
        public override String ToString()
        {
            return $"**ID: {ID} " +
                $" Nha xuat Ban: {NXB}" +
                 $" So ban xuat ban: {SoBanXB}" +
                  $" Ngay xuat ban: {NgayXB}"; 
        }
    }
}
