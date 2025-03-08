Random rastgele = new Random();
int dogruSayi = rastgele.Next(1, 101);
int tahmin = 0;
int tahminSayisi = 0;

Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin etmeye çalış!");

while (tahmin != dogruSayi)
{
    Console.Write("Tahmininizi girin: ");
    tahmin = Convert.ToInt32(Console.ReadLine());
    tahminSayisi++;

    if (tahmin < dogruSayi)
    {
        Console.WriteLine("Daha büyük bir sayı deneyin.");
    }
    else if (tahmin > dogruSayi)
    {
        Console.WriteLine("Daha küçük bir sayı deneyin.");
    }
    else
    {
        Console.WriteLine("Tebrikler! Doğru tahmini yaptınız.");
    }
}

Console.WriteLine("Tahmin sayınız: " + tahminSayisi);