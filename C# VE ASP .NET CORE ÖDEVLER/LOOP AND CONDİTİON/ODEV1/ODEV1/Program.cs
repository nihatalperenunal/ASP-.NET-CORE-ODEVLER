Console.Write("Yaşınızı girin: ");
int yas  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(yasDurumu(yas));
string yasDurumu(int yas)
{
    if (yas < 0 || yas > 99)
        return "Ya hiç doğmadınız ya da çoktan öldünüz.";
    if (yas < 18)
        return "Küçüksünüz";
    if (yas < 35)
        return "Gençsiniz.";
    if (yas < 55)
        return "Yetişkinsiniz.";
    if (yas < 75)
        return "Yaşlısınız";
    return "Çok Yaşlısınız.";
}

