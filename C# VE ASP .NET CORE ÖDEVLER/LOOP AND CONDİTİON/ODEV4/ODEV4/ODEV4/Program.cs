using ODEV4.Classess;

Calisan[] calisanlar = {
            new Calisan("Alperen", "Ünal", "Genel Müdür", 100000),
            new Calisan("Oğuz", "Yıldırım", "Müdür", 65000),
            new Calisan("Mehmet", "Yılmaz", "Programcı", 50000),
            new Calisan("Berk", "Ersoy", "Stajyer", 5000)
        };

// Toplam maaşı hesaplama
int toplamMaas = 0;
for (int i = 0; i < calisanlar.Length; i++)
{
    Console.WriteLine(calisanlar[i].Ad + " " + calisanlar[i].Soyad + ", " +
                      calisanlar[i].Meslek + ", Maaş: " + calisanlar[i].Maas + " TL");
    toplamMaas += calisanlar[i].Maas;
}

Console.WriteLine("\nToplam Maaş: " + toplamMaas + " TL");