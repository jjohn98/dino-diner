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
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has sauce.
        /// </summary>
        private bool sauce = true;

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            Ingredients.Add("Chicken");
            if (sauce) Ingredients.Add("Wing Sauce");
        }

        /// <summary>
        /// Removes the sauce from the item's ingredients list.
        /// </summary>
        public void HoldSauce()
        {
            Ingredients.Remove("Wing Sauce");
        }
    }
}
