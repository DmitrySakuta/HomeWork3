using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TaxiDepot.OptionsCar;
//using System.Text.Json;
using Newtonsoft.Json;
using TaxiDepot.Cars;
using System.Linq;


namespace TaxiDepot
{
    class DBFile<T>
    {
        public static void Write(object allCars, string nameType) 
        {
            var serializer = new JsonSerializer();

            using (StreamWriter fs = new StreamWriter($"{nameType}.json"))
            {
                using (var jsonTextWriter = new JsonTextWriter(fs))
                {
                    serializer.Serialize(fs, allCars);
                }
            }  
        } 
        public static List<T> Read(string typeCar) 
        {
            var  cars = new List<T> { };
            try
            {
                using (StreamReader file = File.OpenText($"{typeCar}.json"))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    cars = (List<T>)serializer.Deserialize(file, typeof(List<T>));
                }
                return cars;
            }
            catch { return cars; }            
        }
    }
}
