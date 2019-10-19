using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace MenuTest
{
    public class MockItems : IOrderItem
    {
        public double Price { get; set; }

        public string Description { get; set; }

        public string[] Special { get; set; }

        public class MockItem1 : IOrderItem
        {
            public double Price { get; set; } = 4;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public MockItem1(double price)
            {
                this.Price = price;
            }

            public MockItem1()
            {

            }
        }

        public class MockItem2 : IOrderItem
        {
            public double Price { get; set; } = 8;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public MockItem2(double price)
            {
                this.Price = price;
            }

            public MockItem2()
            {

            }
        }

        public class MockItem3 : IOrderItem
        {
            public double Price { get; set; } = 5;

            public string Description { get; set; }

            public string[] Special { get; set; }

            public MockItem3(double price)
            {
                this.Price = price;
            }

            public MockItem3()
            {

            }
        }
    }
}
