using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot.OptionsCar
{
    class SeatsWithMassage:IConsoleInformation
    {
        public bool FrontSeats { get; }
        public bool _backSeats=true;      
        public SeatsWithMassage( bool frontSeats)
        {
            FrontSeats = frontSeats;         
        }
        public string Info()
        {
            string outInfo = $"Massage front seats:{FrontSeats} and massage back seats:{_backSeats}";
            //Console.WriteLine(outInfo);
            return outInfo;     
        }
    }
}
