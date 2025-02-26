using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İNHERİTANCE.Classess
{
    public class Araba
    {
        public string marka;
        public string vites;
        public void arababilgi(string marka, string vites)
        {
            Console.WriteLine(marka + " " + vites + " " + "viteslidir.");
        }
    }
}
