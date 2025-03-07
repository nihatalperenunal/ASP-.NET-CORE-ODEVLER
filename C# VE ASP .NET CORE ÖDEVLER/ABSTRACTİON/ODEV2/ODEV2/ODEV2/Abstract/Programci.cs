using ODEV2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV2.Abstract
{
    public class Programci : Calisan,ICalisan
    {
        public override double maasinizNedir()
        {
            return 40000.00;
        }
        public double Salary()
        {
            double salary1 = 0.0;
            salary1 += maasinizNedir();
            return salary1;
        }
    }
}
