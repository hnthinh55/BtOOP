using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class KhachSan
    {
        private IList<Customer> khachThues;
        public KhachSan() {
            khachThues = new List<Customer>();
        }
        public void Add(Customer nguoi)
        {
            khachThues.Add(nguoi);
        }
        public bool Remove(string id)
        {
            var check = from list in khachThues
                        where list.IdentifyCard == id
                        select list;
            if (check.Count() > 0)
            {
                khachThues.Remove((from list in khachThues
                                  where list.IdentifyCard == id
                                   select list).FirstOrDefault());
                return true;
            }
            return false;
        }
        public double RentPrice(string id) {
            var nguoiThue = khachThues.Where(khach => khach.IdentifyCard == id).FirstOrDefault();
            if(nguoiThue==null )
            {
                Console.WriteLine("Khong ton tai nguoi nay");
                return 0;
            }
            return nguoiThue.room.Gia * nguoiThue.SoNgayThue;
        }
        public void Ouput() {
            Console.WriteLine("**Danh sach khach thue tai khach san: ");
           foreach (var khach in khachThues)
            {
                Console.WriteLine(khach.ToString());
            }
        }
        public void EXIT ()
        {
            Environment.Exit(0);
        }
    }
}
