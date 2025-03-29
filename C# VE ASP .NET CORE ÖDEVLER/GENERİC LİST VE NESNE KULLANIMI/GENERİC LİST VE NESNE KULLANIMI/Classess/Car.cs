using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GENERİC_LİST_VE_NESNE_KULLANIMI.Classess
{
    public class Car
    {
        public string Marka;
        public string Model;
        public double FuelConsumption;
        public double TotalDistance;

        public Car(string marka, string model, double fuelConsumption, double totalDistance)
        {
            Marka = marka;
            Model = model;
            FuelConsumption = fuelConsumption;
            TotalDistance = totalDistance;
        }
        public double ToplamYakitTuketimi()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }
    }
}
