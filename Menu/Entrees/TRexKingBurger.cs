/* TRexKingBurger.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for storing information about the T Rex King Burger menu item.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has tomato.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has onions.
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has pickles.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has ketchup.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has mustard.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has mayo.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Steakburger Pattie");
            if (bun) ingredients.Add("Whole-Wheat Bun");
            if (tomato) ingredients.Add("Tomato");
            if (lettuce) ingredients.Add("Lettuce");
            if (onion) ingredients.Add("Onion");
            if (pickle) ingredients.Add("Pickle");
            if (ketchup) ingredients.Add("Ketchup");
            if (mustard) ingredients.Add("Mustard");
            if (mayo) ingredients.Add("Mayo");
        }

        /// <summary>
        /// Removes the Bun from the item.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole-Wheat Bun");
        }

        /// <summary>
        /// Removes lettuce from the item's ingredients list.
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
        }

        /// <summary>
        /// Removes tomato from the item's ingredients list.
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
        }

        /// <summary>
        /// Removes onions from the item's ingredients list.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        /// <summary>
        /// Removes pickles from the item's ingredients list.
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }

        /// <summary>
        /// Removes ketchup from the item's ingredients list.
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// Removes mustard from the item's ingredients list.
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }

        /// <summary>
        /// Removes mayo from the item's ingredients list.
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("T-Rex King Burger");
        }
    }
}
