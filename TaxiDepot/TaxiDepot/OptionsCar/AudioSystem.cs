using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot.OptionsCar
{
    class AudioSystem :IConsoleInformation
    {
       
        public string Manufacturer { get; }
        public int NumberOfSpeakers { get; } 
        public AudioSystem( string manufacturer, int numberOfSpeakers) 
        {
           
            Manufacturer = manufacturer;
            NumberOfSpeakers = numberOfSpeakers;
        }
        public string Info()
        {
            string outInfo = $"{Manufacturer} audio system has {NumberOfSpeakers} speakers";
           // Console.WriteLine(outInfo);
            return outInfo;
        }
    }
}
