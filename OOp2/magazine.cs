using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Magazine : Document
    {
        public int IssueNo { get;private set; }
        public int ReleaseMonth { get; private set; }
        public Magazine(string iD, string nxB, int So, int issueNo, int releaseMonth) : base(iD, nxB, So)
        {
            this.IssueNo = issueNo;
            this.ReleaseMonth = releaseMonth;
        }
        public override String ToString()
        {
            return $"**ID: {ID} \n Nha xuat Ban: {Publisher} \n So ban xuat ban: {NumberPublish}\n so phat hanh: {IssueNo}\n thang phat hanh: {ReleaseMonth}";
        }
    }
}
