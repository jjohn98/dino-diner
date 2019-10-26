///IOrderItem.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for all available order items to ensure they all have default functionality.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {


        /// <summary>
        /// Gets and sets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Returns the description of this item.
        /// </summary>
        string Description
        {
            get;
        }

        /// <summary>
        /// Returns the special conditions of this item.
        /// </summary>
        string[] Special
        {
            get;
        }
    }
}
