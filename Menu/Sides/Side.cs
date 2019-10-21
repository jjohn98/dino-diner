/* Side.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Determines the size of the side.
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    

    public abstract class Side : IMenuItem , INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// List of ingredients specific to each side.
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get { return new List<string>(ingredients.ToArray()); } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Returns the special cases associated with this instance of the item such as holding part of the ingredients.
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }

        }

        /// <summary>
        /// Returns the description of this item.
        /// </summary>
        public virtual string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Stores the event handler which changes when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method for the properties to be notified of changes.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
