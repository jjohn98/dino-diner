/// Order.cs
/// Author: Jack Johnson
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class definition for the order the customer makes and the specifics of the order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Holds the items added to the customers order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get; set;
        } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// Generic Constructor.
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Private backing variable for the SubtotalCost.
        /// </summary>
        private double subtotalcost;

        /// <summary>
        /// Holds the summed cost of the items in the order without tax.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                foreach (IOrderItem i in Items)
                {
                    subtotalcost += i.Price;
                }
                if (subtotalcost < 0)
                    subtotalcost = 0;
                return subtotalcost;
            }
        }

        /// <summary>
        /// Current applicable sales tax rate for the order.
        /// </summary>
        public double SalesTaxRate { get; protected set; }

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
