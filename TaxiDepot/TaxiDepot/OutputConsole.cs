using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TaxiDepot.Cars;

namespace TaxiDepot
{
    class OutputConsole
    {
        private static void ConsoleWrite(List<Car> cars) 
        {
            foreach(var car in cars )
                Console.WriteLine($"ID:{car.Id} Price:{car.Price} Fuel consumption:{car.Expense} Max Speed:{car.MaxSpeed} Color:{car.Color} Seats:{car.Seats} Name:{car.Name}");
            var sum = (from p in cars
                       select p.Price).Sum();
            Console.WriteLine($"Total cost: {sum} {Environment.NewLine}");
        }
        public static List<Car> ShowAllCars()
        {
            List<Car> allCar = new List<Car> { };
            allCar.AddRange(DBFile<EconomyCar>.Read("EconomyCar"));
            allCar.AddRange(DBFile<BuisinessCar>.Read("BuisinessCar"));
            allCar.AddRange(DBFile<PremiumCar>.Read("PremiumCar"));
            ConsoleWrite(allCar);
            return allCar;
        }

        public static List<Car> ShowEconomCars()
        {
            List<Car> allCar = new List<Car> { };
            allCar.AddRange(DBFile<EconomyCar>.Read("EconomyCar"));           
            ConsoleWrite(allCar);
            return allCar;
        }
        public static List<Car> ShowBuisinessCars()
        {
            List<Car> allCar = new List<Car> { };
            allCar.AddRange(DBFile<BuisinessCar>.Read("BuisinessCar"));
            ConsoleWrite(allCar);
            return allCar;
        }
        public static List<Car> ShowPremiumCars()
        {
            List<Car> allCar = new List<Car> { };
            allCar.AddRange(DBFile<PremiumCar>.Read("PremiumCar"));
            ConsoleWrite(allCar);
            return allCar;
        }
        public static void SortCars(List<Car> cars)
        {
            var sortedCars = from p in cars
                                    orderby p.Expense
                                    select p;
            foreach (var car in sortedCars)
                Console.WriteLine($"ID:{car.Id} Fuel consumption:{car.Expense} Max speed:{car.MaxSpeed} Name:{car.Name}");
        }
        public static void FindeCars(List<Car> cars, int minSpeed, int maxSpeed) 
        {   var flag = false;
            var findCar = from p in cars
                       where p.MaxSpeed >= minSpeed
                       where p.MaxSpeed <= maxSpeed
                       select p;            
                foreach (var car in findCar)
                {
                    Console.WriteLine($"ID:{car.Id} Fuel consumption:{car.Expense} Max speed:{car.MaxSpeed} Name:{car.Name}");
                    flag = true;
                }
                
           if(!flag)
                OutNoCar();
        }
        public static void TakeCarInfo( int id)
        {
            var flag = false;

            if (id >= 1000 && id < 2000)
            {
                var listCar = DBFile<EconomyCar>.Read("EconomyCar");
                var findCar = from p in listCar
                              where p.Id == id
                              select p;
                foreach (var car in findCar)
                {
                    Console.WriteLine($"ID:{car.Id} Name:{car.Name} | Color:{car.Color} | Fuel consumption:{car.Expense} | Max speed:{car.MaxSpeed} | Price:{car.Price}{Environment.NewLine}{car.AudioSystem.Info()} | {car.BabyСhair.Info()}{Environment.NewLine}{car.TrunkVolume.Info()}");
                    flag = true;
                }
                if (!flag)
                    OutNoCar();
            }
            else
            if (id >= 2000 && id < 3000)
            {
                var listCar = DBFile<BuisinessCar>.Read("BuisinessCar");
                var findCar = from p in listCar
                              where p.Id == id
                              select p;
                foreach (var car in findCar)
                {
                    Console.WriteLine($"ID:{car.Id} Name:{car.Name} | Color:{car.Color} | Fuel consumption:{car.Expense} | Max speed:{car.MaxSpeed} | Price:{car.Price}{Environment.NewLine}{car.AudioSystem.Info()} | {car.BabyСhair.Info()}{Environment.NewLine}{car.TrunkVolume.Info()} | {car.Сonditioner.Info()}");
                    flag = true;
                }
                if (!flag)
                    OutNoCar();
            }
            else
            if (id >= 3000)
            {
                var listCar = DBFile<PremiumCar>.Read("PremiumCar");
                var findCar = from p in listCar
                              where p.Id == id
                              select p;
                foreach (var car in findCar)
                {
                    Console.WriteLine($"ID:{car.Id} Name:{car.Name} | Color:{car.Color} | Fuel consumption:{car.Expense} | Max speed:{car.MaxSpeed} | Price:{car.Price}{Environment.NewLine}{car.AudioSystem.Info()} | {car.BabyСhair.Info()}{Environment.NewLine}{car.TrunkVolume.Info()} | {car.Сonditioner.Info()}{Environment.NewLine}{car.SeatsWithMassage.Info()} | {car.Television.Info()}");
                    flag = true;
                }
                if (!flag)
                    OutNoCar();
            }
            else 
            {
                OutNoCar();
            }
        }
        static void OutNoCar() 
        {
            Console.WriteLine("There are no cars matching this parameter!");
        }

    }
}
