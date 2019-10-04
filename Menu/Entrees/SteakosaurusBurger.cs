/* SteakosaurusBurger.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
            ingredients.Add("Steakburger Pattie");
            if (bun) ingredients.Add("Whole-Wheat Bun");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole-Wheat Bun");
        }

        /// <summary>
        /// Removes ketchup from the item.
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Removes pickles from the item's ingredients list.
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes kmustard from the item's ingredients list.
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Steakosaurus Burger");
        }
    }
}
