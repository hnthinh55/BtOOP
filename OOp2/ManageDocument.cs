using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp2
{
    internal class ManageDocument
    {
        public string ID { get; set; }
        public string NXB { get; set; }
        public int SoBanXB { get; set; }
        public ManageDocument(string iD, string nSB, int soBanSB)
        {
            ID = iD;
            NXB = nSB;
            SoBanXB = soBanSB;
        }
        public ManageDocument() { }
    }
}
