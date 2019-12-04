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
        /// <summary>
        /// 
        /// </summary>
        public Menu menu;

        /// <summary>
        /// 
        /// </summary>
        public MenuModel()
        {
            menu = new Menu();
            combos = menu.AvailableCombos;
            entrees = menu.AvailableEntrees;
            sides = menu.AvailableSides;
            drinks = menu.AvailableDrinks;
        }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public double? minPrice { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public double? maxPrice { get; set; } = 15;

        /// <summary>
        /// 
        /// </summary>
        
        public List<IMenuItem> entrees { get; set; } = null;

        /// <summary>
        /// 
        /// </summary>
        
        public List<IMenuItem> sides { get; set; } = null;

        /// <summary>
        /// 
        /// </summary>
        
        public List<IMenuItem> drinks { get; set; } = null;

        /// <summary>
        /// 
        /// </summary>
        
        public List<IMenuItem> combos { get; set; } = null;

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="searchstring"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        public void OnGet()
        {
            if (menu == null) 
            {
                menu = new Menu();
            }

            combos = menu.AvailableCombos;
            entrees = menu.AvailableEntrees;
            sides = menu.AvailableSides;
            drinks = menu.AvailableDrinks;
        }

        public void OnPost()
        {
            if (menu == null) 
            {
                menu = new Menu();
            }

            combos = menu.AvailableCombos;
            entrees = menu.AvailableEntrees;
            sides = menu.AvailableSides;
            drinks = menu.AvailableDrinks;

            if (search != null) 
            {
                combos = menu.Search(combos, search);
                entrees = menu.Search(entrees, search);
                sides = menu.Search(sides, search);
                drinks = menu.Search(drinks, search);
            }

            if (menuCategory.Count > 0) 
            {
                if(!menuCategory.Contains("Combo"))
                {
                    combos = new List<IMenuItem>();
                }
                if (!menuCategory.Contains("Entree"))
                {
                    entrees = new List<IMenuItem>();
                }
                if (!menuCategory.Contains("Side"))
                {
                    sides = new List<IMenuItem>();
                }
                if (!menuCategory.Contains("Drink"))
                {
                    drinks = new List<IMenuItem>();
                }
            }

            if (minPrice is double min) 
            {
                combos = menu.FilterByMinPrice(combos, min);
                entrees = menu.FilterByMinPrice(entrees, min);
                sides = menu.FilterByMinPrice(sides, min);
                drinks = menu.FilterByMinPrice(drinks, min);
            }

            if (maxPrice is double max)
            {
                combos = menu.FilterByMaxPrice(combos, max);
                entrees = menu.FilterByMaxPrice(entrees, max);
                sides = menu.FilterByMaxPrice(sides, max);
                drinks = menu.FilterByMaxPrice(drinks, max);
            }

            if (excludedIngredients.Count > 0)
            {
                combos = menu.FilterByIngredients(combos, excludedIngredients);
                entrees = menu.FilterByIngredients(entrees, excludedIngredients);
                sides = menu.FilterByIngredients(sides, excludedIngredients);
                drinks = menu.FilterByIngredients(drinks, excludedIngredients);
            }
        }
    }
}