using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ManagerOfficer
    {
        private IList<Officer> officers;
        public ManagerOfficer() {
            officers= new List<Officer>();
        }
        public void Add (Officer officer)
        {
            officers.Add(officer);
        }
        public List<Officer> Search (string name)
        {
            if(name== null)
            {
                return null;
            }
            return (from list in officers
                    where list.fullname.Contains(name)

                    select list).ToList(); 
        }
        public void Show()
        {
            foreach (var item in officers)
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
