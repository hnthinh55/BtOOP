using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtOOP
{
    internal class QLCB
    {
        private IList<CanBo> CanBos;
        public QLCB() {
            CanBos= new List<CanBo>();
        }
        public void ThemMoi (CanBo canBo)
        {
            CanBos.Add(canBo);
        }
        public List<CanBo> TimKiem (string tensearch)
        {
            if(tensearch== null)
            {
                return null;
            }
            return (from list in CanBos
                    where list.HoTen.Contains(tensearch)
                    select list).ToList(); 
        }
        public void HienThi()
        {
            foreach (var item in CanBos)
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
