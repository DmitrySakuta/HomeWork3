using System;
using System.Collections.Generic;
using System.Text;
using TaxiDepot.OptionsCar;

namespace TaxiDepot.Cars
{
    class BuisinessCar : Car, IBusinessClass
    {
        public Сonditioner Сonditioner { get; set; }
        public HeatedSeats HeatedSeats { get; set; }
        public CarTrunkVolume TrunkVolume { get; set; }
        public AudioSystem AudioSystem { get; set; }
        public BabyСhair BabyСhair { get; set; }
    }
}
