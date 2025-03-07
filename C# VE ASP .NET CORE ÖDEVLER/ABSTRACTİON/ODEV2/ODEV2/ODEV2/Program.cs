using ODEV2.Abstract;

Genelmudur gm = new Genelmudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer stj = new Stajyer();
double toplammaas = 0.0;
toplammaas += gm.maasinizNedir() + mu.maasinizNedir() + pr.maasinizNedir() + stj.maasinizNedir();
Console.WriteLine("Toplam maaş: " + toplammaas + "TL");