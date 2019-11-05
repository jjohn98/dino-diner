/// CretaceousCombo.cs
/// Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definition for the combo which includes an entree, side, and drink.
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Stores the entree for the combo.
        /// </summary>
        public Entree Entree {
            get
            {
                return entree;
            }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };         
            }
        }

        /// <summary>
        /// private backing variable for the combo's entree.
        /// </summary>
        private Entree entree;


        /// <summary>
        /// Stores the value of the side for the combo.
        /// </summary>
        private Side side;

        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side { get { return side; }
            set
            {
                side = value;
                side.Size = size;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                side.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                    NotifyOfPropertyChanged("Special");
                };
            }
        }

        /// <summary>
        /// Stores the drink for the combo.
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Gets and sets the drink.
        /// </summary>
        public Drink Drink { get { return drink; }
            set
            {
                drink = value;
                drink.Size = size;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                drink.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                    NotifyOfPropertyChanged("Special");
                };
            } }

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
        /// Event for changing properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method the the property changed field.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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

                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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

        /// <summary>
        /// IMenuItem price required to implement the interface.
        /// </summary>
        double IMenuItem.Price
        {
            get
            {
                return Price;
            }
        }

        /// <summary>
        /// IMenuItem calories required to implement the interface.
        /// </summary>
        uint IMenuItem.Calories
        {
            get
            {
                return Calories;
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

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// String array that contains the special cases of the combo such as holding part of the ingredients.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
    }
}
