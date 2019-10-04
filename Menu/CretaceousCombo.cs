/// CretaceousCombo.cs
/// Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definition for the combo which includes an entree, side, and drink.
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Stores the entree for the combo.
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Stores the value of the side for the combo.
        /// </summary>
        private Side side;

        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side { get { return Side; } set { side = value; side.Size = size; } }

        /// <summary>
        /// Stores the drink for the combo.
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Gets and sets the drink.
        /// </summary>
        public Drink Drink { get { return Drink; } set { drink = value; drink.Size = size; } }

        /// <summary>
        /// Gets the price for the combo including the combo discount.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories for the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Stores the size of the combo.
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets and sets the size of the combo.
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// List which contains the ingredients for all 3 elements of the combo.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        double IMenuItem.Price
        {
            get
            {
                return Price;
            }

            set
            {

            }
        }
        uint IMenuItem.Calories
        {
            get
            {
                return Calories;
            }
            set
            {

            }
        }

        /// <summary>
        /// Constructor for the combo which has default size and drink.
        /// </summary>
        /// <param name="e"></param>
        public CretaceousCombo(Entree e)
        {
            Entree = e;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"{Entree} Combo");
        }
    }
}
