using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Area : IEnumerable<Family>
    {
        public List<Family> families;
        public Area() {
            families = new List<Family>();
        }

        public IEnumerator<Family> GetEnumerator()
        {
            return ((IEnumerable<Family>)families).GetEnumerator();
        }

        public void AddFamily(Family hoGiaDinh)
        {
            families.Add(hoGiaDinh);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)families).GetEnumerator();
        }
    }
}
