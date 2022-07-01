using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot
{
    abstract class Car : ITransfer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int MaxSpeed { get; set; }
        public double Expense { get; set; }
        public double Price { get; set; }
        public int Seats { get; set; }
        public string Color { get; set; }       
        public void Move() 
        {
            Console.WriteLine("The car is moving");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }
      
    }
}
