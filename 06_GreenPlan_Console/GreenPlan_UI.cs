using _06_GreenPlan_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_GreenPlan_Console
{
    class GreenPlan_UI
    {

        public GreenPlanRepo _greenPlanRepo = new GreenPlanRepo();
        public void Run()
        {
            CarSeeds();
            RunMenu();
        }
        public void RunMenu()
        {
            UICars();
        }
        //Start CRUD
        private void UICars()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display Options
                Console.WriteLine("  Welcome!\n" +
                    "  Select an option: \n" +
                    "  1. Add a new car\n" +
                    "  2. View all cars\n" +
                    "  3. View cars by type\n" +
                    "  4. Update a car\n" +
                    "  5. Delete a car\n" +
                    "  6. Exit");
                //Get Input
                string carMenuSelection = Console.ReadLine();
                //Evaluate Input
                switch (carMenuSelection)
                {
                    case "1":
                        AddANewCar();
                        break;
                    case "2":
                        ViewAllCars();
                        break;
                    case "3":
                        ViewAllCars();
                        break;
                    case "4":
                        UpdateACar();
                        break;
                    case "5":
                        DeleteACar();
                        break;
                    case "6":
                        Console.WriteLine("Have a great day!");
                        Thread.Sleep(1000);
                        keepRunning = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n  Please enter a valid option.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadLine();
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\n  Press anykey to continue...");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Add a new car dialog
        private void AddANewCar()
        {
            Console.Clear();
            GreenPlan newGreenPlan = new GreenPlan();
            //  newGreenPlan.CarNum = _greenPlanRepo.CarNum();
            Console.WriteLine("Select the new car type: \n" +
                 "1. Electric\n" +
                 "2. Hybrid\n" +
                 "3. Gas\n");
            string carInputType = Console.ReadLine();
            switch (carInputType)
            {
                case "1":
                    newGreenPlan.Type = GreenType.Electric;
                    break;
                case "2":
                    newGreenPlan.Type = GreenType.Hybrid;
                    break;
                case "3":
                    newGreenPlan.Type = GreenType.Gas;
                    break;
                default:
                    // Invalid input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\n  Please enter a valid option.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("Enter the car make: \n");
            newGreenPlan.Make = Console.ReadLine();
            Console.WriteLine("Enter the car model: \n");
            newGreenPlan.Model = Console.ReadLine();
            Console.WriteLine("Enter the car's City MPG: \n");
            newGreenPlan.CityMpg = Console.ReadLine();
            Console.WriteLine("Enter the car's Hwy MPG: \n");
            newGreenPlan.HwyMpg = Console.ReadLine();
            Console.WriteLine("Enter the car starting MSRP: \n");
            string msrpAmtAsString = Console.ReadLine();
            newGreenPlan.Msrp = int.Parse(msrpAmtAsString);
            _greenPlanRepo.AddCarsToList(newGreenPlan);
            Console.WriteLine("New car added");
        }
        //View all cars dialog
        private void ViewAllCars()
        {
            Console.Clear();
            List<GreenPlan> greenPlan = _greenPlanRepo.GetCars();
            int carCount = 1;
            foreach (GreenPlan car in greenPlan)
            {
                car.CarNum = carCount;
                _greenPlanRepo.GetCars();
                Console.WriteLine($"{car.CarNum}   {car.Type},{car.Make}, {car.Model}, {car.CityMpg}/{car.HwyMpg}, Starting MSRP: {car.Msrp}");
                carCount++;
            }
        }
        //Working efforts to get cars by Enum:Type
        //private void ViewCarsByType()
        //{
        //    string madeUp;

        //    GreenPlan newGreenPlan = new GreenPlan();
        //    // GreenPlan.Type = car.type;
        //    Console.WriteLine("Select the Type you'd like to see: \n" +
        //         "  1. Electric\n" +
        //         "  2. Hybrid\n" +
        //         "  3. Gas\n");
        //    string carInputType = Console.ReadLine();
        //    int typeASInt = int.Parse(carInputType);
        //    newGreenPlan.Type =(GreenType)typeASInt;

        //    switch (carInputType)
        //    {
        //        case "1":
        //            string carInputType = Console.ReadLine();
        //            int typeASInt = int.Parse(carInputType);
        //            newGreenPlan.Type = (GreenType)typeASInt;
        //            break;
        //        case "2":
        //            madeUp = GreenType.Hybrid;
        //            break;
        //        case "3":
        //            madeUp = GreenType.Gas;
        //            break;
        //        default:
        //            // Invalid input
        //            Console.ForegroundColor = ConsoleColor.DarkYellow;
        //            Console.WriteLine("\n\n  Please enter a valid option.");
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //            Console.ReadLine();
        //            break;
        //    }
        //    private void TypeCars()
        //    {
        //        Console.Clear();
        //        List<GreenPlan> typeCars = _greenPlanRepo.GetCars();
        //        int carCounts = 1;
        //        madeUp = GreenPlan.Type;
        //        foreach (GreenPlan car in greenPlan)
        //        {
        //            car.CarNum = carCounts;
        //            _greenPlanRepo.GetCars();
        //            if (car.Type = madeUp) ;
        //            Console.WriteLine($"{car.CarNum}   {car.Type},{car.Make}, {car.Model}, {car.CityMpg}/{car.HwyMpg}, Starting MSRP: {car.Msrp}");
        //            //            carCount++;
        //            //        }
        //            //    }
        //            //}

        // private void Model()
        //{
        //    Console.Clear();
        //    List<GreenPlan> greenPlan = _greenPlanRepo.GetCars();
        //    //Display options
        //    ViewAllCars();
        //    //Get car they want to update
        //    Console.WriteLine("Enter the car model you'd like to retrieve: ");
        //    string model = Console.ReadLine();
        //    foreach (GreenPlan car in greenPlan)
        //    {
        //        _greenPlanRepo.GetCarsByModel(model);
        //        Console.WriteLine($"{car.CarNum}   {car.Type},{car.Make}, {car.Model}, {car.CityMpg}/{car.HwyMpg}, Starting MSRP: {car.Msrp}");
        //    }
        //}
        
        //Update cars dialog
        private void UpdateACar()
        {
            //Display options for update
            ViewAllCars();
            //Get car they want to update
            Console.WriteLine("Enter the car # you'd like to update: ");
            string carNumAsString = Console.ReadLine();
            int origNum = int.Parse(carNumAsString);
            //Take in updated info
            GreenPlan newGreenPlan = new GreenPlan();
            Console.WriteLine("Select the new car type: \n" +
                 "  1. Electric\n" +
                 "  2. Hybrid\n" +
                 "  3. Gas\n");
            string carInputType = Console.ReadLine();
            switch (carInputType)
            {
                case "1":
                    newGreenPlan.Type = GreenType.Electric;
                    break;
                case "2":
                    newGreenPlan.Type = GreenType.Hybrid;
                    break;
                case "3":
                    newGreenPlan.Type = GreenType.Gas;
                    break;
                default:
                    // Invalid input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\n  Please enter a valid option.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    break;
            }
            Console.WriteLine("Enter the car make: ");
            newGreenPlan.Make = Console.ReadLine();
            Console.WriteLine("Enter the car model: ");
            newGreenPlan.Model = Console.ReadLine();
            Console.WriteLine("Enter the car's City MPG: ");
            newGreenPlan.CityMpg = Console.ReadLine();
            Console.WriteLine("Enter the car's Hwy MPG: ");
            newGreenPlan.HwyMpg = Console.ReadLine();
            Console.WriteLine("Enter the car starting MSRP: ");
            string msrpAmtAsString = Console.ReadLine();
            newGreenPlan.Msrp = int.Parse(msrpAmtAsString);
            _greenPlanRepo.UpdateCarByNum(origNum, newGreenPlan);
            Console.WriteLine("Car was successfully updated.");
        }
        //Delete items dialog
        private void DeleteACar()
        {
            //Display options for removal
            ViewAllCars();
            //Get item they want to delete
            Console.WriteLine("Enter the item # you'd like to remove: ");
            string carNumAsString = Console.ReadLine();
            int input = int.Parse(carNumAsString);
            //Call the delete method
            bool wasDeleted = _greenPlanRepo.RemoveCarByNum(input);
            //If deleted, say so
            //Otherwise say it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("Car was sucessfully removed");
            }
            else
            {
                Console.WriteLine("Car could not be removed");
            }
        }
        //Seed 
        private void CarSeeds()
        {
            GreenPlan car1 = new GreenPlan(GreenType.Electric, "Nissan", "Leaf", "123", "99", 31600);
            GreenPlan car2 = new GreenPlan(GreenType.Electric, "Kia", "Niro EV", "123", "102", 39090);
            GreenPlan car3 = new GreenPlan(GreenType.Electric, "Tesla", "Model S", "148", "132", 39990);
            GreenPlan car7 = new GreenPlan(GreenType.Gas, "Hyubdai", "Elantra", "33", "41", 19300);
            GreenPlan car8 = new GreenPlan(GreenType.Gas, "Cheverolet", "Cruze", "31", "48", 17995);
            GreenPlan car5 = new GreenPlan(GreenType.Hybrid, "Ford", "Fusion", "43", "41", 28000);
            GreenPlan car9 = new GreenPlan(GreenType.Gas, "Volkswagon", "Beetle", "26", "33", 20895);
            GreenPlan car4 = new GreenPlan(GreenType.Hybrid, "Toyota", "Prius", "58", "53", 24325);
            GreenPlan car6 = new GreenPlan(GreenType.Hybrid, "Lexus", "ES", "43", "44", 39900);
            _greenPlanRepo.AddCarsToList(car1);
            _greenPlanRepo.AddCarsToList(car2);
            _greenPlanRepo.AddCarsToList(car3);
            _greenPlanRepo.AddCarsToList(car4);
            _greenPlanRepo.AddCarsToList(car5);
            _greenPlanRepo.AddCarsToList(car6);
            _greenPlanRepo.AddCarsToList(car7);
            _greenPlanRepo.AddCarsToList(car8);
            _greenPlanRepo.AddCarsToList(car9);
        }
    }
}



