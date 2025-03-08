int[] sayilar = new int[5];
int toplam = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write("Lütfen " + (i + 1) + ". Sayıyı girin: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
    toplam += sayilar[i];
}
double ortalama = (double)toplam / 5;
Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);