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
    public class PrehistoricPBJ
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has peanut butter.
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has jelly.
        /// </summary>
        private bool jelly = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// This stores the ingredients for the item which changes depending on which parts of the item the customer removes.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes peanut butter from the item's ingredients list.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Removes jelly from the item's ingredients list.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
