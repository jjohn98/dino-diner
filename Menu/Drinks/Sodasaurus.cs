///Sodasaurus.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definition for the Sodasaurus class which contains its specific values and inherits from the Drink class.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Private backing Variable for sodasaurus flavor.
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Stores the value of the flavor of the soda.
        /// </summary>
        public SodasaurusFlavor Flavor { get { return flavor; } set { flavor = value; NotifyOfPropertyChanged("Description"); } }

        /// <summary>
        /// Constructor which creates the object with its default ingredients, price, and calories.
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            ingredients.Add("Ice");
            ingredients.Add("Water");
            ingredients.Add("Cane Sugar");
            ingredients.Add("Natural Flavors");
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

        /// <summary>
        /// Removes ice from the drink.
        /// </summary>
        public override void HoldIce()
        {
            if (this.Ice == true)
            {
                this.Ice = false;
                Ingredients.Remove("Ice");
            }
            else
            {
                this.Ice = true;
                Ingredients.Add("Ice");
            }
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"{size} {Flavor} Sodasaurus");
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
                return special.ToArray();
            }
        }
    }

    
}
