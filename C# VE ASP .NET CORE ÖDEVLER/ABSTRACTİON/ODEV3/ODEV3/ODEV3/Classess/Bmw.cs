using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3.Classess
{
    public class Bmw : Araba
    {
        public override double litreBilgi()
        {
            return 80.0;
        }
        public double yakıt()
        {
            double fuel1 = 0;
            fuel1 += litreBilgi();
            return fuel1;
        }
    }
}
