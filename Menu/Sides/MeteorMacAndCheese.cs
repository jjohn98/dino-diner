/* MeteorMacAndCheese.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class definition to the MeteorMacAndCheese Side
    /// which stores its size, price, calories, and ingredients.
    /// </summary>
    public class MeteorMacAndCheese: Side
    {
        /// <summary>
        /// Stores the enumerated size of the side.
        /// </summary>
        private Size size;

        /// <summary>
        /// Constructor for the side which sets its default size and ingredients.
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            Ingredients.Add("Macaroni Noodles");
            Ingredients.Add("Cheese Product");
            Ingredients.Add("Pork Sausage");
        }

        /// <summary>
        /// Sets the sides price and calories depending on the chosen size.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;

                }
            }
            get
            {
                return size;
            }
        }
    }
}
