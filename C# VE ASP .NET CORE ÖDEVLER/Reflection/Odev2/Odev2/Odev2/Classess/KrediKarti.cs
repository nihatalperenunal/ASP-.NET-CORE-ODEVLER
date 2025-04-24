using Odev2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2.Classess
{
    public class KrediKarti: IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Kredi kartı ile {tutar} tl ödeme yapıldı";
        }
    }
}
