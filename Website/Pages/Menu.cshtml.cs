using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu;

        public MenuModel()
        {
            menu = new Menu();
            entrees = menu.AvailableEntrees;
            sides = menu.AvailableSides;
            drinks = menu.AvailableDrinks;
            combos = menu.AvailableCombos;
        }

        public double minPrice = 0;

        public double maxPrice = 10;

        public List<IMenuItem> entrees = new List<IMenuItem>();

        public List<IMenuItem> sides = new List<IMenuItem>();

        public List<IMenuItem> drinks = new List<IMenuItem>();

        public List<IMenuItem> combos = new List<IMenuItem>();

        public static List<IMenuItem> Search(List<IMenuItem> items, string searchstring)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in items)
            {
                if (item.ToString().Contains(searchstring, StringComparison.CurrentCultureIgnoreCase))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public void OnGet()
        {
            
        }
    }
}