using ODEV1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classess
{
    public class Porsche: IAraba
    {
        public void denizdeyuz()
        {
            throw new NotImplementedException();
        }

        public void havadauc()
        {
            Console.Write("Porsche: Havada uçar.");
        }

        public void hızlıgit()
        {
            throw new NotImplementedException();
        }
    }
}
