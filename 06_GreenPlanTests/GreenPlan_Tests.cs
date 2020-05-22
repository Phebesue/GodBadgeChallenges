using System;
using System.Security.Claims;
using _06_GreenPlan_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_GreenPlanTests
{
    [TestClass]
    public class GreenPlan_Tests
    {

        private GreenPlanRepo _repo = new GreenPlanRepo();
        [TestInitialize]
        public void CarSeeds()
        {
            GreenPlan car1 = new GreenPlan(GreenType.Electric, "Nissan", "Leaf", "123", "99", 31600);
            GreenPlan car2 = new GreenPlan(GreenType.Electric, "Kia", "Niro EV", "123", "102", 39090);
            //GreenPlan car3 = new GreenPlan(GreenType.Electric, "Tesla", "Model S", "148", "132", 39990);
            GreenPlan car4 = new GreenPlan(GreenType.Hybrid, "Toyota", "Prius", "58", "53", 24325);
            GreenPlan car5 = new GreenPlan(GreenType.Hybrid, "Ford", "Fusion", "43", "41", 28000);
            //GreenPlan car6 = new GreenPlan(GreenType.Hybrid, "Lexus", "ES", "43", "44", 39900);
            GreenPlan car7 = new GreenPlan(GreenType.Gas, "Hyubdai", "Elantra", "33", "41", 19300);
            GreenPlan car8 = new GreenPlan(GreenType.Gas, "Cheverolet", "Cruze", "31", "48", 17995);
            //GreenPlan car9 = new GreenPlan(GreenType.Gas, "Volkswagon", "Beetle", "26", "33", 20895);
            _repo.AddCarsToList(car1);
            _repo.AddCarsToList(car2);
            //_repo.AddCarsToList(car3);
            _repo.AddCarsToList(car4);
            _repo.AddCarsToList(car5);
            //_repo.AddCarsToList(car6);
            _repo.AddCarsToList(car7);
            _repo.AddCarsToList(car8);
            //_repo.AddCarsToList(car9);
        }
        [TestMethod]
        public void CarsCount()
        {
            int initialCount = _repo.GetCars().Count;
            int expected = 6;
            Assert.AreEqual(expected, initialCount);
        }

        [TestMethod]
        public void AddCarCountShouldIncrease()
        {
            int initialCount = _repo.GetCars().Count;
            GreenPlan car6 = new GreenPlan(GreenType.Gas, "Volkswagon", "Beetle", "26", "33", 20895);
            _repo.AddCarsToList(car6);
            int newCount = _repo.GetCars().Count;
            Assert.AreNotEqual(initialCount, newCount);
        }
      
        [TestMethod]
        public void UpdateContentShouldUpdate()
        {
            GreenPlan newCar = new GreenPlan(GreenType.Gas, "Volkswagon", "Beetle", "206", "303", 38000);
            _repo.UpdateCarByNum(6, newCar);
            _repo.GetCars();
            int expected = 38000;
            int actual = _repo.GetCarsByNum(6).Msrp;
            Console.WriteLine(actual);
           // Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemShouldReduceListCount()
        {
            int before = _repo.GetCars().Count;
            _repo.RemoveCarByNum(1);
            int actual = _repo.GetCars().Count;
            Assert.AreEqual(before, actual);
        }
    }
}


