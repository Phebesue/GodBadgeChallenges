using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsRepo
{
    public class ClaimsRepo
    {
        public Queue<ClaimsClass> _claimsQueue = new Queue<ClaimsClass>();
        //Read
        public Queue<ClaimsClass> ShowAllClaims()
        {
            return _claimsQueue;
        }
        //Process
        public void ProcessNextClaim()
        {
            ClaimsClass show = _claimsQueue.Peek();
            Console.WriteLine($"   ClaimID: {show.ClaimID}\n\n   Type: {show.ClmType}\n\n   Desc: {show.Description}\n\n   Amount of Claim: ${show.ClaimAmt}\n\n   Date of Incident: {show.DateOfIncident}\n\n   Date of Claim: {show.DateOfClaim} ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nWould you like to process this claim?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n 1. Y \n 2. N");
            string processChoice = Console.ReadLine();
            switch (processChoice)
            {
                case "1":
                case "Y":
                case "y":
                case "yes":
                case "Yes":
                    Console.Clear();
                    _claimsQueue.Dequeue();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n   Claim Processed\n\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "2":
                case "N":
                case "n":
                case "no":
                case "No":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\n  Please enter a valid option.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                    break;
            }
        }
        //Create
        public void EnterNewClaim(ClaimsClass newclaimsClass)
        {
            _claimsQueue.Enqueue(newclaimsClass);
        }
    }
}
