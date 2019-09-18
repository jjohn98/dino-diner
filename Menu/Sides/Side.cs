using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// 
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    

    public abstract class Side
    {
        /// <summary>
        /// 
        /// </summary>
        protected List<string> ingredients;

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
        public List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
