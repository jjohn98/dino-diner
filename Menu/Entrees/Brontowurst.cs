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
    public class Brontowurst
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

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// This stores the ingredients for the item which changes depending on which parts of the item the customer removes.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole-Wheat Bun");
                if (onions) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes peppers from the item's ingredients list.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes onions from the item's ingredients list.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
