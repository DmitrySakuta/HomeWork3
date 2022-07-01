using System;
using System.Collections.Generic;
using System.Text;
using TaxiDepot.Cars.Interface;
using TaxiDepot.OptionsCar;

namespace TaxiDepot
{
    class PremiumCar : Car, IPremiumClass
    {
        public SeatsWithMassage SeatsWithMassage { get; set; }
        public Television Television { get; set; }
        public Сonditioner Сonditioner { get; set; }
        public HeatedSeats HeatedSeats { get; set; }
        public CarTrunkVolume TrunkVolume { get; set; }
        public AudioSystem AudioSystem { get; set; }
        public BabyСhair BabyСhair { get; set; }
    }
}
