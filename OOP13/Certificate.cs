using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    class Certificate
    {
        public string CertificateID { get; private set; }
        public string CertificateName { get; private set;}
        public string CertificateRank { get; private set; }
        public string CertificateDate { get; private set; }
        public Certificate(string certificateID, string certificateName, string certificateRank, string certificateDate) 
        {
            CertificateID = certificateID;
            CertificateName = certificateName;
            CertificateRank = certificateRank;
            CertificateDate = certificateDate;
        }
        public Certificate() { }
    }
}
