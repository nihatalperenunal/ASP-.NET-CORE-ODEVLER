using ODEV3.Classess;

Bmw bmw = new Bmw();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();
double totalfuel = bmw.yakıt() + mercedes.yakıt() + porsche.yakıt();
Console.WriteLine("The total fuel is: " + totalfuel + "Lt.");