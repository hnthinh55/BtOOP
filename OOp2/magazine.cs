using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Magazine : Document
    {
        public int issueNo { get;private set; }
        public int releaseMonth { get; private set; }
        public Magazine(string iD, string nxB, int So, int issueNo, int releaseMonth) : base(iD, nxB, So)
        {
            this.issueNo = issueNo;
            this.releaseMonth = releaseMonth;
        }
        public override String ToString()
        {
            return $"**ID: {ID} \n Nha xuat Ban: {publisher} \n So ban xuat ban: {numberPublish}\n so phat hanh: {issueNo}\n thang phat hanh: {releaseMonth}";
        }
    }
}
