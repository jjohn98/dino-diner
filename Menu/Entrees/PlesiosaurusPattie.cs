///PlesiosaurusPattie.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for storing information about the Plesiosaurus Pattie menu item.
    /// </summary>
    public class PlesiosaurusPattie : Entree
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has peppers.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Stores the value which determines whether or not the item has a bun.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// Also sets the ingredients for the item in accordance with the base class.
        /// </summary>
        public PlesiosaurusPattie()
        {
            this.Price = 5.50;
            this.Calories = 487;
            ingredients.Add("Fish Pattie");
            if (bun) ingredients.Add("Whole-Wheat Bun");
            if (mayo) ingredients.Add("Mayonnaise");

        }

        public void HoldMayo()
        {
            this.mayo = false;
            ingredients.Remove("Mayonnaise");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            ingredients.Remove("Whole-Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Plesiosaurus Pattie");
        }
    }
}
