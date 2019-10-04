/* VelociWrap.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
            ingredients.Add("Chicken Breast");
            if (tortilla) ingredients.Add("Flour Tortilla");
            if (lettuce) ingredients.Add("Romaine Lettuce");
            if (dressing) ingredients.Add("Caesar Dressing");
            if (cheese) ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// Removes the tortilla from the item's ingredients list. (May or may not be disabled in the future.)
        /// </summary>
        public void HoldTortilla()
        {
            ingredients.Remove("Tortilla");
        }

        /// <summary>
        /// Removes the dressing from the item's ingredients list.
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Caesar Dressing");
        }

        /// <summary>
        /// Removes lettuce from the item's ingredients list.
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// Removes cheese from the item's ingredients list.
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Veloci-Wrap");
        }
    }
}
