/* PterodactylWings.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
            ingredients.Add("Chicken");
            if (sauce) ingredients.Add("Wing Sauce");
        }

        /// <summary>
        /// Removes the sauce from the item's ingredients list.
        /// </summary>
        public void HoldSauce()
        {
            ingredients.Remove("Wing Sauce");
        }
        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }

    }
}
