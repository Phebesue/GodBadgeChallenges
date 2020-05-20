using Menu_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu_Repo_Console
{
    class MenuProgramUI
    {
        private MenuItemsRepo _menuItemsRepo = new MenuItemsRepo();
        public void Run()
        {
            SeedItemList();
            RunMenu();
        }
        public void RunMenu()
        {
            UIMenu();
        }
        //Method that starts Menu CRUD interactions
        private void UIMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display the options
                Console.WriteLine("Welcome! \n" +
                    "Select an option: \n" +
                    "1. Create a new menu item\n" +
                    "2. View all items\n" +
                    "3. Update menu items\n" +
                    "4. Delete item\n" +
                    "5. Exit");
                //Get input
                string selection = Console.ReadLine();
                //Evaluate Input
                switch (selection)
                {
                    case "1":
                        CreateNewItem();
                        break;
                    case "2":
                        DisplayAllItems();
                        break;
                    case "3":
                        UpdateItem();
                        break;
                    case "4":
                        RemoveItem();
                        break;
                    case "5":
                        Console.WriteLine("Have a great day!!");
                        Thread.Sleep(2500);
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press anykey to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Create new Items dialog
        private void CreateNewItem()
        {
            Console.Clear();
            MenuItems newMenuItem = new MenuItems();
            newMenuItem.MealNum = _menuItemsRepo.MenuItemNum();
            Console.WriteLine("Enter the new meal name: ");
            newMenuItem.MealName = Console.ReadLine();
            //MenuItem Description
            Console.WriteLine("Enter the meal description: ");
            newMenuItem.MealDesc = Console.ReadLine();
            //Ingredients 
            Console.WriteLine("Please enter the ingredients: ");
            newMenuItem.Ingredients = Console.ReadLine();
            //Price ;
            Console.WriteLine("Please enter the price: ");
            string priceAsString = Console.ReadLine();
            newMenuItem.Price = double.Parse(priceAsString);
            _menuItemsRepo.AddItemsToList(newMenuItem);
            Console.WriteLine("New item added!");
        }
        //View current items dialog
        private void DisplayAllItems()
        {
            Console.Clear();
            List<MenuItems> menuItems = _menuItemsRepo.GetMenuItems();
            int mealCount = 1;
            foreach (MenuItems item in menuItems)
            {
                item.MealNum = mealCount;
                DisplayItemsByNum(item);
                mealCount++;
            }
        }
        private void DisplayItemsByNum(MenuItems item)
        {
            Console.WriteLine($"{item.MealNum}. {item.MealName} ${item.Price} Desc: {item.MealDesc}");
        }
        //Update items dialog
        private void UpdateItem()
        {
            //Display options for update
            DisplayAllItems();
            //Get item they want to update
            Console.WriteLine("Enter the item # you'd like to update: ");
            string menuNumAsString = Console.ReadLine();
            int originalNum = int.Parse(menuNumAsString);
            //Take in updated info
            MenuItems newMenuItem = new MenuItems();
            //MenuItem.MealNum = _menuItemsRepo.MenuItemNum();
            Console.WriteLine("Enter the new meal name: ");
            newMenuItem.MealName = Console.ReadLine();
            //MenuItem Description
            Console.WriteLine("Enter the meal description: ");
            newMenuItem.MealDesc = Console.ReadLine();
            //Ingredients 
            Console.WriteLine("Please enter the ingredients: ");
            newMenuItem.Ingredients = Console.ReadLine();
            //Price ;
            Console.WriteLine("Please enter the price: ");
            string priceAsString = Console.ReadLine();
            newMenuItem.Price = double.Parse(priceAsString);
            _menuItemsRepo.UpdateItemByNum(originalNum, newMenuItem);
            Console.WriteLine("Item was successfully updated.");
        }
        //Delete items dialog
        private void RemoveItem()
        {
            //Display options for removal
            DisplayAllItems();
            //Get item they want to delete
            Console.WriteLine("Enter the item # you'd like to remove: ");
            string menuNumAsString = Console.ReadLine();
            int input = int.Parse(menuNumAsString);
            //Call the delete method
            bool wasDeleted = _menuItemsRepo.RemoveItemFromList(input);
            //If deleted, say so
            //Otherwise say it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("Item was sucessfully removed");
            }
            else
            {
                Console.WriteLine("Item could not be removed");
            }

        }
        //Seed 
        private void SeedItemList()
        {
            MenuItems pbj = new MenuItems(_menuItemsRepo.MenuItemNum(), "PB&J", "Peanutbutter sandwich with veggie sticks", "peanutbutter, grape jelly, bread, carrots, celery", 8.99);
            _menuItemsRepo.AddItemsToList(pbj);
            MenuItems macnCheese = new MenuItems(_menuItemsRepo.MenuItemNum(), "Mac N'Cheese", "Macaroni and cheese with a side of bread", "Macaroni, cheese, bread, butter", 7.99);
            _menuItemsRepo.AddItemsToList(macnCheese);
            MenuItems tunaMelt = new MenuItems(_menuItemsRepo.MenuItemNum(), "Tuna Melt", "Grilled tuna fish sanwich with cheese served with a side of tomato soup", "Tuna, mayo, pickle relish, cheese slices, bread, butter, tomato soup", 9.99);
            _menuItemsRepo.AddItemsToList(tunaMelt);
        }
    }
}