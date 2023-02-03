using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Hotel
    {
        private IList<Customer> _customers;
        public Hotel() {
            _customers = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }
        public bool Remove(string id)
        {
            var check = from list in _customers
                        where list.IdentifyCard == id
                        select list;
            if (check.Count() > 0)
            {
                _customers.Remove(check.FirstOrDefault());
                return true;
            }
            return false;
        }
        public double RentPrice(string id) {
            var nguoiThue = _customers.Where(khach => khach.IdentifyCard == id).FirstOrDefault();
            if(nguoiThue==null )
            {
                Console.WriteLine("Khong ton tai nguoi nay");
                return 0;
            }
            return nguoiThue.Room.Price * nguoiThue.NumberRent;
        }
        public void Ouput() {
            Console.WriteLine("**Danh sach khach thue tai khach san: ");
           foreach (var khach in _customers)
            {
                Console.WriteLine(khach.ToString());
            }
        }
        public void LogOut ()
        {
            Environment.Exit(0);
        }
    }
}
