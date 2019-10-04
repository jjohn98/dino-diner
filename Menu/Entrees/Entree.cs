/* Entree.cs
 * Author: Jack Johnson
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Default entree class from which each other entree will inherit properties.
    /// </summary>
        public abstract class Entree : IMenuItem
        {
            /// <summary>
            /// List of ingredients specific to each entree.
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
            public virtual List<string> Ingredients { get { return new List<string>(ingredients.ToArray()); } }

        }
}
