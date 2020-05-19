using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Repo
{
    public class MenuItems
    {
        public int MealNum { get; set; }
        public string MealName { get; set; }
        public string MealDesc { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        //Empty Constructor
        public MenuItems() { }

        //Overloaded Constructor
        public MenuItems(int mealNum,string mealName, string mealDesc, string ingredients, double price)
        {

            MealNum = mealNum;
            MealName = mealName;
            MealDesc = mealDesc;
            Ingredients = ingredients;
            Price = price;
        }

    }
}


