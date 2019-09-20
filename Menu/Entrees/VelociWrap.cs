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
    public class VelociWrap : Entree
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

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
            Ingredients.Add("Chicken Breast");
            if (tortilla) Ingredients.Add("Flour Tortilla");
            if (lettuce) Ingredients.Add("Romaine Lettuce");
            if (dressing) Ingredients.Add("Caesar Dressing");
            if (cheese) Ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// Removes the tortilla from the item's ingredients list. (May or may not be disabled in the future.)
        /// </summary>
        public void HoldTortilla()
        {
            Ingredients.Remove("Tortilla");
        }

        /// <summary>
        /// Removes the dressing from the item's ingredients list.
        /// </summary>
        public void HoldDressing()
        {
            Ingredients.Remove("Caesar Dressing");
        }

        /// <summary>
        /// Removes lettuce from the item's ingredients list.
        /// </summary>
        public void HoldLettuce()
        {
            Ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// Removes cheese from the item's ingredients list.
        /// </summary>
        public void HoldCheese()
        {
            Ingredients.Remove("Parmesan Cheese");
        }
    }
}
