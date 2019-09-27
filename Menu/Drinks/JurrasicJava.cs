///JurrasicJava.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Drinks
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
        /// Bool which determines whether or not the coffee is decaffinated.
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Constructor which creates the object with its default ingredients, price, and calories.
        /// </summary>
        public JurrasicJava()
        {
            this.Decaf = false;
            this.Ice = false;
            this.RoomForCream = false;
            this.Price = 0.99;
            this.Calories = 2;
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
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 8;
                        break;

                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Adds ice to the list of ingredients.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            Ingredients.Add("Ice");
        }

        /// <summary>
        /// Sets leave room for cream to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }

        /// <summary>
        /// Sets the decaf value to true.
        /// </summary>
        public void MakeDecaf()
        {
            this.Decaf = true;
        }
    }


}
