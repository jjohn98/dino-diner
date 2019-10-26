/// Order.cs
/// Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definition for the order the customer makes and the specifics of the order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {

        private List<IOrderItem> items;

        /// <summary>
        /// Holds the items added to the customers order.
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Adds and item to the order.
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// Removes and item from the order
        /// </summary>
        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// Generic Constructor.
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
        }

        /// <summary>
        /// Private backing variable for the SubtotalCost.
        /// </summary>
        private double subtotalcost;

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

        /// <summary>
        /// Holds the summed cost of the items in the order without tax.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                subtotalcost = 0;
                foreach (IOrderItem i in items)
                {
                    subtotalcost += i.Price;
                }
                if (subtotalcost < 0)
                    subtotalcost = 0;
                return subtotalcost;
            }
        }

        /// <summary>
        /// Private backing variable for sales tax rate;
        /// </summary>
        private double salestaxrate = 0.0925;

        /// <summary>
        /// Current applicable sales tax rate for the order.
        /// </summary>
        public double SalesTaxRate {
            get
            {
                return salestaxrate;
            }

            protected set
            {
                if (value < 0)
                {
                    SalesTaxRate = value;
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        /// <summary>
        /// Cost of sales tax against the order's subtotal.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// Total cost of the order to be paid by customer.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
