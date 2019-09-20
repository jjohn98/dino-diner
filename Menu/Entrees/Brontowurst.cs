/* Brontowurst.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
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
            Ingredients.Add("Brautwurst");
            if (bun) Ingredients.Add("Whole-Wheat Bun");
            if (onions) Ingredients.Add("Onion");
            if (peppers) Ingredients.Add("Peppers");

        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            Ingredients.Remove("Whole-Wheat Bun");
        }

        /// <summary>
        /// Removes peppers from the item's ingredients list.
        /// </summary>
        public void HoldPeppers()
        {
            Ingredients.Remove("Peppers");
        }

        /// <summary>
        /// Removes onions from the item's ingredients list.
        /// </summary>
        public void HoldOnion()
        {
            Ingredients.Remove("Onion");
        }
    }
}
