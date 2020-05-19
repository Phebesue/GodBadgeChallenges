using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Repo
{
    public class MenuItemsRepo
    {
        private  List<MenuItems> _listOfMenuItems = new List<MenuItems>();
        //Create
        public void AddItemsToList(MenuItems item)
        {
            _listOfMenuItems.Add(item);            
        }

        //Read
        public List<MenuItems> GetMenuItems()
        {
          //  Console.Clear();
            return _listOfMenuItems;
        }
        public int MenuItemNum()
        { 
            int mealNum = 1+_listOfMenuItems.Count;
            return mealNum;
        }
        //Update
        public bool UpdateItemByNum(int originalNum, MenuItems item)
        {
            //Find the Item
            MenuItems oldItem = GetMenuItemsByNum(originalNum);
            //Update the Item
            if (oldItem != null)
            {
                oldItem.MealName = item.MealName;
                oldItem.MealDesc = item.MealDesc;
                oldItem.Ingredients = item.Ingredients;
                oldItem.Price = item.Price;

                return true;
            }
            else
            {
                return false;
            }

        }

        //Delete
        public bool RemoveItemFromList(int menuNum)
        {
            MenuItems item = GetMenuItemsByNum(menuNum);
            if (item == null)
            {
                return false;
            }

            int initialCount = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(item);
            if (initialCount > _listOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper
        public MenuItems GetMenuItemsByName(string menuName)
        {
            foreach (MenuItems item in _listOfMenuItems)
            {
                if (item.MealName == menuName)
                {
                    return item;
                }
            }

            return null;
        }
        public MenuItems GetMenuItemsByNum(int menuNum)
        {
            foreach (MenuItems item in _listOfMenuItems)
            {
                if (item.MealNum == menuNum)
                {
                    return item;
                }
            }
            
            return null;
        }

    }
}
