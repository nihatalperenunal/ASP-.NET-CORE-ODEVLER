using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classess
{
    public class Araba
    {
        public Marka Marka;
        public Kapi Kapi;
        public Pencere Pencere;
        public Kasa Kasa;
        public decimal Fiyat;

        public Araba(Marka marka, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            Marka = marka;
            Kapi = kapi;
            Pencere = pencere;
            Kasa = kasa;
            Fiyat = fiyat;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Arabanın markası {Marka.Isim}, modeli {Marka.Model}, kapı sayısı {Kapi.Kapisayisi}, pencere sayısı {Pencere.Penceresayisi}, kasası {Kasa.Tip}, fiyatı {Fiyat:N0} TL'dir.");
        }
    }
}
