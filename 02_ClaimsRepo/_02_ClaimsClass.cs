using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsRepo
{
    public enum ClaimType { Car = 1, Home, Theft }
    public class ClaimsClass
    {
        public int ClaimID { get; set; }
        public  ClaimType ClmType{ get; set; }
        public string Description { get; set; }
        public double ClaimAmt { get; set; }
        public string DateOfIncident { get; set; }
        public string DateOfClaim { get; set; }

        public ClaimsClass() { }
        public ClaimsClass(int claimID, ClaimType claimType, string description, double claimAmt, string dateOfIncident, string dateOfClaim)
        {
            ClaimID = claimID;
            ClmType = claimType;
            Description = description;
            ClaimAmt = claimAmt;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }

    }
}
