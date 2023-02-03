using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ManagerOfficer
    {
        private IList<Officer> _officers;
        public ManagerOfficer() {
            _officers= new List<Officer>();
        }
        public void Add (Officer officer)
        {
            _officers.Add(officer);
        }
        public List<Officer> Search (string name)
        {
            if(name== null)
            {
                return null;
            }
            return (from list in _officers
                    where list.FullName.Contains(name)

                    select list).ToList(); 
        }
        public void Show()
        {
            foreach (var item in _officers)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void LogOut()
        {
            Environment.Exit(0);
        }
    }
}
