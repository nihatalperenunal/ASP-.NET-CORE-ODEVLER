using ODEV2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV2.Abstract
{
    public class Stajyer : Calisan,ICalisan
    {
        public override double maasinizNedir()
        {
            return 5000.00;
        }
        public double Salary()
        {
            double salary1 = 0.0;
            salary1 += maasinizNedir();
            return salary1;
        }
    }
}
