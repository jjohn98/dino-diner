/* PterodactylWings.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for storing information about the Pterodactyl Wings menu item.
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has sauce.
        /// </summary>
        private bool sauce = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// This stores the ingredients for the item which changes depending on which parts of the item the customer removes.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                if (sauce) ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Removes the sauce from the item's ingredients list.
        /// </summary>
        public void HoldSauce()
        {
            this.sauce = false;
        }
    }
}
