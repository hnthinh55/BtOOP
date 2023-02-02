using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp4
{
    internal class Nguoi
    {
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public string NgheNghiep { get; set; }
        public string IdentifyCard { get; set; }
        public Nguoi() { }
        public Nguoi(string hoten, int tuoi, string ngheNghiep, string identifyCard)
        {
            Hoten = hoten;
            Tuoi = tuoi;
            NgheNghiep = ngheNghiep;
            IdentifyCard = identifyCard;
        }
        public override string ToString()
        {
            return $"Hoten: {Hoten}\n" +
                $"Tuoi: {Tuoi}\n" +
                $"Nghe nghiep: {NgheNghiep}\n" +
                $"IdentifyCard: {IdentifyCard}";
        }
    }
}
