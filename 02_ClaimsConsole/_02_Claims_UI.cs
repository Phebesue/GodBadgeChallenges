using _02_ClaimsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_ClaimsConsole
{
    public class Claims_UI
    {
        private ClaimsRepo _claimsRepo = new ClaimsRepo();
        private Queue<ClaimsClass> _claimsQueue = new Queue<ClaimsClass>();

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
                    "Please select an option:\n \n" +
                    "1. See all claims\n" +
                    "2. Address next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit");
                //Get input
                string claimsSelection = Console.ReadLine();
                //Evaluate input
                switch (claimsSelection)
                {
                    case "1":
                        DisplayClaimsQueue();
                        break;
                    case "2":
                        ProcessNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        Console.WriteLine("Have a great day!!");
                        Thread.Sleep(2500);
                        claimsKeepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Press anykey to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Display All Claims
        private void DisplayClaimsQueue()
        {
            Console.Clear();
            _claimsQueue.Count;


        }


        //Process next Claim
        private void ProcessNextClaim()
        {
            Console.Clear();

        }

        //Create new Claims dialog
        private void AddNewClaim()
        {
            Console.Clear();

        }
        // SeedClaims
        private void SeedClaims()

        {
            _claimsQueue.Enqueue(new ClaimsClass() { ClaimID = 1, ClmType = ClaimType.Car, Description = "car accident on I-275", ClaimAmt = 800.50, DateOfIncident = "05 / 01 / 2020", DateOfClaim = "05 / 19 / 2020" });

            _claimsQueue.Enqueue(new ClaimsClass() { ClaimID = 2, ClmType = ClaimType.Car, Description = "Accident on Stop 11", ClaimAmt = 600.75, DateOfIncident = "3/30/2020", DateOfClaim = "5/12/2020" });
            _claimsQueue.Enqueue(new ClaimsClass() { ClaimID = 3, ClmType = ClaimType.Home, Description = "Hail damage to roof", ClaimAmt = 9000.25, DateOfIncident = "5/13/2020", DateOfClaim = "5/20/2020" });

        }
    }
}

