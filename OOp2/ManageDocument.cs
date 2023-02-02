using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class ManageDocument
    {

        private IList<Document> manages;
        public ManageDocument()
        {
            manages = new List<Document>();
        }
        public void AddDocument(Document manage)
        {
            manages.Add(manage);
        }
        public bool RemoveDocument(string id)
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
        public void SearchDocument(string tensearch)
        {
            List<Document> manageDocuments= new List<Document>();
            if (tensearch == "Sach")
            {
                manageDocuments = (from list in manages
                        where list.GetType() == typeof(Book)
                        select list).ToList();
            }
            else if (tensearch == "TapChi")
            {
                manageDocuments = (from list in manages
                        where list.GetType() == typeof(Magazine)
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
        public void ShowList()
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
