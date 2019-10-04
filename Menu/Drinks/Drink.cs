///Drink.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{

        /// <summary>
        /// Determines the flavor of the sodasaurus drink.
        /// </summary>
        public enum SodasaurusFlavor
        {
            Cola, Orange, RootBeer, Lime, Cherry, Vanilla, Grape, Chocolate
        }

        public abstract class Drink : IMenuItem
        {
            /// <summary>
            /// List of ingredients specific to each drink.
            /// </summary>
            protected List<string> ingredients = new List<string>();
            
            /// <summary>
            /// Holds the size as a field for each drink.
            /// </summary>
            protected Size size = Size.Small;

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
            /// Gets and sets whether or not the drink contains ice.
            /// </summary>
            public virtual bool Ice { get; set; } = true;

            /// <summary>
            /// Removes ice from the drinks ingredients list.
            /// </summary>
            public virtual void HoldIce()
            {
                this.Ice = false;
                Ingredients.Remove("Ice");
            }
        }
    }
