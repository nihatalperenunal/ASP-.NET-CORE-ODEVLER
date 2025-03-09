Console.Write("1. sayıyı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. sayıyı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen işleminizi seçin (+ - / *): ");
char islem = Console.ReadKey().KeyChar;
Console.WriteLine();
if (islem == '+')
{
    Console.WriteLine("Sonuç: "+(sayi1 + sayi2));
}
else if (islem == '-')
{
    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
}
else if (islem == '*')
{
    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
}
else if (islem == '/')
{
    if(sayi2 != 0)
    {
        Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
    }
    else
    {
        Console.WriteLine("Sayı sıfıra bölünemez.");
    }
}
else
{
    Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
}
