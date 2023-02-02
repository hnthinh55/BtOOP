using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int Tuoi  { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public CanBo(string hoTen, int tuoi, string gioiTinh, string diaChi)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }
        
    }
    class KySu : CanBo
    {
        private string Nganh { get; set; }
        public KySu(string hoTen, int tuoi, string gioiTinh, string diaChi, string nganh) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            Nganh = nganh;
        }
        public override String ToString()
        {
            return $"**Hoten: {HoTen} " +
                $" Tuoi: {Tuoi}" +
                 $" gioiTinh: {GioiTinh}" +
                  $" diaChi: {DiaChi}" +
                   $" nganh: {Nganh}";
        }

    }
    class CongNhan : CanBo
    {
        private int Bac { get; set; }
        public CongNhan(string hoTen, int tuoi, string gioiTinh, string diaChi, int bac) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            Bac = bac;
        }
        public override String ToString()
        {
            return $"**Hoten: {HoTen} " +
                $" Tuoi: {Tuoi}" +
                 $" gioiTinh: {GioiTinh}" +
                  $" diaChi: {DiaChi}" +
                   $" bac: {Bac}";
        }

        
    }
    class Nhanvien : CanBo
    {
        private string CongViec { get; set; }
        public Nhanvien(string hoTen, int tuoi, string gioiTinh, string diaChi, string congViec) : base(hoTen, tuoi, gioiTinh, diaChi)
        {
            CongViec = congViec;
        }
        public override String ToString()
        {
            return $"**Hoten: {HoTen} " +
                $" Tuoi: {Tuoi}" +
                 $" gioiTinh: {GioiTinh}" +
                  $" diaChi: {DiaChi}" +
                   $" congViec: {CongViec}";
        }
    }
}
