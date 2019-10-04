/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Jack Johnson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class stores the information about the Prehistoric PB&J menu item.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has peanut butter.
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has jelly.
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            ingredients.Add("Bread");
            if (peanutButter) ingredients.Add("Peanut Butter");
            if (jelly) ingredients.Add("Jelly");
        }

        /// <summary>
        /// Removes peanut butter from the item's ingredients list.
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Removes jelly from the item's ingredients list.
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Prehistoric PB&J");
        }
    }
}
