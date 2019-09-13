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
    public class SteakosaurusBurger
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

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// This stores the ingredients for the item which changes depending on which parts of the item the customer removes.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole-Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes ketchup from the item.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes pickles from the item's ingredients list.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes kmustard from the item's ingredients list.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
