using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot.OptionsCar
{
    class CarTrunkVolume : IConsoleInformation
    {

        public double Width { get; }
        public double Length { get; }
        public double Height { get;  }     
        public double TrunkVolume
        {
            get
            {
                return Math.Round(Width * Length * Height/1000,2);
            }
        }
        public CarTrunkVolume( double width, double length, double height)
        {
            Width = width;
            Length = length;
            Height = height;
        }     
        public string Info()
        {
            string outInfo = $"Car trunk volume:{TrunkVolume} liters";
            //  Console.WriteLine($"Car trunk volume:{TrunkVolume}");
            return outInfo;
        }
    }
}
