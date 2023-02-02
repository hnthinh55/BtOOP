using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp2
{
    class magazine : ManageDocument
    {
        private int SoPhatHanh { get; set; }
        private int ThangPhatHanh { get; set; }
        public magazine(string iD, string nxB, int So, int soPhatHanh, int thangPH) : base(iD, nxB, So)
        {
            SoPhatHanh = soPhatHanh;
            ThangPhatHanh = thangPH;
        }
        public override String ToString()
        {
            return $"**ID: {ID} " +
                $" Nha xuat Ban: {NXB}" +
                 $" So ban xuat ban: {SoBanXB}" +
                  $" so phat hanh: {SoPhatHanh}" +
                   $" thang phat hanh: {ThangPhatHanh}";
        }
    }
}
