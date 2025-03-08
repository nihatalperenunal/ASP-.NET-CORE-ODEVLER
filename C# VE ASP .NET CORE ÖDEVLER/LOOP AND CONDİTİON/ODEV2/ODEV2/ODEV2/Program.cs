Console.Write("Araba yaşını girin: ");
int arabayasi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(arabadurum(arabayasi));
string arabadurum(int arabayasi)
{
    if (arabayasi < 0 || arabayasi > 30)
    {
        return "Ya hiç üretilmedi ya da trafikten men edildi.";
    }
    if(arabayasi < 10)
    {
        return "Arabanız yeni.";
    }
    if(arabayasi < 20)
    {
        return "Servise götürmeniz gerekebilir.";
    }
    return "Arabanız hurdaya çıkabilir.";
}

//Ekstradan switch case yapısı ile de yapabiliriz.

/*Console.Write("Araba yaşını girin: ");
int arabayasi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(arabadurum(arabayasi));
string arabadurum(int arabayasi)
{
    switch (arabayasi)
    {
        case < 0:
        case > 30:
            return "Ya hiç üretilmedi ya da trafikten men edildi.";

        case < 10:
            return "Arabanız yeni.";

        case < 20:
            return "Servise götürmeniz gerekebilir.";

        default:
            return "Arabanız hurdaya çıkabilir.";
    }
}*/
