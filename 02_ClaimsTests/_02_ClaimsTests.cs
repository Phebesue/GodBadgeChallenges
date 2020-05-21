using System;
using _02_ClaimsRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTests
{
    [TestClass]
    public class ClaimsTests
    {
        private ClaimsRepo _repo = new ClaimsRepo();
        [TestInitialize]
        public void SeedClaims()
        {
            ClaimsClass first = new ClaimsClass(1, ClaimType.Car, "car accident on I-74", 3000.52, "05/01/2020", "05/19/2020");
            _repo.EnterNewClaim(first);
            _repo.EnterNewClaim(new ClaimsClass() { ClaimID = 2, ClmType = ClaimType.Theft, Description = "Stolen TV", ClaimAmt = 1600.85, DateOfIncident = "3/13/2020", DateOfClaim = "5/20/2020" });
            _repo.EnterNewClaim(new ClaimsClass() { ClaimID = 3, ClmType = ClaimType.Home, Description = "Hail damage to roof", ClaimAmt = 9000.25, DateOfIncident = "5/13/2020", DateOfClaim = "5/20/2020" });
        }
        [TestMethod]

        public void RepoItemsCount()
        {
            int initialCount = _repo.ShowAllClaims().Count;
            int expected = 3;
            Assert.AreEqual(expected, initialCount);
        }
        [TestMethod]
        public void AddClaimCountShouldIncrease()
        {
            int initialCount = _repo.ShowAllClaims().Count;
            ClaimsClass fourth = new ClaimsClass(4, ClaimType.Car, "Accident on Stop 11", 600.75, "3/30/2019", "5/12/2020");
            _repo.EnterNewClaim(fourth);
            int newCount = _repo.ShowAllClaims().Count;
            Assert.AreNotEqual(initialCount, newCount);

        }
        [TestMethod]
        public void GetPeekClaimsShouldGetContent()
        {           
            ClaimsClass testContent = _repo.Peek();
           
            Assert.AreEqual(3000.52, testContent.ClaimAmt);

        }
        [TestMethod]
        public void DequeueClaimCountShouldDecrease()
        {
            int initialCount = _repo.ShowAllClaims().Count;
            _repo.DequeueClaim();
            int newCount = _repo.ShowAllClaims().Count;
            Assert.AreNotEqual(initialCount, newCount);
        }
    }
}
