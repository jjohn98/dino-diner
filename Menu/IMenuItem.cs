﻿///IMenuItem.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for all available menu items to ensure they all have default functionality.
    /// </summary>
    public interface IMenuItem
    {

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        uint Calories { get;}

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        List<string> Ingredients { get; }
    }
}
