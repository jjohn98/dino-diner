﻿///Tyrannotea.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
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
            ingredients.Add("Ice");
            ingredients.Add("Water");
            ingredients.Add("Tea");
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
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Adds Lemon to the list of ingredients.
        /// </summary>
        public void AddLemon()
        {
            if (this.Lemon == false)
            {
                this.Lemon = true;
                ingredients.Add("Lemon");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
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
        /// Adds sugar to the list of ingredients and doubles the calorie value for the tea.
        /// </summary>
        public void AddSugar()
        {
            if (this.Sugar == true)
            {
                this.Sugar = false;
                ingredients.Remove("Cane Sugar");
                this.Calories = this.Calories / 2;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
            }
            else
            {
                this.Sugar = true;
                ingredients.Add("Cane Sugar");
                this.Calories = this.Calories * 2;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(!Sugar)
            return (size.ToString() + " Tyrannotea");
            else
            return (size.ToString() + " Sweet Tyrannotea");
        }

        /// <summary>
        /// Removes ice from the drink.
        /// </summary>
        public override void HoldIce()
        {
            if (this.Ice == true)
            {
                this.Ice = false;
                ingredients.Remove("Ice");
            }
            else
            {
                this.Ice = true;
                ingredients.Add("Ice");
            }
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
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
