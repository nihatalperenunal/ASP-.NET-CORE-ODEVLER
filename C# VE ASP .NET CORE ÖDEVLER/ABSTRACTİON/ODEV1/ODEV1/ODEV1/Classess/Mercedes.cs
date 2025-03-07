using ODEV1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classess
{
    public class Mercedes: IAraba
    {
        
        public void denizdeyuz()
        {
            Console.Write("Mercedes: Denizde yüzer");
        }
        public void havadauc()
        {
            Console.WriteLine(",havada uçar.");
        }

        public void hızlıgit()
        {
            throw new NotImplementedException();
        }
    }
}
