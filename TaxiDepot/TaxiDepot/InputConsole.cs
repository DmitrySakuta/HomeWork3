using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiDepot
{
    class InputConsole
    {
        static byte Anser(string menuConsole, int sizeMenu)
        {
            byte numberMenu;
            var flag = false;
            do
            {
                Console.WriteLine(menuConsole);
                Console.WriteLine("Please, enter a number!");
                flag = byte.TryParse(Console.ReadLine(), out numberMenu);
            }
            while (sizeMenu < numberMenu || numberMenu < 1 || !flag);
            return numberMenu;
        }
        static int[] FindSpeed()
        {
            int[] speed = new int[2];
            var flag1 = false;
            var flag2 = false;
            do
            {
                Console.WriteLine("Enter min speed");
                flag1 = Int32.TryParse(Console.ReadLine(), out speed[0]);
                Console.WriteLine("Enter max speed");
                flag2 = Int32.TryParse(Console.ReadLine(), out speed[1]);
            }
            while (!flag1 || !flag2);
            return speed;
        }
        static int FindId()
        {
            var id = 0;
            var flag = false;
            do
            {
                Console.WriteLine("Enter id:");
                flag = Int32.TryParse(Console.ReadLine(), out id);
            }
            while (!flag);
            return id;
        }
        static void SecondMenu(List<Car> selectedCar)
        {
            var secondMenuConsole = @$"1-Sort by expense
2-Search by speed";
            switch (Anser(secondMenuConsole, 2))
            {
                case 1:
                    OutputConsole.SortCars(selectedCar);
                    break;
                case 2:                     
                    var speed = FindSpeed();
                    OutputConsole.FindeCars(selectedCar, speed[0], speed[1]);
                    break;                       
            }
        }
       public static void StartWork()
        {
            var anser = "";
            var firstMenuConsole = @$"1-View all cars
2-View economy class cars
3-View business class cars
4-View premiumclass cars
5-Detailed information about the car
6-Buy an economy class car
7-Buy a business class car
8-Buy a premium car";
            var selectedCar = new List<Car> { };

            switch (Anser(firstMenuConsole, 8))
            {
                case 1:
                    selectedCar = OutputConsole.ShowAllCars();
                    SecondMenu(selectedCar);
                    break;
                case 2:
                    selectedCar.AddRange(OutputConsole.ShowEconomCars());
                    SecondMenu(selectedCar);
                    break;
                case 3:
                    selectedCar = OutputConsole.ShowBuisinessCars();
                    SecondMenu(selectedCar);
                    selectedCar.Clear();
                    break;
                case 4:
                    selectedCar = OutputConsole.ShowPremiumCars();
                    SecondMenu(selectedCar);
                    selectedCar.Clear();
                    break;
                case 5: OutputConsole.TakeCarInfo(FindId()); break;
                case 6: Console.WriteLine(BuyingСar.BuyEconomCar()); break;
                case 7: Console.WriteLine(BuyingСar.BuyBuisinessCar()); break;
                case 8: Console.WriteLine(BuyingСar.BuyPremiumCar()); break;
            }
            do
            {
                Console.WriteLine("Do you wanna repeat? Enter Y/N.");
                anser = Console.ReadLine();
                anser = anser.ToUpper();
            }
            while (anser != "Y" && anser != "N");
            if (anser == "Y") StartWork();
            else Console.WriteLine("The job is done!");
        }
    }
}
