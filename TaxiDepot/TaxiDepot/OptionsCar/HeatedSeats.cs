using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot.OptionsCar
{
    class HeatedSeats: IConsoleInformation
    {
        private bool _frontSeats=true;
        public bool BackSeats { get;  }
        public double Heatingtemperature { get; }
        public HeatedSeats(bool backSeats, double heatingtemperature)
        {
            BackSeats = backSeats;
            Heatingtemperature = heatingtemperature;
        }
        public string Info()
        {
            string outInfo = $"Heated front seats:{_frontSeats}; Heated back seats:{BackSeats}; Heating temperature:{Heatingtemperature}";
            //Console.WriteLine(outInfo);
            return outInfo;      
        }
    }
}
