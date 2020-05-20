using System;
using System.Collections.Generic;
using Menu_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Menu_Repo_Tests
{
    [TestClass]
    public class CafeTests
    {
        private MenuItemsRepo _repo = new MenuItemsRepo();
      //  public List<MenuItems> _listOfMenuItems = new List<MenuItems>();
        [TestInitialize]
        public void SeedItemList()
        {
            MenuItems pbj = new MenuItems(_repo.MenuItemNum(), "PB&J", "Peanutbutter sandwich with veggie sticks", "peanutbutter, grape jelly, bread, carrots, celery", 8.99);
            _repo.AddItemsToList(pbj);
            MenuItems macnCheese = new MenuItems(_repo.MenuItemNum(), "Mac N'Cheese", "Macaroni and cheese with a side of bread", "Macaroni, cheese, bread, butter", 7.99);
            _repo.AddItemsToList(macnCheese);
            MenuItems tunaMelt = new MenuItems(_repo.MenuItemNum(), "Tuna Melt", "Tuna fish sanwich with cheese and grilled served with a side of tomato soup", "Tuna, mayo, pickle relish, cheese slices, bread, butter, tomato soup", 9.99);
            _repo.AddItemsToList(tunaMelt);
        }
        [TestMethod]
        public void RepoItemsCount()
        {
            int initialCount = _repo.GetMenuItems().Count;
            int expected = 3;
            Assert.AreEqual(expected, initialCount);
        }
        [TestMethod]
        public void AddContentCountShouldIncrease()
        {
            int initialCount = _repo.GetMenuItems().Count;
            MenuItems eggs = new MenuItems(_repo.MenuItemNum(), "Eggs", "Eggs with toast", "eggs, butter, bread", 3.99);
            _repo.AddItemsToList(eggs);
            int newCount = _repo.GetMenuItems().Count;
            Assert.AreNotEqual(initialCount, newCount);
        }
        [TestMethod]
        public void GetAllContentShouldGetContent()
        {
            // Arrange
            MenuItems eggs = new MenuItems(_repo.MenuItemNum(), "Eggs", "Eggs with toast", "eggs, butter, bread", 3.99);
            _repo.AddItemsToList(eggs);
            // Act
            MenuItems testContent = _repo.GetMenuItemsByName("Eggs");
            // Assert
            Assert.AreEqual(eggs, testContent);
        }
        [TestMethod]        
        public void UpdateContentShouldUpdate()
        {
            MenuItems newItem = new MenuItems(_repo.MenuItemNum(), "Eggs", "Eggs with toast", "eggs, butter, bread", 99.99);
            _repo.UpdateItemByNum(3,newItem);            
            double expected = 99.99;
            double actual = _repo.GetMenuItemsByNum(3).Price;
            Assert.AreEqual(expected, actual);            
        }
        [TestMethod]
        public void RemoveItemShouldReduceListCount()
        {            
            int before = _repo.GetMenuItems().Count;
            _repo.RemoveItemFromList(1);
            int expected = 2;
            int actual = _repo.GetMenuItems().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}