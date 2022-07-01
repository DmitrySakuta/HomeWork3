using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot.OptionsCar
{
    class Сonditioner:IConsoleInformation
    {
        public double CoolingTemperature { get; }
        public double FuelConsumptionIncrease { get; }
        public Сonditioner(double coolingTemperature, double fuelConsumptionIncrease) 
        {
            CoolingTemperature = coolingTemperature;
            FuelConsumptionIncrease = fuelConsumptionIncrease;
        }
        public string Info()
        {
            string outInfo = $"Сonditioner cooling Temperature:{CoolingTemperature} Fuel Consumption Increas:{FuelConsumptionIncrease}";
            // Console.WriteLine(outInfo);
            return outInfo;          
        }
    }
}
