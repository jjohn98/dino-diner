///Tyrannotea.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class definition for the Tyrannotea class which contains its specific values and inherits from the Drink class.
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Stores whether or not the tea contains sugar.
        /// </summary>
        public bool Sugar { get; set; }

        /// <summary>
        /// Stores whether or not the tea contains a lemon.
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Constructor which creates the object with its default ingredients, price, and calories.
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            Ingredients.Add("Ice");
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
        }

        /// <summary>
        /// Sets the sides price and calories depending on the chosen size.
        /// </summary>
        public override Size Size
        {
            set
            {
                Size = value;
                switch (Size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;

                }
            }
            get
            {
                return Size;
            }
        }

        /// <summary>
        /// Adds sugar to the list of ingredients and doubles the calorie value for the tea.
        /// </summary>
        public void AddSugar()
        {
            Ingredients.Add("Cane Sugar");
            this.Calories *= 2;
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
