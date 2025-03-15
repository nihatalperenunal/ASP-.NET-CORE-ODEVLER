using ODEV2.Classess;

var matematik = new Matematik();

Console.WriteLine("Toplam (int, 2 parametreli): " + matematik.Topla(3, 5));
Console.WriteLine("Toplam (int, 3 parametreli): " + matematik.Topla(3, 5, 7));
Console.WriteLine("Toplam (double, 2 parametreli): " + matematik.Topla(2.5, 3.7));
Console.WriteLine("Toplam (double, 3 parametreli): " + matematik.Topla(2.5, 3.7,8.6));
Console.WriteLine("Çarpım (int, 2 parametreli): " + matematik.Carp(2, 4));
Console.WriteLine("Çarpım (int, 3 parametreli): " + matematik.Carp(2, 4,7));
Console.WriteLine("Çarpım (double, 2 parametreli): " + matematik.Carp(1.5, 2.5));
Console.WriteLine("Çarpım (double, 3 parametreli): " + matematik.Carp(1.5, 2.5, 3.5));
