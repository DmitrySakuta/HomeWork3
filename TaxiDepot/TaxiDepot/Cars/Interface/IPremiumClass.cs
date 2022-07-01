using System;
using System.Collections.Generic;
using System.Text;
using TaxiDepot.OptionsCar;

namespace TaxiDepot.Cars.Interface
{
    interface IPremiumClass:IBusinessClass
    {
        public SeatsWithMassage SeatsWithMassage { get; set; }
        public Television Television { get; set; }
    }
}
