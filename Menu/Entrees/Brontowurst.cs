/* Brontowurst.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for storing information about the brontowurst menu item.
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has peppers.
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has onions.
        /// </summary>
        private bool onions = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has a bun.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// Also sets the ingredients for the item in accordance with the base class.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            ingredients.Add("Brautwurst");
            if (bun) ingredients.Add("Whole-Wheat Bun");
            if (onions) ingredients.Add("Onion");
            if (peppers) ingredients.Add("Peppers");

        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole-Wheat Bun");
        }

        /// <summary>
        /// Removes peppers from the item's ingredients list.
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
        }

        /// <summary>
        /// Removes onions from the item's ingredients list.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Brontowurst");
        }
    }
}
