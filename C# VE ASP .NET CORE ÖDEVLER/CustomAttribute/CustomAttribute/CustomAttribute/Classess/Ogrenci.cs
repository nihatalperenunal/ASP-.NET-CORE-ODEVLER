using CustomAttribute.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute.Classess
{
    public class Ogrenci
    {
        [ZorunluAlan("Ad alanı boş bırakılamaz.")]
        public string Ad { get; set; }

        [ZorunluAlan("Soyad alanı boş bırakılamaz.")]
        public string Soyad { get; set; }

        [ZorunluAlan("Bölüm alanı boş bırakılamaz.")]
        public string Bolum { get; set; }
    }
}
