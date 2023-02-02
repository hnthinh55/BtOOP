using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Hotel
    {
        private IList<Customer> customers;
        public Hotel() {
            customers = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public bool Remove(string id)
        {
            var check = from list in customers
                        where list.identifyCard == id
                        select list;
            if (check.Count() > 0)
            {
                customers.Remove((from list in customers
                                  where list.identifyCard == id
                                   select list).FirstOrDefault());
                return true;
            }
            return false;
        }
        public double RentPrice(string id) {
            var nguoiThue = customers.Where(khach => khach.identifyCard == id).FirstOrDefault();
            if(nguoiThue==null )
            {
                Console.WriteLine("Khong ton tai nguoi nay");
                return 0;
            }
            return nguoiThue.room.price * nguoiThue.numberRent;
        }
        public void Ouput() {
            Console.WriteLine("**Danh sach khach thue tai khach san: ");
           foreach (var khach in customers)
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
