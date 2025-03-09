using ODEV1.Classess;

User kullanici = new User();

// Değerleri ayarla
kullanici.SetAdSoyad("Alperen Ünal");
kullanici.SetYas(21);
kullanici.Email = "alperenunal@hotmail.com";

// Bilgileri yazdır
kullanici.BilgileriGoster();
Console.WriteLine("E-posta: "+kullanici.Email);
