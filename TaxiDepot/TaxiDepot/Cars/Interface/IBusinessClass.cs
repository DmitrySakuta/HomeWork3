using System;
using System.Collections.Generic;
using System.Text;
using TaxiDepot.OptionsCar;

namespace TaxiDepot.Cars
{
    interface IBusinessClass:IEconomyClass
    {
        public Сonditioner Сonditioner { get; set; }
        public HeatedSeats HeatedSeats { get; set; }
    }
}
