/* VelociWrap.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class for storing the information about the VelociWrap menu item.
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has dressing.
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has a tortilla.
        /// </summary>
        private bool tortilla = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has cheese.
        /// </summary>
        private bool cheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// This stores the ingredients for the item which changes depending on which parts of the item the customer removes.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Breast" };
                if (tortilla) ingredients.Add("Flour Tortilla");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Caesar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Removes the tortilla from the item's ingredients list. (May or may not be disabled in the future.)
        /// </summary>
        public void HoldTortilla()
        {
            this.tortilla = false;
        }

        /// <summary>
        /// Removes the dressing from the item's ingredients list.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Removes lettuce from the item's ingredients list.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes cheese from the item's ingredients list.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
