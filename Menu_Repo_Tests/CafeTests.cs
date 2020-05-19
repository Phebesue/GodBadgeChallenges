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
     //   public List<MenuItems> _listOfMenuItems = new List<MenuItems>();
        [TestInitialize]
        public void SeedItemList()
        {
            //    MenuItems pbj = new MenuItems(_menuItemsRepo.MenuItemNum(), "PB&J", "Peanutbutter sandwich with veggie sticks", "peanutbutter, grape jelly, bread, carrots, celery", 8.99);
            //    _menuItemsRepo.AddItemsToList(pbj);
            //    MenuItems macnCheese = new MenuItems(_menuItemsRepo.MenuItemNum(), "Mac N'Cheese", "Macaroni and cheese with a side of bread", "Macaroni, cheese, bread, butter", 7.99);
            //    _menuItemsRepo.AddItemsToList(macnCheese);
            //    MenuItems tunaMelt = new MenuItems(_menuItemsRepo.MenuItemNum(), "Tuna Melt", "Grilled tuna fish sanwich with cheese served with a side of tomato soup", "Tuna, mayo, pickle relish, cheese slices, bread, butter, tomato soup", 9.99);
            //    _menuItemsRepo.AddItemsToList(tunaMelt);

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
            _repo._listOfMenuItems.
            int initialCount = _repo.GetMenuItems().Count;
            int expected = 3;
            Assert.AreEqual(expected, initialCount);
            //Console.WriteLine(expected +" "+initialCount);
        }
        [TestMethod]
        public void UpdateItemShouldUpdate()
        {
            //MenuItems newContent = new MenuItems("Snatch", "Guy Ritchie movie", 4.8, MaturityRating.R, GenreType.Action);
            //_repo.UpdateContentByTitle("snatch", newContent);
            //// SeedRepo(); <-- Don't need this if it's a [TestInitialize] method
            //GenreType expected = GenreType.Action;
            //GenreType actual = _repo.GetContentByTitle("snatch").Genre;
            //Assert.AreEqual(expected, actual);
        }
    }
}


