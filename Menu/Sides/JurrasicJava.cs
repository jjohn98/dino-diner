///JurrasicJava.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class definition for the JurrasicJava class which contains its specific values and inherits from the Drink class.
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Bool which stores the value of whether or not room is left for cream.
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Constructor which creates the object with its default ingredients, price, and calories.
        /// </summary>
        public JurrasicJava()
        {
            this.RoomForCream = false;
            this.Price = 0.99;
            this.Calories = 8;
            Ingredients.Add("Coffee");
            Ingredients.Add("Water");

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
        /// Adds ice to the list of ingredients.
        /// </summary>
        public void AddIce()
        {
            Ingredients.Add("Ice");
        }

        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
    }


}
