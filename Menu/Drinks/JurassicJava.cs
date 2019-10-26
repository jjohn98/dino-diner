///JurrasicJava.cs
///Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definition for the JurrasicJava class which contains its specific values and inherits from the Drink class.
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Bool which stores the value of whether or not room is left for cream.
        /// </summary>
        public bool RoomForCream { get; set; }

        private bool decaf;

        /// <summary>
        /// Bool which determines whether or not the coffee is decaffinated.
        /// </summary>
        public bool Decaf { get { return decaf; } set { decaf = value; NotifyOfPropertyChanged("Description"); } }

        /// <summary>
        /// Constructor which creates the object with its default ingredients, price, and calories.
        /// </summary>
        public JurassicJava()
        {
            this.Decaf = false;
            this.Ice = false;
            this.RoomForCream = false;
            this.Price = 0.99;
            this.Calories = 2;
            ingredients.Add("Coffee");
            ingredients.Add("Water");

        }

        /// <summary>
        /// Sets the sides price and calories depending on the chosen size.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 8;
                        break;

                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Adds ice to the list of ingredients.
        /// </summary>
        public void AddIce()
        {
            if (this.Ice == true)
            {
                this.Ice = false;
                Ingredients.Remove("Ice");
            }
            else
            {
                this.Ice = true;
                Ingredients.Add("Ice");
            }
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Sets leave room for cream to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            if (this.RoomForCream == false)
            {
                this.RoomForCream = true;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
            else
            {
                this.RoomForCream = false;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Toggles the decalf value.
        /// </summary>
        public void MakeDecaf()
        {
            if (this.Decaf == false)
            {
                this.Decaf = true;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
            }
            else if(this.Decaf == true)
            {
                this.Decaf = false;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Overrides the default ToString method to return the name of the menu item as it should be seen on the menu.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(!Decaf)
            return (size.ToString() + " Jurassic Java");
            else
            return (size.ToString() + " Decaf Jurassic Java");

        }

        /// <summary>
        /// Returns the special cases associated with this instance of the item such as holding part of the ingredients.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice)
                {
                    special.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    special.Add("Leave Room For Cream");
                }
                return special.ToArray();
            }
        }
    }


}
