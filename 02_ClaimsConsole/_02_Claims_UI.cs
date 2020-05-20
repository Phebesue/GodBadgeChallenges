using _02_ClaimsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_ClaimsConsole
{
    public class Claims_UI
    {
        private ClaimsRepo _claimsRepo = new ClaimsRepo();
        public void Run()
        {
            SeedClaims();
            ClaimsRunMenu();
        }
        public void ClaimsRunMenu()
        {
            ClaimsUIMenu();
        }
        private void ClaimsUIMenu()
        {
            bool claimsKeepRunning = true;
            while (claimsKeepRunning)
            {
                //Display the opening Menu
                Console.WriteLine("\nWelcome to the Komodo Claims Department! \n \n" +
                    "  Please select an option:\n \n" +
                    "  1. See all claims\n" +
                    "  2. Address next claim\n" +
                    "  3. Enter a new claim\n" +
                    "  4. Exit");
                //Get input
                string claimsSelection = Console.ReadLine();
                //Evaluate input
                switch (claimsSelection)
                {
                    case "1":
                        DisplayClaimsQueue();
                        break;
                    case "2":
                        AddressNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        Console.WriteLine("Have a great day!!");
                        Thread.Sleep(100);
                        claimsKeepRunning = false;
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
        //Display All Claims
        private void DisplayClaimsQueue()
        {
            Queue<ClaimsClass> classClaims = _claimsRepo.ShowAllClaims();
            //Console.WriteLine(_claimsQueue.Count);
            Console.WriteLine($"{"ClaimID",-10} {"Type",-10}{"Description",-25}{"Amount",-15}{"Date of Incident",-20}{"Date of Claim",-20}");
            foreach (ClaimsClass obj in classClaims)
            {
                Console.WriteLine($"  #{obj.ClaimID},       {obj.ClmType}     {obj.Description}       ${obj.ClaimAmt}         {obj.DateOfIncident}         {obj.DateOfClaim} ");
            }
        }
        //Process next Claim
        private void AddressNextClaim()
        {
            Console.Clear();
            _claimsRepo.ProcessNextClaim();
        }
        //Create new Claims dialog
        private void AddNewClaim()
        {
            Console.Clear();
            ClaimsClass newclaimsClass = new ClaimsClass();
            Console.WriteLine("Enter the ClaimID: ");
            string claimNumAsString = Console.ReadLine();
            newclaimsClass.ClaimID = int.Parse(claimNumAsString);
            Console.WriteLine("Select Claim Type: \n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n");
            string claimTypeInput = Console.ReadLine();
            switch (claimTypeInput)            {
                case "1":
                    newclaimsClass.ClmType = ClaimType.Car;
                    break;
                case "2":
                    newclaimsClass.ClmType = ClaimType.Home;
                    break;
                case "3":
                    newclaimsClass.ClmType = ClaimType.Theft;
                    break;
                default:
                    // Invalid input
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\n  Please enter a valid option.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("Enter Description: ");
            newclaimsClass.Description = Console.ReadLine();
            Console.WriteLine("Enter Claim Amount: ");
            string claimAmtAsString = Console.ReadLine();
            newclaimsClass.ClaimAmt = double.Parse(claimAmtAsString);
            Console.WriteLine("Enter Date of Incident: ");
            newclaimsClass.DateOfIncident = Console.ReadLine();
            Console.WriteLine("Enter Date Claim was Reported: ");
            newclaimsClass.DateOfClaim = Console.ReadLine();
            _claimsRepo.EnterNewClaim(newclaimsClass);
        }
        // SeedClaims
        private void SeedClaims()
        {
            ClaimsClass first = new ClaimsClass(1, ClaimType.Car, "car accident on I-275", 800.50, "05/01/2020", "05/19/2020");
            ClaimsClass second = new ClaimsClass(2, ClaimType.Car, "Accident on Stop 11", 600.75, "3/30/2020", "5/12/2020");
            _claimsRepo.EnterNewClaim(first);
            _claimsRepo.EnterNewClaim(second);
            _claimsRepo.EnterNewClaim(new ClaimsClass() { ClaimID = 3, ClmType = ClaimType.Home, Description = "Hail damage to roof", ClaimAmt = 9000.25, DateOfIncident = "5/13/2020", DateOfClaim = "5/20/2020" });
            //Console.WriteLine(_claimsQueue.Count);
        }
    }
}

