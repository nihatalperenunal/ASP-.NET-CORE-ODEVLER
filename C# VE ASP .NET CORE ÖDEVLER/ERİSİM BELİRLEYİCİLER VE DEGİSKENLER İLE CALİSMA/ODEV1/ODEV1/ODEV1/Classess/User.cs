using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classess
{
    public class User
    {
        private string adSoyad;
        private int yas;

        public string Email { get; set; }

        // Getter ve Setter metotları
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string deger)
        {
            adSoyad = deger;
        }

        public int GetYas()
        {
            return yas;
        }
        public void SetYas(int deger)
        {
            if (deger >= 0)
            {
                yas = deger;
            }
            else
            {
                Console.WriteLine("Yaş 0 veya daha büyük olmalıdır.");
            }
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Ad ve Soyad: "+adSoyad);
            Console.WriteLine("Yaş: "+yas);
        }
    }
}
