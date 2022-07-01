using System;
using System.Collections.Generic;
using System.Text;
using TaxiDepot.Cars;
using TaxiDepot.OptionsCar;
using System.Linq;

namespace TaxiDepot
{
    class BuyingСar
    {                            
        static List<string> listNameEconomCar = new List<string> { "Reno Logan", "VW Polo", "Scoda Rapid", "Lada Granta" };
        static List<string> listNameBuisinessCar = new List<string> { "Audi A6", "BMW 5-series", "VW Passat", "Mersedes E-class" };
        static List<string> listNamePremiumCar = new List<string> { "Audi A8", "BMW 7-series", "VW Phaetone", "Mersedes S-class" };
        static List<string> listColor = new List<string> { "White", "Black", "Red", "Green" };
        static List<string> listNameAudioSystem = new List<string> { "Pioneer", "JBL", "Supra", "JVC" };
        static Random _random = new Random();
        public static string BuyEconomCar() 
        {
            var id=0;
            var allcars =new List<EconomyCar> { };
            try
            {
                allcars = DBFile<EconomyCar>.Read("EconomyCar");
                var last = (from p in allcars
                            orderby p.Id
                            select p).Last();
                id = last.Id + 1;
            }
            catch { id = 1000; }
            finally
            {
                EconomyCar newCar = new EconomyCar()
                {
                    Id = id,
                    Name = listNameEconomCar[_random.Next(listNameEconomCar.Count)],
                    Color = listColor[_random.Next(listColor.Count)],
                    Expense = _random.Next(5, 12),
                    MaxSpeed = _random.Next(150, 180),
                    Price = _random.Next(25000, 35000),
                    Seats = 5,
                    Weight = _random.Next(1300, 1600),
                    BabyСhair = new BabyСhair(_random.Next(80, 120), _random.Next(20, 40)),
                    AudioSystem = new AudioSystem(listNameAudioSystem[_random.Next(listNameAudioSystem.Count)], _random.Next(2, 8)),
                    TrunkVolume = new CarTrunkVolume(_random.Next(80, 120), _random.Next(80, 140), _random.Next(40, 60))
                };
                allcars.Add(newCar);
                DBFile<EconomyCar>.Write(allcars, "EconomyCar");    
            }
            return "Economy class car purchased";
        }
        public static string BuyBuisinessCar()
        {
            var id = 0;
            var allcars = new List<BuisinessCar> { };
            try
            {
                allcars = DBFile<BuisinessCar>.Read("BuisinessCar");
                var last = (from p in allcars
                            orderby p.Id
                            select p).Last();
                id = last.Id + 1;
            }
            catch { id = 2000; }
            finally
            {
                BuisinessCar newCar = new BuisinessCar()
                {
                    Id = id,
                    Name = listNameBuisinessCar[_random.Next(listNameEconomCar.Count)],
                    Color = listColor[_random.Next(listColor.Count)],
                    Expense = _random.Next(10, 16),
                    MaxSpeed = _random.Next(180, 240),
                    Price = _random.Next(100000, 180000),
                    Seats = 5,
                    Weight = _random.Next(1600, 2100),
                    BabyСhair = new BabyСhair(_random.Next(80, 120), _random.Next(20, 40)),
                    AudioSystem = new AudioSystem(listNameAudioSystem[_random.Next(listNameAudioSystem.Count)], _random.Next(4, 10)),
                    TrunkVolume = new CarTrunkVolume(_random.Next(100, 150), _random.Next(100, 160), _random.Next(50, 70)),
                    Сonditioner = new Сonditioner(_random.Next(20, 26), Math.Round(_random.NextDouble(), 2)),
                    HeatedSeats = new HeatedSeats(_random.NextDouble() >= 0.5, _random.Next(18, 26))                    
                };
                  allcars.Add(newCar);
                  DBFile<BuisinessCar>.Write(allcars, "BuisinessCar");
            }
            return "Buisiness class car purchased";
        }
        public static string BuyPremiumCar()
        {
            var id = 0;
            var allcars = new List<PremiumCar> { };
            try
            {
                allcars = DBFile<PremiumCar>.Read("PremiumCar");
                var last = (from p in allcars
                            orderby p.Id
                            select p).Last();
                id = last.Id + 1;
            }
            catch { id = 3000; }
            finally
            {
                PremiumCar newCar = new PremiumCar()
                {
                    Id = id,
                    Name = listNamePremiumCar[_random.Next(listNameEconomCar.Count)],
                    Color = listColor[_random.Next(listColor.Count)],
                    Expense = _random.Next(16, 25),
                    MaxSpeed = _random.Next(240, 280),
                    Price = _random.Next(100000, 180000),
                    Seats = 4,
                    Weight = _random.Next(1600, 2100),
                    BabyСhair = new BabyСhair(_random.Next(80, 120), _random.Next(20, 40)),
                    AudioSystem = new AudioSystem(listNameAudioSystem[_random.Next(listNameAudioSystem.Count)], _random.Next(4, 10)),
                    TrunkVolume = new CarTrunkVolume(_random.Next(100, 150), _random.Next(100, 160), _random.Next(50, 70)),
                    Сonditioner = new Сonditioner(_random.Next(20, 26), Math.Round(_random.NextDouble(),2)),
                    HeatedSeats = new HeatedSeats(_random.NextDouble() >= 0.5, _random.Next(18, 26)),
                    SeatsWithMassage = new SeatsWithMassage(_random.NextDouble() >= 0.5), 
                    Television=new Television(_random.Next(7, 17))                    
                };
                allcars.Add(newCar);
                DBFile<PremiumCar>.Write(allcars, "PremiumCar");
            }
            return "Premium car purchased";
        }

    }
}
