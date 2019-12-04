/// Menu.cs
/// Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class which contains lists for all of the available menu items in DinoDiner.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Lists all available menu items at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new PrehistoricPBJ(),
            new DinoNuggets(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap(),
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots(),
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water(),
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };

        /// <summary>
        /// Lists all available entrees at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableEntrees { get; } = new List<IMenuItem>()
        {
            new Brontowurst(),
            new PrehistoricPBJ(),
            new DinoNuggets(),
            new PterodactylWings(),
            new SteakosaurusBurger(),
            new TRexKingBurger(),
            new VelociWrap()
        };

        /// <summary>
        /// Lists all available sides at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableSides { get; } = new List<IMenuItem>()
        {
            new Fryceritops(),
            new MeteorMacAndCheese(),
            new MezzorellaSticks(),
            new Triceritots()
        };

        /// <summary>
        /// Lists all available drinks at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableDrinks { get; } = new List<IMenuItem>()
        {
            new JurassicJava(),
            new Sodasaurus(),
            new Tyrannotea(),
            new Water()
        };

        /// <summary>
        /// Lists all available entree combos at DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableCombos { get; } = new List<IMenuItem>()
        {
            new CretaceousCombo(new Brontowurst()),
            new CretaceousCombo(new PrehistoricPBJ()),
            new CretaceousCombo(new DinoNuggets()),
            new CretaceousCombo(new PterodactylWings()),
            new CretaceousCombo(new SteakosaurusBurger()),
            new CretaceousCombo(new TRexKingBurger()),
            new CretaceousCombo(new VelociWrap())
        };

        /// <summary>
        /// Adds every available menu item to a string separated by new lines.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "";

            foreach (IMenuItem item in AvailableMenuItems)
            {
                output += item.ToString();
                output += "\n";
            }

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<string> PossibleIngredients
        {
            get 
            {
                HashSet<string> ingredients = new HashSet<string>();

                foreach (IMenuItem item in AvailableMenuItems) 
                {
                    ingredients.UnionWith(item.Ingredients);
                }

                List<string> filteredingredients = ingredients.OrderBy(ingredient => ingredient).ToList();

                return filteredingredients;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<IMenuItem> Search(List<IMenuItem> menuItems, string search) 
        {
            List<IMenuItem> searchResults = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems) 
            {
                if (item.ToString().ToLower().Contains(search.ToLower())) 
                {
                    searchResults.Add(item);
                }
            }

            return searchResults;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="minPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> menuItems, double minPrice) 
        {
            List<IMenuItem> searchResults = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if (item.Price >= minPrice)
                {
                    searchResults.Add(item);
                }
            }

            return searchResults;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="maxPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menuItems, double maxPrice)
        {
            List<IMenuItem> searchResults = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if (item.Price <= maxPrice)
                {
                    searchResults.Add(item);
                }
            }

            return searchResults;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="excludedIngredients"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> menuItems, List<string> excludedIngredients) 
        {
            List<IMenuItem> searchResults = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems) 
            {
                bool flag = true;

                foreach (string ingredient in excludedIngredients) 
                {
                    if (item.Ingredients.Contains(ingredient)) 
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag) 
                {
                    searchResults.Add(item);
                }
            }

            return searchResults;
        }

    }
}
