///Water.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
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
            ingredients.Add("Ice");
            ingredients.Add("Water");
        }

        /// <summary>
        /// Sets the sides price and calories depending on the chosen size.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
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
            if (this.Lemon == false)
            {
                this.Lemon = true;
                ingredients.Add("Lemon");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
            else
            {
                this.Lemon = false;
                ingredients.Remove("Lemon");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"{size} Water");
        }

        /// <summary>
        /// Removes ice from the drink.
        /// </summary>
        public override void HoldIce()
        {
            ingredients.Remove("Ice");
            this.Ice = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the special cases associated with this instance of the item such as holding part of the ingredients.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice)
                {
                    special.Add("Hold Ice");
                }
                if (Lemon)
                {
                    special.Add("Add Lemon");
                }
                return special.ToArray();
            }
        }
    }


}
