/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Jack Johnson
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class stores the information about the Prehistoric PB&J menu item.
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Stores the value which determines whether or not the item has peanut butter.
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Stores the value which determines whether or not the item has jelly.
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// An event handler for PrepertyChanged events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Constructor which initializes the default price and calories of the item.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            ingredients.Add("Bread");
            if (peanutButter) ingredients.Add("Peanut Butter");
            if (jelly) ingredients.Add("Jelly");
        }

        /// <summary>
        /// Removes peanut butter from the item's ingredients list.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes jelly from the item's ingredients list.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            ingredients.Remove("Jelly");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Prehistoric PB&J");
        }

        /// <summary>
        /// Returns the description of this item.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Returns the special cases associated with this instance of the item such as holding part of the ingredients.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter)
                {
                    special.Add("Hold Peanut Butter");
                }
                if (!jelly)
                {
                    special.Add("Hold Jelly");
                }
                return special.ToArray();
            }
        }
        
    }
}
