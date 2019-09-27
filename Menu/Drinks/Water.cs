///Water.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class definition for the Water class which contains its specific values and inherits from the Drink class.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Stores whether or not the water contains a lemon.
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Constructor which creates the object with its default ingredients, price, and calories.
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
            Ingredients.Add("Ice");
            Ingredients.Add("Water");
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
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;

                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Adds lemon to the list of ingredients.
        /// </summary>
        public void AddLemon()
        {
            Ingredients.Add("Lemon");
        }
    }


}
