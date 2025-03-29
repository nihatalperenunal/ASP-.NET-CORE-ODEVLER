using GENERİC_LİST_VE_NESNE_KULLANIMI.Classess;

List<Car> cars = new List<Car>()
{
    new Car("Toyota","Corolla",6.5,5000),
    new Car("BMW","X5",9.0,5000),
    new Car("Mercedes", "C200", 8.2, 5000)

};
foreach (var car in cars)
{
    Console.WriteLine($"Marka: {car.Marka}, Model: {car.Model}, 100 km'de Yaktığı Yakıt: {car.FuelConsumption} litre, Toplam Yakıt Tüketimi: {car.ToplamYakitTuketimi()} litre");
}