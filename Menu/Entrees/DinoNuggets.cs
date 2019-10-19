/* DinoNuggets.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for storing information about the dino nuggets menu item.
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Stores the value which holds the number of nuggets the customer orders.
        /// </summary>
        private int nuggetCount = 6;

        /// <summary>
        /// This stores the ingredients for the item which changes depending on how many nuggets the customer orders.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor which initializes the default price and calories of the nuggets.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        /// <summary>
        /// Adds a nugget and increases the price and calories accordingly.
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount += 1;
            this.Price += 0.25;
            this.Calories += 59;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Dino-Nuggets");
        }

        /// <summary>
        /// Returns the special cases associated with this instance of the item such as holding part of the ingredients.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggetCount > 6)
                {
                    special.Add($"{nuggetCount - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }
    }
}
