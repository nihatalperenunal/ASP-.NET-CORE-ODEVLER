using ODEV1.Classess;

var marka = new Marka { Isim = "BMW", Model = "X5" };
var kapi = new Kapi { Kapisayisi = 4 };
var pencere = new Pencere { Penceresayisi = 4 };
var kasa = new Kasa { Tip = "Sedan" };
var fiyat = 2000000m;
var araba = new Araba(marka, kapi, pencere, kasa, fiyat);
araba.BilgileriYazdir();