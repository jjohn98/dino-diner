using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {

        [Fact]
        public void ShouldNotReturnNegativeSubtotal()
        {
            Order o = new Order();
            o.Items.Add(new MockItems.MockItem1(-69));
            o.Items.Add(new MockItems.MockItem2(4));
            o.Items.Add(new MockItems.MockItem3(5));
            Assert.Equal<double>(0, o.SubtotalCost);
        }

        [Fact]
        public void ShouldGiveCorrectTotalPrice()
        {
            Order o = new Order();
            o.Items.Add(new MockItems.MockItem1(4));
            o.Items.Add(new MockItems.MockItem2(4));
            o.Items.Add(new MockItems.MockItem3(5));
            Assert.Equal<double>(13, o.SubtotalCost);
        }
    }
}
