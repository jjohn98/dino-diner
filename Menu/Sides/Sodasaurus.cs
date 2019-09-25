///Sodasaurus.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class definition for the Sodasaurus class which contains its specific values and inherits from the Drink class.
    /// </summary>
    public class Sodasaurus : Drink
    {

        /// <summary>
        /// Stores the value of the flavor of the soda.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// Constructor which creates the object with its default ingredients, price, and calories.
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            Ingredients.Add("Ice");
            Ingredients.Add("Water");
            Ingredients.Add("Cane Sugar");
            Ingredients.Add("Natural Flavors");
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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
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
