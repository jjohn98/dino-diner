/* SteakosaurusBurger.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for storing the information about the Steakosaurus Burger menu item.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has pickles.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has ketchup.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has mustard.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
            Ingredients.Add("Steakburger Pattie");
            if (bun) Ingredients.Add("Whole-Wheat Bun");
            if (pickle) Ingredients.Add("Pickle");
            if (ketchup) Ingredients.Add("Ketchup");
            if (mustard) Ingredients.Add("Mustard");
        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            Ingredients.Remove("Whole-Wheat Bun");
        }

        /// <summary>
        /// Removes ketchup from the item.
        /// </summary>
        public void HoldKetchup()
        {
            Ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Removes pickles from the item's ingredients list.
        /// </summary>
        public void HoldPickle()
        {
            Ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes kmustard from the item's ingredients list.
        /// </summary>
        public void HoldMustard()
        {
            Ingredients.Remove("Mustard");
        }
    }
}
