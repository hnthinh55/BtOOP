using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp4
{
    internal class KhuPho : IEnumerable<HoGiaDinh>
    {
        public List<HoGiaDinh> hogiadinhs;
        public KhuPho() {
            hogiadinhs = new List<HoGiaDinh>();
        }

        public IEnumerator<HoGiaDinh> GetEnumerator()
        {
            return ((IEnumerable<HoGiaDinh>)hogiadinhs).GetEnumerator();
        }

        public void ThemHoGiaDinh(HoGiaDinh hoGiaDinh)
        {
            hogiadinhs.Add(hoGiaDinh);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)hogiadinhs).GetEnumerator();
        }
    }
}
