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
        public List<Family> hogiadinhs;
        public Area() {
            hogiadinhs = new List<Family>();
        }

        public IEnumerator<Family> GetEnumerator()
        {
            return ((IEnumerable<Family>)hogiadinhs).GetEnumerator();
        }

        public void addFamily(Family hoGiaDinh)
        {
            hogiadinhs.Add(hoGiaDinh);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)hogiadinhs).GetEnumerator();
        }
    }
}
