using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3.Classess
{
    internal class Mercedes : Araba
    {
        public override double litreBilgi()
        {
            return 70.0;
        }
        public double yakıt()
        {
            double fuel1 = 0;
            fuel1 += litreBilgi();
            return fuel1;
        }
    }
}
