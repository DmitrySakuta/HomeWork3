using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot.OptionsCar
{
    class BabyСhair: IConsoleInformation
    {
        public int MaxGrowth { get; }
        public int MaxWeight { get; }
        public BabyСhair( int maxGrowth, int maxWeight)
        {        
            MaxWeight = maxWeight;
            MaxGrowth = maxGrowth;
        }

        public string Info()
        {
            string outInfo = $"The child seat has a maximum Weight:{MaxWeight} and maximum growth:{MaxGrowth}";
           // Console.WriteLine(outInfo);
            return outInfo;
        }
    }
}
