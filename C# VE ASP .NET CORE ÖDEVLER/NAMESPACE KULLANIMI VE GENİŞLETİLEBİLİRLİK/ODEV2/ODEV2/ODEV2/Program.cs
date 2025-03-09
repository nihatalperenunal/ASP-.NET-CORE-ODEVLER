using System;
using IslemNamespace; // Hesapla sınıfını tanımladığımız namespace'i ekliyoruz

namespace TestNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesapla hesaplama = new Hesapla();

            int toplam = hesaplama.Topla(10, 20);
            Console.WriteLine($"10 + 20 = {toplam}");
            int carpim = hesaplama.Carp(5, 6);
            Console.WriteLine($"5 * 6 = {carpim}");
        }
    }
}
