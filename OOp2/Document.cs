using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Document
    {
        public string ID { get; set; }
        public string publisher { get; set; }
        public int numberPublish { get; set; }
        public Document(string iD, string publisher, int numberPublish)
        {
            ID = iD;
            this.publisher = publisher;
            this.numberPublish = numberPublish;
        }
        public Document() { }
    }
}
