using ODEV1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classess
{
    public class Bmw: IAraba
    {
        public void hızlıgit()
        {
            Console.Write("BMW: Çok hızlı gider");
        }
        public void denizdeyuz()
        {
            Console.Write(",denizde yüzer");
        }
        public void havadauc()
        {
            Console.WriteLine(",havada uçar.");
        }
    }
}
