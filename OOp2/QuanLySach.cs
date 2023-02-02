using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOp2
{
    internal class QuanLySach
    {

        private IList<ManageDocument> manages;
        public QuanLySach()
        {
            manages = new List<ManageDocument>();
        }
        public void ThemMoi(ManageDocument manage)
        {
            manages.Add(manage);
        }
        public bool Xoa(string id)
        {
            var check = from list in manages
                        where list.ID== id
                        select list;
            if (check.Count() > 0)
            {
                manages.Remove((from list in manages
                                where list.ID == id
                                select list).FirstOrDefault());
                return true;
            }
            return false;
        }
        public void TimKiem(string tensearch)
        {
            List<ManageDocument> manageDocuments= new List<ManageDocument>();
            if (tensearch == "Sach")
            {
                manageDocuments = (from list in manages
                        where list.GetType() == typeof(Book)
                        select list).ToList();
            }
            else if (tensearch == "TapChi")
            {
                manageDocuments = (from list in manages
                        where list.GetType() == typeof(magazine)
                        select list).ToList();
            }
            else if (tensearch == "Bao")
            {
                manageDocuments = (from list in manages
                        where list.GetType() == typeof(Newspaper)
                        select list).ToList();
            }
            foreach (var t in manageDocuments)
            {
                Console.WriteLine(t.ToString());
            }
        }
        public void HienThi()
        {
            foreach (var item in manages)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void EXIT()
        {
            Environment.Exit(0);
        }
    }
}
