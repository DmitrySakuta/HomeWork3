using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxiDepot.OptionsCar;

namespace TaxiDepot.Cars
{
    class EconomyCar : Car, IEconomyClass
    {
        public CarTrunkVolume TrunkVolume { get; set; }
        public AudioSystem AudioSystem { get; set; }
        public BabyСhair BabyСhair { get; set; }        
    }
}
