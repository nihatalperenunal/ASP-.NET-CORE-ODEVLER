using ODEV5.Classess;

Araba[] arabalar =
{
    new Araba("BMW","320D",65),
    new Araba("Audi","A8",50),
    new Araba("Fiat","Egea",35)
};
int toplamyakit  = 0;
for (int i = 0; i < arabalar.Length; i++)
{
    Console.WriteLine(arabalar[i].Marka + " " + arabalar[i].Model + " " + "Tüketilen Yakıt Miktarı: " + arabalar[i].Benzin + "Lt");
    toplamyakit += arabalar[i].Benzin;
}
Console.WriteLine("Tüketilen toplam yakıt miktarı: " + toplamyakit + "Lt");