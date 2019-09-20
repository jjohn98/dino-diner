/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Jack Johnson
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
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
            Ingredients.Add("Bread");
            if (peanutButter) Ingredients.Add("Peanut Butter");
            if (jelly) Ingredients.Add("Jelly");
        }

        /// <summary>
        /// Removes peanut butter from the item's ingredients list.
        /// </summary>
        public void HoldPeanutButter()
        {
            Ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// Removes jelly from the item's ingredients list.
        /// </summary>
        public void HoldJelly()
        {
            Ingredients.Remove("Jelly");
        }
    }
}
