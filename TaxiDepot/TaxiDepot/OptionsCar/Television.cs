using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot.OptionsCar
{
    class Television:IConsoleInformation
    {
        public int Diagonal { get; set; }
          public Television( int diagonal) 
        {
           Diagonal = diagonal;
        }
        public string Info()
        {
            string outInfo = $"Television diagonal:{Diagonal} inch";
            //Console.WriteLine($"Television diagonal: {Diagonal} inch");
            return outInfo;         
        }
    }
}
